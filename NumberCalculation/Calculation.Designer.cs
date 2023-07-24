namespace NumberCalculation
{
    partial class Calculation
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
            label1 = new Label();
            label2 = new Label();
            txtSayi1 = new TextBox();
            txtSayi2 = new TextBox();
            groupBox1 = new GroupBox();
            rbToplama = new RadioButton();
            rbCikarma = new RadioButton();
            rbCarpma = new RadioButton();
            rbBolme = new RadioButton();
            btnHesapla = new Button();
            lblSonuc = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(36, 34);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "1.Sayı";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(36, 89);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "2.Sayı";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSayi1
            // 
            txtSayi1.Location = new Point(180, 34);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(100, 23);
            txtSayi1.TabIndex = 2;
            // 
            // txtSayi2
            // 
            txtSayi2.Location = new Point(180, 90);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(100, 23);
            txtSayi2.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbBolme);
            groupBox1.Controls.Add(rbCarpma);
            groupBox1.Controls.Add(rbCikarma);
            groupBox1.Controls.Add(rbToplama);
            groupBox1.Location = new Point(36, 144);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 179);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "İşlemler";
            // 
            // rbToplama
            // 
            rbToplama.AutoSize = true;
            rbToplama.Location = new Point(6, 22);
            rbToplama.Name = "rbToplama";
            rbToplama.Size = new Size(70, 19);
            rbToplama.TabIndex = 0;
            rbToplama.TabStop = true;
            rbToplama.Text = "Toplama";
            rbToplama.UseVisualStyleBackColor = true;
            // 
            // rbCikarma
            // 
            rbCikarma.AutoSize = true;
            rbCikarma.Location = new Point(5, 60);
            rbCikarma.Name = "rbCikarma";
            rbCikarma.Size = new Size(69, 19);
            rbCikarma.TabIndex = 1;
            rbCikarma.TabStop = true;
            rbCikarma.Text = "Çıkarma";
            rbCikarma.UseVisualStyleBackColor = true;
            // 
            // rbCarpma
            // 
            rbCarpma.AutoSize = true;
            rbCarpma.Location = new Point(5, 98);
            rbCarpma.Name = "rbCarpma";
            rbCarpma.Size = new Size(67, 19);
            rbCarpma.TabIndex = 2;
            rbCarpma.TabStop = true;
            rbCarpma.Text = "Çarpma";
            rbCarpma.UseVisualStyleBackColor = true;
            // 
            // rbBolme
            // 
            rbBolme.AutoSize = true;
            rbBolme.Location = new Point(6, 136);
            rbBolme.Name = "rbBolme";
            rbBolme.Size = new Size(59, 19);
            rbBolme.TabIndex = 3;
            rbBolme.TabStop = true;
            rbBolme.Text = "Bölme";
            rbBolme.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(36, 339);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(244, 39);
            btnHesapla.TabIndex = 5;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.BorderStyle = BorderStyle.FixedSingle;
            lblSonuc.Location = new Point(36, 381);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(244, 67);
            lblSonuc.TabIndex = 6;
            lblSonuc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Calculation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 450);
            Controls.Add(lblSonuc);
            Controls.Add(btnHesapla);
            Controls.Add(groupBox1);
            Controls.Add(txtSayi2);
            Controls.Add(txtSayi1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Calculation";
            Text = "Calculation";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSayi1;
        private TextBox txtSayi2;
        private GroupBox groupBox1;
        private RadioButton rbBolme;
        private RadioButton rbCarpma;
        private RadioButton rbCikarma;
        private RadioButton rbToplama;
        private Button btnHesapla;
        private Label lblSonuc;
    }
}