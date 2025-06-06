
namespace KelimeEzberleme
{
    partial class FormLogin
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
            this.button_Giris = new System.Windows.Forms.Button();
            this.textBox_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.label_KullaniciAdi = new System.Windows.Forms.Label();
            this.label_Sifre = new System.Windows.Forms.Label();
            this.label_SifremiUnuttum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_KayitOl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Giris
            // 
            this.button_Giris.Location = new System.Drawing.Point(425, 198);
            this.button_Giris.Margin = new System.Windows.Forms.Padding(4);
            this.button_Giris.Name = "button_Giris";
            this.button_Giris.Size = new System.Drawing.Size(107, 47);
            this.button_Giris.TabIndex = 2;
            this.button_Giris.Text = "Giriş";
            this.button_Giris.UseVisualStyleBackColor = true;
            this.button_Giris.Click += new System.EventHandler(this.button_Giris_Click);
            // 
            // textBox_KullaniciAdi
            // 
            this.textBox_KullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_KullaniciAdi.Location = new System.Drawing.Point(275, 121);
            this.textBox_KullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_KullaniciAdi.Name = "textBox_KullaniciAdi";
            this.textBox_KullaniciAdi.Size = new System.Drawing.Size(132, 27);
            this.textBox_KullaniciAdi.TabIndex = 0;
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Sifre.Location = new System.Drawing.Point(275, 167);
            this.textBox_Sifre.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.Size = new System.Drawing.Size(132, 27);
            this.textBox_Sifre.TabIndex = 1;
            // 
            // label_KullaniciAdi
            // 
            this.label_KullaniciAdi.AutoSize = true;
            this.label_KullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_KullaniciAdi.Location = new System.Drawing.Point(115, 121);
            this.label_KullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_KullaniciAdi.Name = "label_KullaniciAdi";
            this.label_KullaniciAdi.Size = new System.Drawing.Size(114, 20);
            this.label_KullaniciAdi.TabIndex = 3;
            this.label_KullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // label_Sifre
            // 
            this.label_Sifre.AutoSize = true;
            this.label_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Sifre.Location = new System.Drawing.Point(115, 171);
            this.label_Sifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Sifre.Name = "label_Sifre";
            this.label_Sifre.Size = new System.Drawing.Size(49, 20);
            this.label_Sifre.TabIndex = 4;
            this.label_Sifre.Text = "Şifre";
            // 
            // label_SifremiUnuttum
            // 
            this.label_SifremiUnuttum.AutoSize = true;
            this.label_SifremiUnuttum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_SifremiUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_SifremiUnuttum.Location = new System.Drawing.Point(440, 281);
            this.label_SifremiUnuttum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SifremiUnuttum.Name = "label_SifremiUnuttum";
            this.label_SifremiUnuttum.Size = new System.Drawing.Size(137, 22);
            this.label_SifremiUnuttum.TabIndex = 4;
            this.label_SifremiUnuttum.Text = "Şifremi Unuttum";
            this.label_SifremiUnuttum.Click += new System.EventHandler(this.label_SifremiUnuttum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(107, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kelime Ezberlememe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_KayitOl
            // 
            this.label_KayitOl.AutoSize = true;
            this.label_KayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_KayitOl.Location = new System.Drawing.Point(16, 281);
            this.label_KayitOl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_KayitOl.Name = "label_KayitOl";
            this.label_KayitOl.Size = new System.Drawing.Size(73, 22);
            this.label_KayitOl.TabIndex = 3;
            this.label_KayitOl.Text = "Kayıt Ol";
            this.label_KayitOl.Click += new System.EventHandler(this.label_KayitOl_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.button_Giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 319);
            this.Controls.Add(this.label_KayitOl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_SifremiUnuttum);
            this.Controls.Add(this.label_Sifre);
            this.Controls.Add(this.label_KullaniciAdi);
            this.Controls.Add(this.textBox_Sifre);
            this.Controls.Add(this.textBox_KullaniciAdi);
            this.Controls.Add(this.button_Giris);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Giris;
        private System.Windows.Forms.TextBox textBox_KullaniciAdi;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.Label label_KullaniciAdi;
        private System.Windows.Forms.Label label_Sifre;
        private System.Windows.Forms.Label label_SifremiUnuttum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_KayitOl;
    }
}

