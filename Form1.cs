/* Project:     NyanTalk - Komunikator RS-232
 * Autor:       Marcin "Moneusz" Biczyski
 * Utworzony:   Grudzień 2011
 * Wersja:      0.5 Betav2 RC - Styczeń 2012
 * Media:       Twórcy oryginalnego NyanCat'a to: prguitarman i daniwell-P/Momone Momo UTAU
 *              Wykorzystano media powszechnie używane w internecie.
 * 
 * Dodatkowo:   Stworzono jako projekt z informatyki.
 *              Komunikator stworzony wyłącznie dla komputerów PC.
 *              Nie nadaje się do komunikacji z mikrokontrolerami, ani innymi urządzeniami typu.
 *              
 *              Have fun
 *              Nyan nyan nyan^^
 *              PS. Dzięki Engell za nazwę :*
 */

#region Namespace Inclusions
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Obsługa RS-232
using System.IO.Ports;

//Obsługa dźwięków
using System.Media;

//Obsługa plików w resource
using NyanTalk.Properties;
#endregion

namespace NyanTalk
{
    public partial class NyanTalk : Form
    {

        public NyanTalk()
        {
            InitializeComponent();

            //Wyszukanie dostępnych portów i ustawienie początkowych wartości
            comboBoxPort.Items.AddRange(SerialPort.GetPortNames());
            comboBoxPort.SelectedIndex = 0;
            comboBoxParity.SelectedIndex = 0;
            comboBoxHandshake.SelectedIndex = 1;
            comboBoxSTOP.SelectedIndex = 0;
            comboBoxData.SelectedIndex = 3;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (Port.IsOpen)
            {
                //Zamknięcie portu
                Port.Close();

                //Uaktywnianie i dezaktywacja przycisków
                buttonConnect.Text = "Połącz";
                comboBoxPort.Enabled = true;
                comboBoxParity.Enabled = true;
                comboBoxSpeed.Enabled = true;
                comboBoxHandshake.Enabled = true;
                comboBoxSTOP.Enabled = true;
                comboBoxData.Enabled = true;
                richTextBoxReceived.Enabled = false;
                richTextBoxSent.Enabled = false;
                textBoxSend.Enabled = false;
                buttonSend.Enabled = false;
            }
            else
            {
                Boolean BladPortu = false;
                try
                {
                    //Sprawdzenie wybranego portu ze standardowymi ustawieniami
                    Port.PortName = comboBoxPort.Text;
                    Port.Open();
                    Port.Close();
                }
                catch
                {
                    //Wyświetlenie powiadomienia i usunięcie niesprawnego portu z listy
                    MessageBox.Show("Wybrany port COM jest niedostępny");
                    comboBoxPort.Items.Remove(comboBoxPort.Text);
                    comboBoxPort.SelectedIndex = 0;
                    BladPortu = true;
                }

                if (!BladPortu)
                {
                    //Gdy nie ma błedów port zostaje otwarty dla wybranych ustawień
                    switch (comboBoxSTOP.Text)
                    {
                        case "1": Port.StopBits = StopBits.One; break;
                        case "1.5": Port.StopBits = StopBits.OnePointFive; break;
                        case "2": Port.StopBits = StopBits.Two; break;
                    }
                    Port.BaudRate = int.Parse(comboBoxSpeed.Text);
                    Port.DataBits = int.Parse(comboBoxData.Text);
                    Port.PortName = comboBoxPort.Text;
                    switch (comboBoxParity.Text)
                    {
                        case "Brak (N)": Port.Parity = Parity.None; break;
                        case "Parzyste (E)": Port.Parity = Parity.Even; break;
                        case "Nieparzyste (O)": Port.Parity = Parity.Odd; break;
                        case "Zawsze 1 (M)": Port.Parity = Parity.Mark; break;
                        case "Zawsze 0 (S)": Port.Parity = Parity.Space; break;
                    }
                    switch (comboBoxHandshake.Text)
                    {
                        case "Brak": Port.Handshake = Handshake.None; break;
                        case "XOnXOff": Port.Handshake = Handshake.XOnXOff; break;
                        case "RTS": Port.Handshake = Handshake.RequestToSend; break;
                        case "RTS + XOnXOff": Port.Handshake = Handshake.RequestToSendXOnXOff; break;
                    }
                    Port.Open();

                    //Uaktywnianie i dezaktywacja przycisków
                    buttonConnect.Text = "Rozłącz";
                    comboBoxPort.Enabled = false;
                    comboBoxParity.Enabled = false;
                    comboBoxSpeed.Enabled = false;
                    comboBoxHandshake.Enabled = false;
                    comboBoxSTOP.Enabled = false;
                    comboBoxData.Enabled = false;
                    richTextBoxReceived.Enabled = true;
                    richTextBoxSent.Enabled = true;
                    textBoxSend.Enabled = true;
                    buttonSend.Enabled = true;
                }
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            //Przy wpisaniu "Nyan" lub "nyan" grana jest melodyjka :3
            if (textBoxSend.Text.Contains("nyan") | textBoxSend.Text.Contains("Nyan"))
            {
                SoundPlayer Nyan = new SoundPlayer(Resources.NyanCatringtone);
                Nyan.Play();
            }

            //Wysyłanie wiadomości przez Serialport
            Port.WriteLine(textBoxSend.Text);

            //Wyświetlanie wiadomości po stronie wysyłającego
            richTextBoxSent.Text += textBoxSend.Text+"\n";
            richTextBoxSent.Select(richTextBoxSent.Text.Length, 0);
            richTextBoxSent.ScrollToCaret();
            textBoxSend.Clear();
        }
           
        private void textBoxSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Umożliwienie zatwierdzania Enterem
            if (e.KeyChar == (char)13)
            {
                buttonSend_Click(sender, e);
            }
        }

        private void comboBoxSTOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Narzucenie 7 bitów danych przy STOP równym 1,5 czasu trania bitu
            if (comboBoxSTOP.Text == "1.5")
            {
                comboBoxData.Text = "7";
                comboBoxData.Enabled = false;
            }
            else
            {
                comboBoxData.Enabled = true;
            }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Odbieranie danych (Invoke jest po to, aby rozkazy były wykonywane na wątku z richTextBoxReceived)
            richTextBoxReceived.Invoke(new EventHandler(delegate { richTextBoxReceived.Text += Port.ReadExisting(); }));
            richTextBoxReceived.Invoke(new EventHandler(delegate { richTextBoxReceived.Select(richTextBoxReceived.Text.Length, 0); }));
            richTextBoxReceived.Invoke(new EventHandler(delegate { richTextBoxReceived.ScrollToCaret(); }));
        }
    }
}