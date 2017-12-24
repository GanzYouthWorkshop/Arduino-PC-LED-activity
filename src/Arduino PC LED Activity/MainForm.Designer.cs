namespace GEV.PCActivity
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
            this.gclWindowHeader1 = new GEV.Layouts.GCLWindowHeader();
            this.cbxSerialPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gclButton1 = new GEV.Layouts.GCLButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCounter1 = new System.Windows.Forms.ComboBox();
            this.cbxCounter2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCounter3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCounter4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gclWindowHeader1
            // 
            this.gclWindowHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.gclWindowHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gclWindowHeader1.Location = new System.Drawing.Point(1, 1);
            this.gclWindowHeader1.Name = "gclWindowHeader1";
            this.gclWindowHeader1.ShowWindowButtons = false;
            this.gclWindowHeader1.Size = new System.Drawing.Size(588, 40);
            this.gclWindowHeader1.TabIndex = 0;
            this.gclWindowHeader1.Title = "PC Activity Display";
            // 
            // cbxSerialPort
            // 
            this.cbxSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSerialPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSerialPort.FormattingEnabled = true;
            this.cbxSerialPort.ItemHeight = 17;
            this.cbxSerialPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.cbxSerialPort.Location = new System.Drawing.Point(103, 54);
            this.cbxSerialPort.MinimumSize = new System.Drawing.Size(121, 0);
            this.cbxSerialPort.Name = "cbxSerialPort";
            this.cbxSerialPort.Size = new System.Drawing.Size(121, 25);
            this.cbxSerialPort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Soros port:";
            // 
            // gclButton1
            // 
            this.gclButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gclButton1.FlatAppearance.BorderSize = 0;
            this.gclButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.gclButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(174)))), ((int)(((byte)(169)))));
            this.gclButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gclButton1.ForeColor = System.Drawing.Color.White;
            this.gclButton1.Location = new System.Drawing.Point(230, 54);
            this.gclButton1.Name = "gclButton1";
            this.gclButton1.Size = new System.Drawing.Size(139, 25);
            this.gclButton1.TabIndex = 4;
            this.gclButton1.Text = "CSATLAKOZÁS";
            this.gclButton1.UseVisualStyleBackColor = false;
            this.gclButton1.Click += new System.EventHandler(this.gclButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "1. csatorna tartalma:";
            // 
            // cbxCounter1
            // 
            this.cbxCounter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCounter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCounter1.FormattingEnabled = true;
            this.cbxCounter1.ItemHeight = 17;
            this.cbxCounter1.Location = new System.Drawing.Point(161, 103);
            this.cbxCounter1.MinimumSize = new System.Drawing.Size(121, 0);
            this.cbxCounter1.Name = "cbxCounter1";
            this.cbxCounter1.Size = new System.Drawing.Size(408, 25);
            this.cbxCounter1.TabIndex = 6;
            this.cbxCounter1.SelectedIndexChanged += new System.EventHandler(this.OnChangeCounter);
            // 
            // cbxCounter2
            // 
            this.cbxCounter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCounter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCounter2.FormattingEnabled = true;
            this.cbxCounter2.ItemHeight = 17;
            this.cbxCounter2.Location = new System.Drawing.Point(161, 134);
            this.cbxCounter2.MinimumSize = new System.Drawing.Size(121, 0);
            this.cbxCounter2.Name = "cbxCounter2";
            this.cbxCounter2.Size = new System.Drawing.Size(408, 25);
            this.cbxCounter2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "2. csatorna tartalma:";
            // 
            // cbxCounter3
            // 
            this.cbxCounter3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCounter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCounter3.FormattingEnabled = true;
            this.cbxCounter3.ItemHeight = 17;
            this.cbxCounter3.Location = new System.Drawing.Point(161, 165);
            this.cbxCounter3.MinimumSize = new System.Drawing.Size(121, 0);
            this.cbxCounter3.Name = "cbxCounter3";
            this.cbxCounter3.Size = new System.Drawing.Size(408, 25);
            this.cbxCounter3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "3. csatorna tartalma:";
            // 
            // cbxCounter4
            // 
            this.cbxCounter4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCounter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCounter4.FormattingEnabled = true;
            this.cbxCounter4.ItemHeight = 17;
            this.cbxCounter4.Location = new System.Drawing.Point(161, 196);
            this.cbxCounter4.MinimumSize = new System.Drawing.Size(121, 0);
            this.cbxCounter4.Name = "cbxCounter4";
            this.cbxCounter4.Size = new System.Drawing.Size(408, 25);
            this.cbxCounter4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "4. csatorna tartalma:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(590, 248);
            this.Controls.Add(this.cbxCounter4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxCounter3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxCounter2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxCounter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gclButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSerialPort);
            this.Controls.Add(this.gclWindowHeader1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Layouts.GCLWindowHeader gclWindowHeader1;
        private System.Windows.Forms.ComboBox cbxSerialPort;
        private System.Windows.Forms.Label label1;
        private Layouts.GCLButton gclButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCounter1;
        private System.Windows.Forms.ComboBox cbxCounter2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCounter3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCounter4;
        private System.Windows.Forms.Label label5;
    }
}

