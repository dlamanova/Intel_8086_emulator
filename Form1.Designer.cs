namespace Intel_8086_emulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dh = new System.Windows.Forms.TextBox();
            this.ch = new System.Windows.Forms.TextBox();
            this.bh = new System.Windows.Forms.TextBox();
            this.ah = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.al = new System.Windows.Forms.TextBox();
            this.bl = new System.Windows.Forms.TextBox();
            this.cl = new System.Windows.Forms.TextBox();
            this.dl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FirstValComboBox = new System.Windows.Forms.ComboBox();
            this.SecondValComboBox = new System.Windows.Forms.ComboBox();
            this.OperationComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.execButton = new System.Windows.Forms.Button();
            this.RandomButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dh
            // 
            this.dh.Location = new System.Drawing.Point(172, 321);
            this.dh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dh.Name = "dh";
            this.dh.Size = new System.Drawing.Size(132, 22);
            this.dh.TabIndex = 9;
            // 
            // ch
            // 
            this.ch.Location = new System.Drawing.Point(172, 284);
            this.ch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ch.Name = "ch";
            this.ch.Size = new System.Drawing.Size(132, 22);
            this.ch.TabIndex = 10;
            // 
            // bh
            // 
            this.bh.Location = new System.Drawing.Point(172, 247);
            this.bh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bh.Name = "bh";
            this.bh.Size = new System.Drawing.Size(132, 22);
            this.bh.TabIndex = 11;
            // 
            // ah
            // 
            this.ah.Location = new System.Drawing.Point(172, 209);
            this.ah.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ah.Name = "ah";
            this.ah.Size = new System.Drawing.Size(132, 22);
            this.ah.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(63, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "AX";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.Location = new System.Drawing.Point(63, 247);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "BX";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Tan;
            this.label3.Location = new System.Drawing.Point(63, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "CX";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Tan;
            this.label4.Location = new System.Drawing.Point(63, 321);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "DX";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // al
            // 
            this.al.Location = new System.Drawing.Point(333, 209);
            this.al.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.al.Name = "al";
            this.al.Size = new System.Drawing.Size(132, 22);
            this.al.TabIndex = 20;
            // 
            // bl
            // 
            this.bl.Location = new System.Drawing.Point(333, 247);
            this.bl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bl.Name = "bl";
            this.bl.Size = new System.Drawing.Size(132, 22);
            this.bl.TabIndex = 21;
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(333, 286);
            this.cl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(132, 22);
            this.cl.TabIndex = 22;
            // 
            // dl
            // 
            this.dl.Location = new System.Drawing.Point(333, 322);
            this.dl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dl.Name = "dl";
            this.dl.Size = new System.Drawing.Size(132, 22);
            this.dl.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Tan;
            this.label5.Location = new System.Drawing.Point(172, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "H";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Tan;
            this.label6.Location = new System.Drawing.Point(333, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "L";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label7.Location = new System.Drawing.Point(168, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "First value";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label8.Location = new System.Drawing.Point(333, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Second value";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstValComboBox
            // 
            this.FirstValComboBox.FormattingEnabled = true;
            this.FirstValComboBox.Items.AddRange(new object[] {
            "AH",
            "BH",
            "CH",
            "DH",
            "AL",
            "BL",
            "CL",
            "DL"});
            this.FirstValComboBox.Location = new System.Drawing.Point(168, 95);
            this.FirstValComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FirstValComboBox.Name = "FirstValComboBox";
            this.FirstValComboBox.Size = new System.Drawing.Size(132, 24);
            this.FirstValComboBox.TabIndex = 28;
            // 
            // SecondValComboBox
            // 
            this.SecondValComboBox.FormattingEnabled = true;
            this.SecondValComboBox.Items.AddRange(new object[] {
            "AH",
            "BH",
            "CH",
            "DH",
            "AL",
            "BL",
            "CL",
            "DL"});
            this.SecondValComboBox.Location = new System.Drawing.Point(333, 95);
            this.SecondValComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SecondValComboBox.Name = "SecondValComboBox";
            this.SecondValComboBox.Size = new System.Drawing.Size(132, 24);
            this.SecondValComboBox.TabIndex = 29;
            // 
            // OperationComboBox
            // 
            this.OperationComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.OperationComboBox.FormattingEnabled = true;
            this.OperationComboBox.Items.AddRange(new object[] {
            "MOV",
            "XCHG",
            "ADD",
            "SUB",
            "AND",
            "OR"});
            this.OperationComboBox.Location = new System.Drawing.Point(519, 95);
            this.OperationComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OperationComboBox.Name = "OperationComboBox";
            this.OperationComboBox.Size = new System.Drawing.Size(132, 24);
            this.OperationComboBox.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label9.Location = new System.Drawing.Point(519, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Operation";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // execButton
            // 
            this.execButton.BackColor = System.Drawing.Color.LightSalmon;
            this.execButton.Location = new System.Drawing.Point(519, 286);
            this.execButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.execButton.Name = "execButton";
            this.execButton.Size = new System.Drawing.Size(133, 62);
            this.execButton.TabIndex = 32;
            this.execButton.Text = "EXECUTE";
            this.execButton.UseVisualStyleBackColor = false;
            this.execButton.Click += new System.EventHandler(this.execButton_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.Location = new System.Drawing.Point(519, 209);
            this.RandomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(133, 25);
            this.RandomButton.TabIndex = 33;
            this.RandomButton.Text = "RANDOM";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(519, 247);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(133, 25);
            this.ResetButton.TabIndex = 34;
            this.ResetButton.Text = "RESET";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 484);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.execButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.OperationComboBox);
            this.Controls.Add(this.SecondValComboBox);
            this.Controls.Add(this.FirstValComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dl);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.bl);
            this.Controls.Add(this.al);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ah);
            this.Controls.Add(this.bh);
            this.Controls.Add(this.ch);
            this.Controls.Add(this.dh);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox dh;
        private System.Windows.Forms.TextBox ch;
        private System.Windows.Forms.TextBox bh;
        private System.Windows.Forms.TextBox ah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox al;
        private System.Windows.Forms.TextBox bl;
        private System.Windows.Forms.TextBox cl;
        private System.Windows.Forms.TextBox dl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox FirstValComboBox;
        private System.Windows.Forms.ComboBox SecondValComboBox;
        private System.Windows.Forms.ComboBox OperationComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button execButton;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.Button ResetButton;
    }
}

