namespace KelimeEzberleme
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_KullaniciAdi = new System.Windows.Forms.Label();
            this.textBox_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.label_Sifre = new System.Windows.Forms.Label();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.button_Giris = new System.Windows.Forms.Button();
            this.label_KayitOl = new System.Windows.Forms.Label();
            this.label_SifremiUnuttum = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.label_KullaniciAdi);
            this.panelMain.Controls.Add(this.textBox_KullaniciAdi);
            this.panelMain.Controls.Add(this.label_Sifre);
            this.panelMain.Controls.Add(this.textBox_Sifre);
            this.panelMain.Controls.Add(this.button_Giris);
            this.panelMain.Controls.Add(this.label_KayitOl);
            this.panelMain.Controls.Add(this.label_SifremiUnuttum);
            this.panelMain.Location = new System.Drawing.Point(-3, -4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(598, 410);
            this.panelMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(126, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelime Ezberleme";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label_KullaniciAdi
            // 
            this.label_KullaniciAdi.AutoSize = true;
            this.label_KullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_KullaniciAdi.ForeColor = System.Drawing.Color.DimGray;
            this.label_KullaniciAdi.Location = new System.Drawing.Point(70, 131);
            this.label_KullaniciAdi.Name = "label_KullaniciAdi";
            this.label_KullaniciAdi.Size = new System.Drawing.Size(132, 28);
            this.label_KullaniciAdi.TabIndex = 1;
            this.label_KullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // textBox_KullaniciAdi
            // 
            this.textBox_KullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_KullaniciAdi.Location = new System.Drawing.Point(268, 128);
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
            this.label_Sifre.Location = new System.Drawing.Point(97, 180);
            this.label_Sifre.Name = "label_Sifre";
            this.label_Sifre.Size = new System.Drawing.Size(56, 28);
            this.label_Sifre.TabIndex = 3;
            this.label_Sifre.Text = "Şifre";
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Sifre.Location = new System.Drawing.Point(268, 180);
            this.textBox_Sifre.MaxLength = 32;
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.PasswordChar = '●';
            this.textBox_Sifre.Size = new System.Drawing.Size(200, 34);
            this.textBox_Sifre.TabIndex = 4;
            // 
            // button_Giris
            // 
            this.button_Giris.BackColor = System.Drawing.Color.SeaGreen;
            this.button_Giris.FlatAppearance.BorderSize = 0;
            this.button_Giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Giris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button_Giris.ForeColor = System.Drawing.Color.White;
            this.button_Giris.Location = new System.Drawing.Point(268, 257);
            this.button_Giris.Name = "button_Giris";
            this.button_Giris.Size = new System.Drawing.Size(200, 37);
            this.button_Giris.TabIndex = 5;
            this.button_Giris.Text = "Giriş";
            this.button_Giris.UseVisualStyleBackColor = false;
            this.button_Giris.Click += new System.EventHandler(this.button_Giris_Click);
            // 
            // label_KayitOl
            // 
            this.label_KayitOl.AutoSize = true;
            this.label_KayitOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_KayitOl.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_KayitOl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_KayitOl.Location = new System.Drawing.Point(26, 356);
            this.label_KayitOl.Name = "label_KayitOl";
            this.label_KayitOl.Size = new System.Drawing.Size(69, 23);
            this.label_KayitOl.TabIndex = 6;
            this.label_KayitOl.Text = "Kayıt Ol";
            this.label_KayitOl.Click += new System.EventHandler(this.label_KayitOl_Click);
            // 
            // label_SifremiUnuttum
            // 
            this.label_SifremiUnuttum.AutoSize = true;
            this.label_SifremiUnuttum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_SifremiUnuttum.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_SifremiUnuttum.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_SifremiUnuttum.Location = new System.Drawing.Point(423, 356);
            this.label_SifremiUnuttum.Name = "label_SifremiUnuttum";
            this.label_SifremiUnuttum.Size = new System.Drawing.Size(132, 23);
            this.label_SifremiUnuttum.TabIndex = 7;
            this.label_SifremiUnuttum.Text = "Şifremi Unuttum";
            this.label_SifremiUnuttum.Click += new System.EventHandler(this.label_SifremiUnuttum_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.button_Giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(592, 403);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Ezberleme - Giriş";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_KullaniciAdi;
        private System.Windows.Forms.TextBox textBox_KullaniciAdi;
        private System.Windows.Forms.Label label_Sifre;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.Button button_Giris;
        private System.Windows.Forms.Label label_KayitOl;
        private System.Windows.Forms.Label label_SifremiUnuttum;
    }
}
