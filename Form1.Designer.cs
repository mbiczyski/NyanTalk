namespace NyanTalk
{
    partial class NyanTalk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NyanTalk));
            this.richTextBoxSent = new System.Windows.Forms.RichTextBox();
            this.richTextBoxReceived = new System.Windows.Forms.RichTextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelSent = new System.Windows.Forms.Label();
            this.labelReceived = new System.Windows.Forms.Label();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.comboBoxSpeed = new System.Windows.Forms.ComboBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelParity = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.Port = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxHandshake = new System.Windows.Forms.ComboBox();
            this.labelHandshake = new System.Windows.Forms.Label();
            this.comboBoxSTOP = new System.Windows.Forms.ComboBox();
            this.labelSTOP = new System.Windows.Forms.Label();
            this.comboBoxData = new System.Windows.Forms.ComboBox();
            this.labelData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxSent
            // 
            this.richTextBoxSent.Enabled = false;
            this.richTextBoxSent.Location = new System.Drawing.Point(50, 125);
            this.richTextBoxSent.Name = "richTextBoxSent";
            this.richTextBoxSent.ReadOnly = true;
            this.richTextBoxSent.Size = new System.Drawing.Size(200, 275);
            this.richTextBoxSent.TabIndex = 1;
            this.richTextBoxSent.Text = "";
            // 
            // richTextBoxReceived
            // 
            this.richTextBoxReceived.Enabled = false;
            this.richTextBoxReceived.Location = new System.Drawing.Point(300, 125);
            this.richTextBoxReceived.Name = "richTextBoxReceived";
            this.richTextBoxReceived.ReadOnly = true;
            this.richTextBoxReceived.Size = new System.Drawing.Size(200, 320);
            this.richTextBoxReceived.TabIndex = 2;
            this.richTextBoxReceived.Text = "";
            // 
            // buttonConnect
            // 
            this.buttonConnect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonConnect.Location = new System.Drawing.Point(391, 50);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 21);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Połącz";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelSent
            // 
            this.labelSent.AutoSize = true;
            this.labelSent.Location = new System.Drawing.Point(47, 109);
            this.labelSent.Name = "labelSent";
            this.labelSent.Size = new System.Drawing.Size(50, 13);
            this.labelSent.TabIndex = 5;
            this.labelSent.Text = "Wysłane";
            // 
            // labelReceived
            // 
            this.labelReceived.AutoSize = true;
            this.labelReceived.Location = new System.Drawing.Point(297, 109);
            this.labelReceived.Name = "labelReceived";
            this.labelReceived.Size = new System.Drawing.Size(54, 13);
            this.labelReceived.TabIndex = 6;
            this.labelReceived.Text = "Odebrane";
            // 
            // textBoxSend
            // 
            this.textBoxSend.Enabled = false;
            this.textBoxSend.Location = new System.Drawing.Point(50, 425);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(175, 20);
            this.textBoxSend.TabIndex = 7;
            this.textBoxSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSend_KeyPress);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(47, 409);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(63, 13);
            this.labelMessage.TabIndex = 8;
            this.labelMessage.Text = "Wiadomość";
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSend.Location = new System.Drawing.Point(231, 425);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(50, 20);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Wyślij";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(225, 25);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(70, 21);
            this.comboBoxPort.Sorted = true;
            this.comboBoxPort.TabIndex = 10;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "Brak (N)",
            "Parzyste (E)",
            "Nieparzyste (O)",
            "Zawsze 1 (M)",
            "Zawsze 0 (S)"});
            this.comboBoxParity.Location = new System.Drawing.Point(200, 75);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(95, 21);
            this.comboBoxParity.TabIndex = 11;
            this.comboBoxParity.Tag = "";
            // 
            // comboBoxSpeed
            // 
            this.comboBoxSpeed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSpeed.FormatString = "N0";
            this.comboBoxSpeed.FormattingEnabled = true;
            this.comboBoxSpeed.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBoxSpeed.Location = new System.Drawing.Point(325, 50);
            this.comboBoxSpeed.Name = "comboBoxSpeed";
            this.comboBoxSpeed.Size = new System.Drawing.Size(60, 21);
            this.comboBoxSpeed.TabIndex = 12;
            this.comboBoxSpeed.Text = "9600";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(222, 9);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 13;
            this.labelPort.Text = "Port";
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(197, 59);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(58, 13);
            this.labelParity.TabIndex = 14;
            this.labelParity.Text = "Parzystość";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(322, 34);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(52, 13);
            this.labelSpeed.TabIndex = 15;
            this.labelSpeed.Text = "Prędkość";
            // 
            // Port
            // 
            this.Port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Port_DataReceived);
            // 
            // comboBoxHandshake
            // 
            this.comboBoxHandshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHandshake.FormattingEnabled = true;
            this.comboBoxHandshake.Items.AddRange(new object[] {
            "Brak",
            "XOnXOff",
            "RTS",
            "RTS + XOnXOff"});
            this.comboBoxHandshake.Location = new System.Drawing.Point(75, 75);
            this.comboBoxHandshake.Name = "comboBoxHandshake";
            this.comboBoxHandshake.Size = new System.Drawing.Size(85, 21);
            this.comboBoxHandshake.TabIndex = 16;
            // 
            // labelHandshake
            // 
            this.labelHandshake.AutoSize = true;
            this.labelHandshake.Location = new System.Drawing.Point(72, 59);
            this.labelHandshake.Name = "labelHandshake";
            this.labelHandshake.Size = new System.Drawing.Size(62, 13);
            this.labelHandshake.TabIndex = 17;
            this.labelHandshake.Text = "Handshake";
            // 
            // comboBoxSTOP
            // 
            this.comboBoxSTOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSTOP.FormattingEnabled = true;
            this.comboBoxSTOP.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBoxSTOP.Location = new System.Drawing.Point(150, 25);
            this.comboBoxSTOP.Name = "comboBoxSTOP";
            this.comboBoxSTOP.Size = new System.Drawing.Size(50, 21);
            this.comboBoxSTOP.TabIndex = 18;
            this.comboBoxSTOP.SelectedIndexChanged += new System.EventHandler(this.comboBoxSTOP_SelectedIndexChanged);
            // 
            // labelSTOP
            // 
            this.labelSTOP.AutoSize = true;
            this.labelSTOP.Location = new System.Drawing.Point(147, 9);
            this.labelSTOP.Name = "labelSTOP";
            this.labelSTOP.Size = new System.Drawing.Size(55, 13);
            this.labelSTOP.TabIndex = 19;
            this.labelSTOP.Text = "Bity Stopu";
            // 
            // comboBoxData
            // 
            this.comboBoxData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxData.FormattingEnabled = true;
            this.comboBoxData.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBoxData.Location = new System.Drawing.Point(75, 25);
            this.comboBoxData.Name = "comboBoxData";
            this.comboBoxData.Size = new System.Drawing.Size(50, 21);
            this.comboBoxData.TabIndex = 20;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(72, 9);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(64, 13);
            this.labelData.TabIndex = 21;
            this.labelData.Text = "Bity Danych";
            // 
            // NyanTalk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.BackgroundImage = global::NyanTalk.Properties.Resources.nyan_cat_background;
            this.ClientSize = new System.Drawing.Size(549, 462);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.comboBoxData);
            this.Controls.Add(this.labelSTOP);
            this.Controls.Add(this.comboBoxSTOP);
            this.Controls.Add(this.labelHandshake);
            this.Controls.Add(this.comboBoxHandshake);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelParity);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.comboBoxSpeed);
            this.Controls.Add(this.comboBoxParity);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.labelReceived);
            this.Controls.Add(this.labelSent);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.richTextBoxReceived);
            this.Controls.Add(this.richTextBoxSent);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "NyanTalk";
            this.Text = "NyanTalk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxSent;
        private System.Windows.Forms.RichTextBox richTextBoxReceived;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelSent;
        private System.Windows.Forms.Label labelReceived;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.ComboBox comboBoxSpeed;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.Label labelSpeed;
        private System.IO.Ports.SerialPort Port;
        private System.Windows.Forms.ComboBox comboBoxHandshake;
        private System.Windows.Forms.Label labelHandshake;
        private System.Windows.Forms.ComboBox comboBoxSTOP;
        private System.Windows.Forms.Label labelSTOP;
        private System.Windows.Forms.ComboBox comboBoxData;
        private System.Windows.Forms.Label labelData;
    }
}

