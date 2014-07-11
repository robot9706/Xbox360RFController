namespace Xbox360RFModuleSerial
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.comlbl = new System.Windows.Forms.Label();
            this.portCombo = new System.Windows.Forms.ComboBox();
            this.openButton = new System.Windows.Forms.Button();
            this.commandBox = new System.Windows.Forms.GroupBox();
            this.controllerBox = new System.Windows.Forms.GroupBox();
            this.syncButton = new System.Windows.Forms.Button();
            this.controllerOff = new System.Windows.Forms.Button();
            this.greenManualBox = new System.Windows.Forms.GroupBox();
            this.greenLed4Combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sendGreenLedsButton = new System.Windows.Forms.Button();
            this.greenLed3Combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.greenLed2Combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.greenLed1Combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.redBox = new System.Windows.Forms.GroupBox();
            this.fRedBlinkAllButton = new System.Windows.Forms.Button();
            this.ledsAmber = new System.Windows.Forms.Button();
            this.fRedBlink4Button = new System.Windows.Forms.Button();
            this.clearErrorButton = new System.Windows.Forms.Button();
            this.fRedBlink3Button = new System.Windows.Forms.Button();
            this.fRedBlink2Button = new System.Windows.Forms.Button();
            this.fRedBlink1Button = new System.Windows.Forms.Button();
            this.redBlinkAllButton = new System.Windows.Forms.Button();
            this.redBlink4Button = new System.Windows.Forms.Button();
            this.redBlink3Button = new System.Windows.Forms.Button();
            this.redBlink2Button = new System.Windows.Forms.Button();
            this.redBlink1Button = new System.Windows.Forms.Button();
            this.bootAnimBlinkPWRButton = new System.Windows.Forms.Button();
            this.ledInitBlinkPWRButton = new System.Windows.Forms.Button();
            this.bootAnimNoPwrButton = new System.Windows.Forms.Button();
            this.ledInitNoPwr = new System.Windows.Forms.Button();
            this.bootAnimButton = new System.Windows.Forms.Button();
            this.redManualBox = new System.Windows.Forms.GroupBox();
            this.redLed4Combo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sendRedLedsButton = new System.Windows.Forms.Button();
            this.redLed3Combo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.redLed2Combo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.redLed1Combo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ledOffButton = new System.Windows.Forms.Button();
            this.powerLed = new System.Windows.Forms.Button();
            this.configBox = new System.Windows.Forms.GroupBox();
            this.configButton = new System.Windows.Forms.Button();
            this.orientationCombo = new System.Windows.Forms.ComboBox();
            this.orientationlbl = new System.Windows.Forms.Label();
            this.powerCombo = new System.Windows.Forms.ComboBox();
            this.powerlbl = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.helpLbl = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.commandBox.SuspendLayout();
            this.controllerBox.SuspendLayout();
            this.greenManualBox.SuspendLayout();
            this.redBox.SuspendLayout();
            this.redManualBox.SuspendLayout();
            this.configBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // comlbl
            // 
            this.comlbl.AutoSize = true;
            this.comlbl.Location = new System.Drawing.Point(15, 17);
            this.comlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comlbl.Name = "comlbl";
            this.comlbl.Size = new System.Drawing.Size(67, 16);
            this.comlbl.TabIndex = 0;
            this.comlbl.Text = "COM port:";
            // 
            // portCombo
            // 
            this.portCombo.FormattingEnabled = true;
            this.portCombo.Location = new System.Drawing.Point(88, 12);
            this.portCombo.Name = "portCombo";
            this.portCombo.Size = new System.Drawing.Size(214, 24);
            this.portCombo.TabIndex = 1;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(308, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openPort);
            // 
            // commandBox
            // 
            this.commandBox.Controls.Add(this.controllerBox);
            this.commandBox.Controls.Add(this.greenManualBox);
            this.commandBox.Controls.Add(this.redBox);
            this.commandBox.Controls.Add(this.bootAnimBlinkPWRButton);
            this.commandBox.Controls.Add(this.ledInitBlinkPWRButton);
            this.commandBox.Controls.Add(this.bootAnimNoPwrButton);
            this.commandBox.Controls.Add(this.ledInitNoPwr);
            this.commandBox.Controls.Add(this.bootAnimButton);
            this.commandBox.Controls.Add(this.redManualBox);
            this.commandBox.Controls.Add(this.ledOffButton);
            this.commandBox.Controls.Add(this.powerLed);
            this.commandBox.Controls.Add(this.configBox);
            this.commandBox.Enabled = false;
            this.commandBox.Location = new System.Drawing.Point(17, 48);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(877, 410);
            this.commandBox.TabIndex = 3;
            this.commandBox.TabStop = false;
            this.commandBox.Text = "Commands:";
            // 
            // controllerBox
            // 
            this.controllerBox.Controls.Add(this.syncButton);
            this.controllerBox.Controls.Add(this.controllerOff);
            this.controllerBox.Location = new System.Drawing.Point(22, 197);
            this.controllerBox.Name = "controllerBox";
            this.controllerBox.Size = new System.Drawing.Size(312, 69);
            this.controllerBox.TabIndex = 15;
            this.controllerBox.TabStop = false;
            this.controllerBox.Text = "Controller(s)";
            // 
            // syncButton
            // 
            this.syncButton.Location = new System.Drawing.Point(17, 23);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(136, 35);
            this.syncButton.TabIndex = 0;
            this.syncButton.Tag = "0";
            this.syncButton.Text = "Sync controllers";
            this.syncButton.UseVisualStyleBackColor = true;
            this.syncButton.Click += new System.EventHandler(this.syncButton_Click);
            // 
            // controllerOff
            // 
            this.controllerOff.Location = new System.Drawing.Point(161, 23);
            this.controllerOff.Name = "controllerOff";
            this.controllerOff.Size = new System.Drawing.Size(136, 35);
            this.controllerOff.TabIndex = 1;
            this.controllerOff.Tag = "0";
            this.controllerOff.Text = "Turn controller(s) off";
            this.controllerOff.UseVisualStyleBackColor = true;
            this.controllerOff.Click += new System.EventHandler(this.controllerOff_Click);
            // 
            // greenManualBox
            // 
            this.greenManualBox.Controls.Add(this.greenLed4Combo);
            this.greenManualBox.Controls.Add(this.label4);
            this.greenManualBox.Controls.Add(this.sendGreenLedsButton);
            this.greenManualBox.Controls.Add(this.greenLed3Combo);
            this.greenManualBox.Controls.Add(this.label3);
            this.greenManualBox.Controls.Add(this.greenLed2Combo);
            this.greenManualBox.Controls.Add(this.label1);
            this.greenManualBox.Controls.Add(this.greenLed1Combo);
            this.greenManualBox.Controls.Add(this.label2);
            this.greenManualBox.Location = new System.Drawing.Point(619, 22);
            this.greenManualBox.Name = "greenManualBox";
            this.greenManualBox.Size = new System.Drawing.Size(248, 179);
            this.greenManualBox.TabIndex = 4;
            this.greenManualBox.TabStop = false;
            this.greenManualBox.Text = "Green leds";
            // 
            // greenLed4Combo
            // 
            this.greenLed4Combo.FormattingEnabled = true;
            this.greenLed4Combo.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.greenLed4Combo.Location = new System.Drawing.Point(86, 109);
            this.greenLed4Combo.Name = "greenLed4Combo";
            this.greenLed4Combo.Size = new System.Drawing.Size(151, 24);
            this.greenLed4Combo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "LED 4:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sendGreenLedsButton
            // 
            this.sendGreenLedsButton.Location = new System.Drawing.Point(62, 138);
            this.sendGreenLedsButton.Name = "sendGreenLedsButton";
            this.sendGreenLedsButton.Size = new System.Drawing.Size(136, 35);
            this.sendGreenLedsButton.TabIndex = 10;
            this.sendGreenLedsButton.Tag = "0";
            this.sendGreenLedsButton.Text = "Send";
            this.sendGreenLedsButton.UseVisualStyleBackColor = true;
            this.sendGreenLedsButton.Click += new System.EventHandler(this.sendGreenLedsButton_Click);
            // 
            // greenLed3Combo
            // 
            this.greenLed3Combo.FormattingEnabled = true;
            this.greenLed3Combo.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.greenLed3Combo.Location = new System.Drawing.Point(86, 79);
            this.greenLed3Combo.Name = "greenLed3Combo";
            this.greenLed3Combo.Size = new System.Drawing.Size(151, 24);
            this.greenLed3Combo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "LED 3:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // greenLed2Combo
            // 
            this.greenLed2Combo.FormattingEnabled = true;
            this.greenLed2Combo.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.greenLed2Combo.Location = new System.Drawing.Point(86, 49);
            this.greenLed2Combo.Name = "greenLed2Combo";
            this.greenLed2Combo.Size = new System.Drawing.Size(151, 24);
            this.greenLed2Combo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "LED 2:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // greenLed1Combo
            // 
            this.greenLed1Combo.FormattingEnabled = true;
            this.greenLed1Combo.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.greenLed1Combo.Location = new System.Drawing.Point(86, 19);
            this.greenLed1Combo.Name = "greenLed1Combo";
            this.greenLed1Combo.Size = new System.Drawing.Size(151, 24);
            this.greenLed1Combo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "LED 1:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // redBox
            // 
            this.redBox.Controls.Add(this.fRedBlinkAllButton);
            this.redBox.Controls.Add(this.ledsAmber);
            this.redBox.Controls.Add(this.fRedBlink4Button);
            this.redBox.Controls.Add(this.clearErrorButton);
            this.redBox.Controls.Add(this.fRedBlink3Button);
            this.redBox.Controls.Add(this.fRedBlink2Button);
            this.redBox.Controls.Add(this.fRedBlink1Button);
            this.redBox.Controls.Add(this.redBlinkAllButton);
            this.redBox.Controls.Add(this.redBlink4Button);
            this.redBox.Controls.Add(this.redBlink3Button);
            this.redBox.Controls.Add(this.redBlink2Button);
            this.redBox.Controls.Add(this.redBlink1Button);
            this.redBox.Location = new System.Drawing.Point(365, 212);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(502, 182);
            this.redBox.TabIndex = 13;
            this.redBox.TabStop = false;
            this.redBox.Text = "Error";
            // 
            // fRedBlinkAllButton
            // 
            this.fRedBlinkAllButton.Location = new System.Drawing.Point(320, 103);
            this.fRedBlinkAllButton.Name = "fRedBlinkAllButton";
            this.fRedBlinkAllButton.Size = new System.Drawing.Size(118, 35);
            this.fRedBlinkAllButton.TabIndex = 20;
            this.fRedBlinkAllButton.Tag = "0";
            this.fRedBlinkAllButton.Text = "Fast blink all";
            this.fRedBlinkAllButton.UseVisualStyleBackColor = true;
            this.fRedBlinkAllButton.Click += new System.EventHandler(this.fRedBlinkAllButton_Click);
            // 
            // ledsAmber
            // 
            this.ledsAmber.Location = new System.Drawing.Point(47, 141);
            this.ledsAmber.Name = "ledsAmber";
            this.ledsAmber.Size = new System.Drawing.Size(166, 35);
            this.ledsAmber.TabIndex = 14;
            this.ledsAmber.Tag = "0";
            this.ledsAmber.Text = "All leds amber";
            this.ledsAmber.UseVisualStyleBackColor = true;
            this.ledsAmber.Click += new System.EventHandler(this.ledsAmber_Click);
            // 
            // fRedBlink4Button
            // 
            this.fRedBlink4Button.Location = new System.Drawing.Point(384, 62);
            this.fRedBlink4Button.Name = "fRedBlink4Button";
            this.fRedBlink4Button.Size = new System.Drawing.Size(118, 35);
            this.fRedBlink4Button.TabIndex = 19;
            this.fRedBlink4Button.Tag = "0";
            this.fRedBlink4Button.Text = "Fast blink 4";
            this.fRedBlink4Button.UseVisualStyleBackColor = true;
            this.fRedBlink4Button.Click += new System.EventHandler(this.fRedBlink4Button_Click);
            // 
            // clearErrorButton
            // 
            this.clearErrorButton.Location = new System.Drawing.Point(298, 141);
            this.clearErrorButton.Name = "clearErrorButton";
            this.clearErrorButton.Size = new System.Drawing.Size(166, 35);
            this.clearErrorButton.TabIndex = 12;
            this.clearErrorButton.Tag = "0";
            this.clearErrorButton.Text = "Clear error (red/orange)";
            this.clearErrorButton.UseVisualStyleBackColor = true;
            this.clearErrorButton.Click += new System.EventHandler(this.clearErrorButton_Click);
            // 
            // fRedBlink3Button
            // 
            this.fRedBlink3Button.Location = new System.Drawing.Point(258, 62);
            this.fRedBlink3Button.Name = "fRedBlink3Button";
            this.fRedBlink3Button.Size = new System.Drawing.Size(118, 35);
            this.fRedBlink3Button.TabIndex = 18;
            this.fRedBlink3Button.Tag = "0";
            this.fRedBlink3Button.Text = "Fast blink 3";
            this.fRedBlink3Button.UseVisualStyleBackColor = true;
            this.fRedBlink3Button.Click += new System.EventHandler(this.fRedBlink3Button_Click);
            // 
            // fRedBlink2Button
            // 
            this.fRedBlink2Button.Location = new System.Drawing.Point(384, 21);
            this.fRedBlink2Button.Name = "fRedBlink2Button";
            this.fRedBlink2Button.Size = new System.Drawing.Size(118, 35);
            this.fRedBlink2Button.TabIndex = 17;
            this.fRedBlink2Button.Tag = "0";
            this.fRedBlink2Button.Text = "Fast blink 2";
            this.fRedBlink2Button.UseVisualStyleBackColor = true;
            this.fRedBlink2Button.Click += new System.EventHandler(this.fRedBlink2Button_Click);
            // 
            // fRedBlink1Button
            // 
            this.fRedBlink1Button.Location = new System.Drawing.Point(258, 21);
            this.fRedBlink1Button.Name = "fRedBlink1Button";
            this.fRedBlink1Button.Size = new System.Drawing.Size(118, 35);
            this.fRedBlink1Button.TabIndex = 16;
            this.fRedBlink1Button.Tag = "0";
            this.fRedBlink1Button.Text = "Fast blink 1";
            this.fRedBlink1Button.UseVisualStyleBackColor = true;
            this.fRedBlink1Button.Click += new System.EventHandler(this.fRedBlink1Button_Click);
            // 
            // redBlinkAllButton
            // 
            this.redBlinkAllButton.Location = new System.Drawing.Point(70, 101);
            this.redBlinkAllButton.Name = "redBlinkAllButton";
            this.redBlinkAllButton.Size = new System.Drawing.Size(118, 35);
            this.redBlinkAllButton.TabIndex = 15;
            this.redBlinkAllButton.Tag = "0";
            this.redBlinkAllButton.Text = "Slow blink all";
            this.redBlinkAllButton.UseVisualStyleBackColor = true;
            this.redBlinkAllButton.Click += new System.EventHandler(this.redBlinkAllButton_Click);
            // 
            // redBlink4Button
            // 
            this.redBlink4Button.Location = new System.Drawing.Point(134, 60);
            this.redBlink4Button.Name = "redBlink4Button";
            this.redBlink4Button.Size = new System.Drawing.Size(118, 35);
            this.redBlink4Button.TabIndex = 14;
            this.redBlink4Button.Tag = "0";
            this.redBlink4Button.Text = "Slow blink 4";
            this.redBlink4Button.UseVisualStyleBackColor = true;
            this.redBlink4Button.Click += new System.EventHandler(this.redBlink4Button_Click);
            // 
            // redBlink3Button
            // 
            this.redBlink3Button.Location = new System.Drawing.Point(8, 60);
            this.redBlink3Button.Name = "redBlink3Button";
            this.redBlink3Button.Size = new System.Drawing.Size(118, 35);
            this.redBlink3Button.TabIndex = 13;
            this.redBlink3Button.Tag = "0";
            this.redBlink3Button.Text = "Slow blink 3";
            this.redBlink3Button.UseVisualStyleBackColor = true;
            this.redBlink3Button.Click += new System.EventHandler(this.redBlink3Button_Click);
            // 
            // redBlink2Button
            // 
            this.redBlink2Button.Location = new System.Drawing.Point(134, 19);
            this.redBlink2Button.Name = "redBlink2Button";
            this.redBlink2Button.Size = new System.Drawing.Size(118, 35);
            this.redBlink2Button.TabIndex = 12;
            this.redBlink2Button.Tag = "0";
            this.redBlink2Button.Text = "Slow blink 2";
            this.redBlink2Button.UseVisualStyleBackColor = true;
            this.redBlink2Button.Click += new System.EventHandler(this.redBlink2Button_Click);
            // 
            // redBlink1Button
            // 
            this.redBlink1Button.Location = new System.Drawing.Point(8, 19);
            this.redBlink1Button.Name = "redBlink1Button";
            this.redBlink1Button.Size = new System.Drawing.Size(118, 35);
            this.redBlink1Button.TabIndex = 11;
            this.redBlink1Button.Tag = "0";
            this.redBlink1Button.Text = "Slow blink 1";
            this.redBlink1Button.UseVisualStyleBackColor = true;
            this.redBlink1Button.Click += new System.EventHandler(this.redBlink1Button_Click);
            // 
            // bootAnimBlinkPWRButton
            // 
            this.bootAnimBlinkPWRButton.Location = new System.Drawing.Point(180, 112);
            this.bootAnimBlinkPWRButton.Name = "bootAnimBlinkPWRButton";
            this.bootAnimBlinkPWRButton.Size = new System.Drawing.Size(168, 35);
            this.bootAnimBlinkPWRButton.TabIndex = 9;
            this.bootAnimBlinkPWRButton.Tag = "0";
            this.bootAnimBlinkPWRButton.Text = "Boot anim... (blinl PWR)";
            this.bootAnimBlinkPWRButton.UseVisualStyleBackColor = true;
            this.bootAnimBlinkPWRButton.Click += new System.EventHandler(this.bootAnimBlinkPWRButton_Click);
            // 
            // ledInitBlinkPWRButton
            // 
            this.ledInitBlinkPWRButton.Location = new System.Drawing.Point(6, 111);
            this.ledInitBlinkPWRButton.Name = "ledInitBlinkPWRButton";
            this.ledInitBlinkPWRButton.Size = new System.Drawing.Size(168, 35);
            this.ledInitBlinkPWRButton.TabIndex = 8;
            this.ledInitBlinkPWRButton.Tag = "0";
            this.ledInitBlinkPWRButton.Text = "Init leds (blink PWR)";
            this.ledInitBlinkPWRButton.UseVisualStyleBackColor = true;
            this.ledInitBlinkPWRButton.Click += new System.EventHandler(this.ledInitBlinkPWRButton_Click);
            // 
            // bootAnimNoPwrButton
            // 
            this.bootAnimNoPwrButton.Location = new System.Drawing.Point(180, 66);
            this.bootAnimNoPwrButton.Name = "bootAnimNoPwrButton";
            this.bootAnimNoPwrButton.Size = new System.Drawing.Size(168, 35);
            this.bootAnimNoPwrButton.TabIndex = 7;
            this.bootAnimNoPwrButton.Tag = "0";
            this.bootAnimNoPwrButton.Text = "Boot animation (no PWR)";
            this.bootAnimNoPwrButton.UseVisualStyleBackColor = true;
            this.bootAnimNoPwrButton.Click += new System.EventHandler(this.bootAnimNoPwrButton_Click);
            // 
            // ledInitNoPwr
            // 
            this.ledInitNoPwr.Location = new System.Drawing.Point(6, 66);
            this.ledInitNoPwr.Name = "ledInitNoPwr";
            this.ledInitNoPwr.Size = new System.Drawing.Size(168, 35);
            this.ledInitNoPwr.TabIndex = 6;
            this.ledInitNoPwr.Tag = "0";
            this.ledInitNoPwr.Text = "Init leds (no PWR)";
            this.ledInitNoPwr.UseVisualStyleBackColor = true;
            this.ledInitNoPwr.Click += new System.EventHandler(this.ledInitNoPwr_Click);
            // 
            // bootAnimButton
            // 
            this.bootAnimButton.Location = new System.Drawing.Point(180, 22);
            this.bootAnimButton.Name = "bootAnimButton";
            this.bootAnimButton.Size = new System.Drawing.Size(168, 35);
            this.bootAnimButton.TabIndex = 5;
            this.bootAnimButton.Tag = "0";
            this.bootAnimButton.Text = "Boot animation";
            this.bootAnimButton.UseVisualStyleBackColor = true;
            this.bootAnimButton.Click += new System.EventHandler(this.bootAnimButton_Click);
            // 
            // redManualBox
            // 
            this.redManualBox.Controls.Add(this.redLed4Combo);
            this.redManualBox.Controls.Add(this.label5);
            this.redManualBox.Controls.Add(this.sendRedLedsButton);
            this.redManualBox.Controls.Add(this.redLed3Combo);
            this.redManualBox.Controls.Add(this.label6);
            this.redManualBox.Controls.Add(this.redLed2Combo);
            this.redManualBox.Controls.Add(this.label7);
            this.redManualBox.Controls.Add(this.redLed1Combo);
            this.redManualBox.Controls.Add(this.label8);
            this.redManualBox.Location = new System.Drawing.Point(365, 22);
            this.redManualBox.Name = "redManualBox";
            this.redManualBox.Size = new System.Drawing.Size(248, 179);
            this.redManualBox.TabIndex = 11;
            this.redManualBox.TabStop = false;
            this.redManualBox.Text = "Red leds";
            // 
            // redLed4Combo
            // 
            this.redLed4Combo.FormattingEnabled = true;
            this.redLed4Combo.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.redLed4Combo.Location = new System.Drawing.Point(86, 109);
            this.redLed4Combo.Name = "redLed4Combo";
            this.redLed4Combo.Size = new System.Drawing.Size(151, 24);
            this.redLed4Combo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "LED 4:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sendRedLedsButton
            // 
            this.sendRedLedsButton.Location = new System.Drawing.Point(62, 138);
            this.sendRedLedsButton.Name = "sendRedLedsButton";
            this.sendRedLedsButton.Size = new System.Drawing.Size(136, 35);
            this.sendRedLedsButton.TabIndex = 10;
            this.sendRedLedsButton.Tag = "0";
            this.sendRedLedsButton.Text = "Send";
            this.sendRedLedsButton.UseVisualStyleBackColor = true;
            this.sendRedLedsButton.Click += new System.EventHandler(this.sendRedLedsButton_Click);
            // 
            // redLed3Combo
            // 
            this.redLed3Combo.FormattingEnabled = true;
            this.redLed3Combo.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.redLed3Combo.Location = new System.Drawing.Point(86, 79);
            this.redLed3Combo.Name = "redLed3Combo";
            this.redLed3Combo.Size = new System.Drawing.Size(151, 24);
            this.redLed3Combo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "LED 3:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // redLed2Combo
            // 
            this.redLed2Combo.FormattingEnabled = true;
            this.redLed2Combo.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.redLed2Combo.Location = new System.Drawing.Point(86, 49);
            this.redLed2Combo.Name = "redLed2Combo";
            this.redLed2Combo.Size = new System.Drawing.Size(151, 24);
            this.redLed2Combo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "LED 2:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // redLed1Combo
            // 
            this.redLed1Combo.FormattingEnabled = true;
            this.redLed1Combo.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.redLed1Combo.Location = new System.Drawing.Point(86, 19);
            this.redLed1Combo.Name = "redLed1Combo";
            this.redLed1Combo.Size = new System.Drawing.Size(151, 24);
            this.redLed1Combo.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(7, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "LED 1:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ledOffButton
            // 
            this.ledOffButton.Location = new System.Drawing.Point(99, 156);
            this.ledOffButton.Name = "ledOffButton";
            this.ledOffButton.Size = new System.Drawing.Size(164, 35);
            this.ledOffButton.TabIndex = 4;
            this.ledOffButton.Tag = "0";
            this.ledOffButton.Text = "Led(s) off";
            this.ledOffButton.UseVisualStyleBackColor = true;
            this.ledOffButton.Click += new System.EventHandler(this.ledOffButton_Click);
            // 
            // powerLed
            // 
            this.powerLed.Location = new System.Drawing.Point(6, 22);
            this.powerLed.Name = "powerLed";
            this.powerLed.Size = new System.Drawing.Size(168, 35);
            this.powerLed.TabIndex = 3;
            this.powerLed.Tag = "0";
            this.powerLed.Text = "Init leds (power led)";
            this.powerLed.UseVisualStyleBackColor = true;
            this.powerLed.Click += new System.EventHandler(this.powerLed_Click);
            // 
            // configBox
            // 
            this.configBox.Controls.Add(this.configButton);
            this.configBox.Controls.Add(this.orientationCombo);
            this.configBox.Controls.Add(this.orientationlbl);
            this.configBox.Controls.Add(this.powerCombo);
            this.configBox.Controls.Add(this.powerlbl);
            this.configBox.Location = new System.Drawing.Point(52, 272);
            this.configBox.Name = "configBox";
            this.configBox.Size = new System.Drawing.Size(248, 126);
            this.configBox.TabIndex = 2;
            this.configBox.TabStop = false;
            this.configBox.Text = "RF config";
            // 
            // configButton
            // 
            this.configButton.Location = new System.Drawing.Point(57, 80);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(136, 35);
            this.configButton.TabIndex = 3;
            this.configButton.Tag = "0";
            this.configButton.Text = "Send config";
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.configButton_Click);
            // 
            // orientationCombo
            // 
            this.orientationCombo.FormattingEnabled = true;
            this.orientationCombo.Items.AddRange(new object[] {
            "Standing",
            "Horizontally"});
            this.orientationCombo.Location = new System.Drawing.Point(86, 49);
            this.orientationCombo.Name = "orientationCombo";
            this.orientationCombo.Size = new System.Drawing.Size(151, 24);
            this.orientationCombo.TabIndex = 3;
            // 
            // orientationlbl
            // 
            this.orientationlbl.Location = new System.Drawing.Point(4, 49);
            this.orientationlbl.Name = "orientationlbl";
            this.orientationlbl.Size = new System.Drawing.Size(76, 24);
            this.orientationlbl.TabIndex = 2;
            this.orientationlbl.Text = "Orientation:";
            this.orientationlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // powerCombo
            // 
            this.powerCombo.FormattingEnabled = true;
            this.powerCombo.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.powerCombo.Location = new System.Drawing.Point(86, 19);
            this.powerCombo.Name = "powerCombo";
            this.powerCombo.Size = new System.Drawing.Size(151, 24);
            this.powerCombo.TabIndex = 1;
            // 
            // powerlbl
            // 
            this.powerlbl.Location = new System.Drawing.Point(7, 19);
            this.powerlbl.Name = "powerlbl";
            this.powerlbl.Size = new System.Drawing.Size(73, 25);
            this.powerlbl.TabIndex = 0;
            this.powerlbl.Text = "Power:";
            this.powerlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // closeButton
            // 
            this.closeButton.Enabled = false;
            this.closeButton.Location = new System.Drawing.Point(389, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closePort);
            // 
            // nameLbl
            // 
            this.nameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLbl.AutoSize = true;
            this.nameLbl.ForeColor = System.Drawing.Color.Silver;
            this.nameLbl.Location = new System.Drawing.Point(696, 458);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(207, 16);
            this.nameLbl.TabIndex = 5;
            this.nameLbl.Text = "Version 1.0  By Robot9706 ~ 2014";
            // 
            // helpLbl
            // 
            this.helpLbl.AutoSize = true;
            this.helpLbl.Location = new System.Drawing.Point(470, 13);
            this.helpLbl.Name = "helpLbl";
            this.helpLbl.Size = new System.Drawing.Size(353, 32);
            this.helpLbl.TabIndex = 6;
            this.helpLbl.Text = "Connect the RTS to the Data PIN (pin 6 on RF module) and\r\nthe CTS to the Clock PI" +
    "N (pin 7 on RF module).";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(825, 29);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(63, 16);
            this.linkLabel.TabIndex = 7;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "More info";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 473);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.helpLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.commandBox);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.portCombo);
            this.Controls.Add(this.comlbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RF controller using COM port";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.commandBox.ResumeLayout(false);
            this.controllerBox.ResumeLayout(false);
            this.greenManualBox.ResumeLayout(false);
            this.redBox.ResumeLayout(false);
            this.redManualBox.ResumeLayout(false);
            this.configBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label comlbl;
        private System.Windows.Forms.ComboBox portCombo;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.GroupBox commandBox;
        private System.Windows.Forms.Button syncButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button controllerOff;
        private System.Windows.Forms.GroupBox configBox;
        private System.Windows.Forms.ComboBox orientationCombo;
        private System.Windows.Forms.Label orientationlbl;
        private System.Windows.Forms.ComboBox powerCombo;
        private System.Windows.Forms.Label powerlbl;
        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.Button powerLed;
        private System.Windows.Forms.Button ledOffButton;
        private System.Windows.Forms.Button bootAnimButton;
        private System.Windows.Forms.Button ledInitNoPwr;
        private System.Windows.Forms.Button bootAnimNoPwrButton;
        private System.Windows.Forms.Button ledInitBlinkPWRButton;
        private System.Windows.Forms.Button bootAnimBlinkPWRButton;
        private System.Windows.Forms.GroupBox greenManualBox;
        private System.Windows.Forms.ComboBox greenLed4Combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sendGreenLedsButton;
        private System.Windows.Forms.ComboBox greenLed3Combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox greenLed2Combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox greenLed1Combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox redManualBox;
        private System.Windows.Forms.ComboBox redLed4Combo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sendRedLedsButton;
        private System.Windows.Forms.ComboBox redLed3Combo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox redLed2Combo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox redLed1Combo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clearErrorButton;
        private System.Windows.Forms.GroupBox redBox;
        private System.Windows.Forms.Button redBlinkAllButton;
        private System.Windows.Forms.Button redBlink4Button;
        private System.Windows.Forms.Button redBlink3Button;
        private System.Windows.Forms.Button redBlink2Button;
        private System.Windows.Forms.Button redBlink1Button;
        private System.Windows.Forms.Button fRedBlinkAllButton;
        private System.Windows.Forms.Button fRedBlink4Button;
        private System.Windows.Forms.Button fRedBlink3Button;
        private System.Windows.Forms.Button fRedBlink2Button;
        private System.Windows.Forms.Button fRedBlink1Button;
        private System.Windows.Forms.Button ledsAmber;
        private System.Windows.Forms.GroupBox controllerBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label helpLbl;
        private System.Windows.Forms.LinkLabel linkLabel;
    }
}

