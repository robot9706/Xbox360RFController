namespace Xbox360RFModuleSerial
{
    partial class ConnTestForm
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
            this.updateCb = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputDataLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.help2Lbl = new System.Windows.Forms.Label();
            this.inputHz = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.helpLbl = new System.Windows.Forms.Label();
            this.outputCb = new System.Windows.Forms.CheckBox();
            this.viewUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateCb
            // 
            this.updateCb.AutoSize = true;
            this.updateCb.Location = new System.Drawing.Point(9, 19);
            this.updateCb.Name = "updateCb";
            this.updateCb.Size = new System.Drawing.Size(83, 17);
            this.updateCb.TabIndex = 3;
            this.updateCb.Text = "Check input";
            this.updateCb.UseVisualStyleBackColor = true;
            this.updateCb.CheckedChanged += new System.EventHandler(this.updateCb_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Input (clock):";
            // 
            // inputDataLbl
            // 
            this.inputDataLbl.AutoSize = true;
            this.inputDataLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputDataLbl.Location = new System.Drawing.Point(76, 38);
            this.inputDataLbl.Name = "inputDataLbl";
            this.inputDataLbl.Size = new System.Drawing.Size(31, 16);
            this.inputDataLbl.TabIndex = 5;
            this.inputDataLbl.Text = "N/A";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.help2Lbl);
            this.groupBox1.Controls.Add(this.inputHz);
            this.groupBox1.Controls.Add(this.inputDataLbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.updateCb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 126);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clock test (CTS)";
            // 
            // help2Lbl
            // 
            this.help2Lbl.Location = new System.Drawing.Point(6, 54);
            this.help2Lbl.Name = "help2Lbl";
            this.help2Lbl.Size = new System.Drawing.Size(245, 69);
            this.help2Lbl.TabIndex = 3;
            this.help2Lbl.Text = "-";
            // 
            // inputHz
            // 
            this.inputHz.AutoSize = true;
            this.inputHz.Location = new System.Drawing.Point(120, 40);
            this.inputHz.Name = "inputHz";
            this.inputHz.Size = new System.Drawing.Size(33, 13);
            this.inputHz.TabIndex = 6;
            this.inputHz.Text = "~0Hz";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.helpLbl);
            this.groupBox2.Controls.Add(this.outputCb);
            this.groupBox2.Location = new System.Drawing.Point(275, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 126);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data test (RTS)";
            // 
            // helpLbl
            // 
            this.helpLbl.Location = new System.Drawing.Point(7, 40);
            this.helpLbl.Name = "helpLbl";
            this.helpLbl.Size = new System.Drawing.Size(212, 57);
            this.helpLbl.TabIndex = 2;
            this.helpLbl.Text = "-";
            // 
            // outputCb
            // 
            this.outputCb.AutoSize = true;
            this.outputCb.Location = new System.Drawing.Point(7, 16);
            this.outputCb.Name = "outputCb";
            this.outputCb.Size = new System.Drawing.Size(58, 17);
            this.outputCb.TabIndex = 0;
            this.outputCb.Text = "Output";
            this.outputCb.UseVisualStyleBackColor = true;
            this.outputCb.CheckedChanged += new System.EventHandler(this.outputCb_CheckedChanged);
            // 
            // viewUpdateTimer
            // 
            this.viewUpdateTimer.Tick += new System.EventHandler(this.viewUpdateTimer_Tick);
            // 
            // ConnTestForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(512, 152);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConnTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connection test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnTestForm_FormClosing);
            this.Load += new System.EventHandler(this.ConnTestForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox updateCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label inputDataLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label inputHz;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox outputCb;
        private System.Windows.Forms.Label helpLbl;
        private System.Windows.Forms.Label help2Lbl;
        private System.Windows.Forms.Timer viewUpdateTimer;
    }
}