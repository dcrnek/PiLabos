namespace Pi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.PocetnoStanje = new System.Windows.Forms.TextBox();
            this.BrojRodBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BrojPreminulihBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BrojIseljenih = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BrojUseljenihBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.KretanjeBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ObavijestBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pocetno stanje";
            // 
            // PocetnoStanje
            // 
            this.PocetnoStanje.Location = new System.Drawing.Point(16, 30);
            this.PocetnoStanje.Name = "PocetnoStanje";
            this.PocetnoStanje.Size = new System.Drawing.Size(65, 20);
            this.PocetnoStanje.TabIndex = 1;
            this.PocetnoStanje.TextChanged += new System.EventHandler(this.PocetnoStanje_TextChanged);
            // 
            // BrojRodBox
            // 
            this.BrojRodBox.Location = new System.Drawing.Point(151, 30);
            this.BrojRodBox.Name = "BrojRodBox";
            this.BrojRodBox.Size = new System.Drawing.Size(65, 20);
            this.BrojRodBox.TabIndex = 3;
            this.BrojRodBox.TextChanged += new System.EventHandler(this.BrojRodBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj rod";
            // 
            // BrojPreminulihBox
            // 
            this.BrojPreminulihBox.Location = new System.Drawing.Point(222, 30);
            this.BrojPreminulihBox.Name = "BrojPreminulihBox";
            this.BrojPreminulihBox.Size = new System.Drawing.Size(65, 20);
            this.BrojPreminulihBox.TabIndex = 5;
            this.BrojPreminulihBox.TextChanged += new System.EventHandler(this.BrojPreminulihBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preminulih";
            // 
            // BrojIseljenih
            // 
            this.BrojIseljenih.Location = new System.Drawing.Point(293, 30);
            this.BrojIseljenih.Name = "BrojIseljenih";
            this.BrojIseljenih.Size = new System.Drawing.Size(65, 20);
            this.BrojIseljenih.TabIndex = 7;
            this.BrojIseljenih.TextChanged += new System.EventHandler(this.BrojIseljenih_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Iseljenih";
            // 
            // BrojUseljenihBox
            // 
            this.BrojUseljenihBox.Location = new System.Drawing.Point(364, 30);
            this.BrojUseljenihBox.Name = "BrojUseljenihBox";
            this.BrojUseljenihBox.Size = new System.Drawing.Size(65, 20);
            this.BrojUseljenihBox.TabIndex = 9;
            this.BrojUseljenihBox.TextChanged += new System.EventHandler(this.BrojUseljenihBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Useljenih";
            // 
            // KretanjeBox
            // 
            this.KretanjeBox.FormattingEnabled = true;
            this.KretanjeBox.Location = new System.Drawing.Point(16, 172);
            this.KretanjeBox.Name = "KretanjeBox";
            this.KretanjeBox.Size = new System.Drawing.Size(342, 251);
            this.KretanjeBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kretanje";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Izracunaj Kretanje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ObavijestBox
            // 
            this.ObavijestBox.Location = new System.Drawing.Point(364, 172);
            this.ObavijestBox.Name = "ObavijestBox";
            this.ObavijestBox.Size = new System.Drawing.Size(200, 20);
            this.ObavijestBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Obavijest";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ObavijestBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.KretanjeBox);
            this.Controls.Add(this.BrojUseljenihBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BrojIseljenih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BrojPreminulihBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BrojRodBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PocetnoStanje);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PocetnoStanje;
        private System.Windows.Forms.TextBox BrojRodBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BrojPreminulihBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BrojIseljenih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BrojUseljenihBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox KretanjeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ObavijestBox;
        private System.Windows.Forms.Label label7;
    }
}

