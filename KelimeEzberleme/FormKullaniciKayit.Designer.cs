
namespace KelimeEzberleme
{
    partial class FormKullaniciKayit
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
            this.panelKayit = new System.Windows.Forms.Panel();
            this.labelBaslik = new System.Windows.Forms.Label();
            this.label_KullaniciAdi = new System.Windows.Forms.Label();
            this.textBox_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.label_Sifre = new System.Windows.Forms.Label();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Sifre_Tekrar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.button_Kayit = new System.Windows.Forms.Button();
            this.panelKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelKayit
            // 
            this.panelKayit.BackColor = System.Drawing.Color.White;
            this.panelKayit.Controls.Add(this.labelBaslik);
            this.panelKayit.Controls.Add(this.label_KullaniciAdi);
            this.panelKayit.Controls.Add(this.textBox_KullaniciAdi);
            this.panelKayit.Controls.Add(this.label_Sifre);
            this.panelKayit.Controls.Add(this.textBox_Sifre);
            this.panelKayit.Controls.Add(this.label4);
            this.panelKayit.Controls.Add(this.textBox_Sifre_Tekrar);
            this.panelKayit.Controls.Add(this.label2);
            this.panelKayit.Controls.Add(this.textBox_Ad);
            this.panelKayit.Controls.Add(this.label1);
            this.panelKayit.Controls.Add(this.textBox_Soyad);
            this.panelKayit.Controls.Add(this.label3);
            this.panelKayit.Controls.Add(this.textBox_Mail);
            this.panelKayit.Controls.Add(this.button_Kayit);
            this.panelKayit.Location = new System.Drawing.Point(-3, -5);
            this.panelKayit.Name = "panelKayit";
            this.panelKayit.Size = new System.Drawing.Size(500, 540);
            this.panelKayit.TabIndex = 0;
            this.panelKayit.Paint += new System.Windows.Forms.PaintEventHandler(this.panelKayit_Paint);
            // 
            // labelBaslik
            // 
            this.labelBaslik.AutoSize = true;
            this.labelBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelBaslik.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelBaslik.Location = new System.Drawing.Point(89, 40);
            this.labelBaslik.Name = "labelBaslik";
            this.labelBaslik.Size = new System.Drawing.Size(315, 41);
            this.labelBaslik.TabIndex = 0;
            this.labelBaslik.Text = "Kullanıcı Kayıt Ekranı";
            // 
            // label_KullaniciAdi
            // 
            this.label_KullaniciAdi.AutoSize = true;
            this.label_KullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_KullaniciAdi.ForeColor = System.Drawing.Color.DimGray;
            this.label_KullaniciAdi.Location = new System.Drawing.Point(58, 115);
            this.label_KullaniciAdi.Name = "label_KullaniciAdi";
            this.label_KullaniciAdi.Size = new System.Drawing.Size(132, 28);
            this.label_KullaniciAdi.TabIndex = 1;
            this.label_KullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // textBox_KullaniciAdi
            // 
            this.textBox_KullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_KullaniciAdi.Location = new System.Drawing.Point(228, 109);
            this.textBox_KullaniciAdi.MaxLength = 32;
            this.textBox_KullaniciAdi.Name = "textBox_KullaniciAdi";
            this.textBox_KullaniciAdi.Size = new System.Drawing.Size(200, 34);
            this.textBox_KullaniciAdi.TabIndex = 2;
            // 
            // label_Sifre
            // 
            this.label_Sifre.AutoSize = true;
            this.label_Sifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_Sifre.ForeColor = System.Drawing.Color.DimGray;
            this.label_Sifre.Location = new System.Drawing.Point(58, 170);
            this.label_Sifre.Name = "label_Sifre";
            this.label_Sifre.Size = new System.Drawing.Size(56, 28);
            this.label_Sifre.TabIndex = 3;
            this.label_Sifre.Text = "Şifre";
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Sifre.Location = new System.Drawing.Point(228, 164);
            this.textBox_Sifre.MaxLength = 32;
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.PasswordChar = '●';
            this.textBox_Sifre.Size = new System.Drawing.Size(200, 34);
            this.textBox_Sifre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(58, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Şifre Tekrar";
            // 
            // textBox_Sifre_Tekrar
            // 
            this.textBox_Sifre_Tekrar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Sifre_Tekrar.Location = new System.Drawing.Point(228, 221);
            this.textBox_Sifre_Tekrar.MaxLength = 32;
            this.textBox_Sifre_Tekrar.Name = "textBox_Sifre_Tekrar";
            this.textBox_Sifre_Tekrar.PasswordChar = '●';
            this.textBox_Sifre_Tekrar.Size = new System.Drawing.Size(200, 34);
            this.textBox_Sifre_Tekrar.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(58, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adı";
            // 
            // textBox_Ad
            // 
            this.textBox_Ad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Ad.Location = new System.Drawing.Point(228, 279);
            this.textBox_Ad.MaxLength = 32;
            this.textBox_Ad.Name = "textBox_Ad";
            this.textBox_Ad.Size = new System.Drawing.Size(200, 34);
            this.textBox_Ad.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(58, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Soyadı";
            // 
            // textBox_Soyad
            // 
            this.textBox_Soyad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Soyad.Location = new System.Drawing.Point(228, 341);
            this.textBox_Soyad.MaxLength = 32;
            this.textBox_Soyad.Name = "textBox_Soyad";
            this.textBox_Soyad.Size = new System.Drawing.Size(200, 34);
            this.textBox_Soyad.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(58, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "E-Posta";
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Mail.Location = new System.Drawing.Point(228, 398);
            this.textBox_Mail.MaxLength = 50;
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(200, 34);
            this.textBox_Mail.TabIndex = 12;
            // 
            // button_Kayit
            // 
            this.button_Kayit.BackColor = System.Drawing.Color.SeaGreen;
            this.button_Kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Kayit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button_Kayit.ForeColor = System.Drawing.Color.White;
            this.button_Kayit.Location = new System.Drawing.Point(278, 466);
            this.button_Kayit.Name = "button_Kayit";
            this.button_Kayit.Size = new System.Drawing.Size(150, 44);
            this.button_Kayit.TabIndex = 13;
            this.button_Kayit.Text = "Kaydet";
            this.button_Kayit.UseVisualStyleBackColor = false;
            this.button_Kayit.Click += new System.EventHandler(this.button_Kayit_Click);
            // 
            // FormKullaniciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(490, 530);
            this.Controls.Add(this.panelKayit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormKullaniciKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Kayıt";
            this.Load += new System.EventHandler(this.FormKullaniciKayit_Load);
            this.panelKayit.ResumeLayout(false);
            this.panelKayit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKayit;
        private System.Windows.Forms.Label labelBaslik;
        private System.Windows.Forms.Label label_KullaniciAdi;
        private System.Windows.Forms.TextBox textBox_KullaniciAdi;
        private System.Windows.Forms.Label label_Sifre;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Sifre_Tekrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.Button button_Kayit;
    }
}