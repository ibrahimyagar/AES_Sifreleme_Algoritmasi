namespace AES
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtGizliMetin = new RichTextBox();
            chBilgi = new CheckBox();
            Şifrele = new Button();
            ŞifreÇöz = new Button();
            Oku = new Button();
            rtbSifreli = new RichTextBox();
            rtbSifresiz = new RichTextBox();
            Kaydet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 23);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Gizli Metin :";
            // 
            // txtGizliMetin
            // 
            txtGizliMetin.Location = new Point(143, 0);
            txtGizliMetin.Name = "txtGizliMetin";
            txtGizliMetin.Size = new Size(577, 138);
            txtGizliMetin.TabIndex = 1;
            txtGizliMetin.Text = "";
            // 
            // chBilgi
            // 
            chBilgi.AutoSize = true;
            chBilgi.Location = new Point(146, 150);
            chBilgi.Name = "chBilgi";
            chBilgi.Size = new Size(94, 24);
            chBilgi.TabIndex = 2;
            chBilgi.Text = "Gizli Bilgi";
            chBilgi.UseVisualStyleBackColor = true;
            // 
            // Şifrele
            // 
            Şifrele.Location = new Point(296, 202);
            Şifrele.Name = "Şifrele";
            Şifrele.Size = new Size(94, 29);
            Şifrele.TabIndex = 4;
            Şifrele.Text = "Şifrele";
            Şifrele.UseVisualStyleBackColor = true;
            Şifrele.Click += Şifrele_Click;
            // 
            // ŞifreÇöz
            // 
            ŞifreÇöz.Location = new Point(421, 202);
            ŞifreÇöz.Name = "ŞifreÇöz";
            ŞifreÇöz.Size = new Size(94, 29);
            ŞifreÇöz.TabIndex = 5;
            ŞifreÇöz.Text = "Şifre Çöz";
            ŞifreÇöz.UseVisualStyleBackColor = true;
            ŞifreÇöz.Click += ŞifreÇöz_Click;
            // 
            // Oku
            // 
            Oku.Location = new Point(585, 202);
            Oku.Name = "Oku";
            Oku.Size = new Size(94, 29);
            Oku.TabIndex = 6;
            Oku.Text = "Veri Oku";
            Oku.UseVisualStyleBackColor = true;
            Oku.Click += Oku_Click;
            // 
            // rtbSifreli
            // 
            rtbSifreli.Location = new Point(12, 237);
            rtbSifreli.Name = "rtbSifreli";
            rtbSifreli.Size = new Size(378, 220);
            rtbSifreli.TabIndex = 7;
            rtbSifreli.Text = "";
            // 
            // rtbSifresiz
            // 
            rtbSifresiz.Location = new Point(421, 237);
            rtbSifresiz.Name = "rtbSifresiz";
            rtbSifresiz.Size = new Size(367, 220);
            rtbSifresiz.TabIndex = 8;
            rtbSifresiz.Text = "";
            // 
            // Kaydet
            // 
            Kaydet.Location = new Point(143, 202);
            Kaydet.Name = "Kaydet";
            Kaydet.Size = new Size(94, 29);
            Kaydet.TabIndex = 10;
            Kaydet.Text = "Kaydet";
            Kaydet.UseVisualStyleBackColor = true;
            Kaydet.Click += Kaydet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Kaydet);
            Controls.Add(rtbSifresiz);
            Controls.Add(rtbSifreli);
            Controls.Add(Oku);
            Controls.Add(ŞifreÇöz);
            Controls.Add(Şifrele);
            Controls.Add(chBilgi);
            Controls.Add(txtGizliMetin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox txtGizliMetin;
        private CheckBox chBilgi;
        private Button Şifrele;
        private Button ŞifreÇöz;
        private Button Oku;
        private RichTextBox rtbSifreli;
        private RichTextBox rtbSifresiz;
        private Button Kaydet;
    }
}
