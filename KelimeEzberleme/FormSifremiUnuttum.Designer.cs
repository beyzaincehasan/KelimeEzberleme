
namespace KelimeEzberleme
{
    partial class FormSifremiUnuttum
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelBaslik = new System.Windows.Forms.Label();
            this.labelEposta = new System.Windows.Forms.Label();
            this.textBox_Eposta = new System.Windows.Forms.TextBox();
            this.button_Gonder = new System.Windows.Forms.Button();
            this.labelDogrulama = new System.Windows.Forms.Label();
            this.textBox_Dogrulama = new System.Windows.Forms.TextBox();
            this.panel_SifreSifirlama = new System.Windows.Forms.Panel();
            this.button_SifreKaydet = new System.Windows.Forms.Button();
            this.textBox_sifre2 = new System.Windows.Forms.TextBox();
            this.labelSifreTekrar = new System.Windows.Forms.Label();
            this.textBox_sifre1 = new System.Windows.Forms.TextBox();
            this.labelYeniSifre = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panel_SifreSifirlama.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.labelBaslik);
            this.panelMain.Controls.Add(this.labelEposta);
            this.panelMain.Controls.Add(this.textBox_Eposta);
            this.panelMain.Controls.Add(this.button_Gonder);
            this.panelMain.Controls.Add(this.labelDogrulama);
            this.panelMain.Controls.Add(this.textBox_Dogrulama);
            this.panelMain.Controls.Add(this.panel_SifreSifirlama);
            this.panelMain.Location = new System.Drawing.Point(-8, -8);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(539, 524);
            this.panelMain.TabIndex = 0;
            // 
            // labelBaslik
            // 
            this.labelBaslik.Location = new System.Drawing.Point(0, 0);
            this.labelBaslik.Name = "labelBaslik";
            this.labelBaslik.Size = new System.Drawing.Size(100, 23);
            this.labelBaslik.TabIndex = 0;
            // 
            // labelEposta
            // 
            this.labelEposta.AutoSize = true;
            this.labelEposta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelEposta.ForeColor = System.Drawing.Color.DimGray;
            this.labelEposta.Location = new System.Drawing.Point(30, 65);
            this.labelEposta.Name = "labelEposta";
            this.labelEposta.Size = new System.Drawing.Size(82, 28);
            this.labelEposta.TabIndex = 1;
            this.labelEposta.Text = "E-Posta";
            // 
            // textBox_Eposta
            // 
            this.textBox_Eposta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Eposta.Location = new System.Drawing.Point(134, 62);
            this.textBox_Eposta.MaxLength = 50;
            this.textBox_Eposta.Name = "textBox_Eposta";
            this.textBox_Eposta.Size = new System.Drawing.Size(180, 34);
            this.textBox_Eposta.TabIndex = 2;
            // 
            // button_Gonder
            // 
            this.button_Gonder.BackColor = System.Drawing.Color.SeaGreen;
            this.button_Gonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Gonder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button_Gonder.ForeColor = System.Drawing.Color.White;
            this.button_Gonder.Location = new System.Drawing.Point(369, 48);
            this.button_Gonder.Name = "button_Gonder";
            this.button_Gonder.Size = new System.Drawing.Size(117, 64);
            this.button_Gonder.TabIndex = 3;
            this.button_Gonder.Text = "Kod Gönder";
            this.button_Gonder.UseVisualStyleBackColor = false;
            this.button_Gonder.Click += new System.EventHandler(this.button_Gonder_Click);
            // 
            // labelDogrulama
            // 
            this.labelDogrulama.AutoSize = true;
            this.labelDogrulama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelDogrulama.ForeColor = System.Drawing.Color.DimGray;
            this.labelDogrulama.Location = new System.Drawing.Point(30, 149);
            this.labelDogrulama.Name = "labelDogrulama";
            this.labelDogrulama.Size = new System.Drawing.Size(172, 28);
            this.labelDogrulama.TabIndex = 4;
            this.labelDogrulama.Text = "Doğrulama Kodu";
            // 
            // textBox_Dogrulama
            // 
            this.textBox_Dogrulama.Enabled = false;
            this.textBox_Dogrulama.Location = new System.Drawing.Point(233, 149);
            this.textBox_Dogrulama.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Dogrulama.Name = "textBox_Dogrulama";
            this.textBox_Dogrulama.Size = new System.Drawing.Size(120, 22);
            this.textBox_Dogrulama.TabIndex = 26;
            // 
            // panel_SifreSifirlama
            // 
            this.panel_SifreSifirlama.BackColor = System.Drawing.Color.Transparent;
            this.panel_SifreSifirlama.Controls.Add(this.button_SifreKaydet);
            this.panel_SifreSifirlama.Controls.Add(this.textBox_sifre2);
            this.panel_SifreSifirlama.Controls.Add(this.labelSifreTekrar);
            this.panel_SifreSifirlama.Controls.Add(this.textBox_sifre1);
            this.panel_SifreSifirlama.Controls.Add(this.labelYeniSifre);
            this.panel_SifreSifirlama.Location = new System.Drawing.Point(35, 231);
            this.panel_SifreSifirlama.Name = "panel_SifreSifirlama";
            this.panel_SifreSifirlama.Size = new System.Drawing.Size(451, 275);
            this.panel_SifreSifirlama.TabIndex = 6;
            this.panel_SifreSifirlama.Visible = false;
            // 
            // button_SifreKaydet
            // 
            this.button_SifreKaydet.BackColor = System.Drawing.Color.SeaGreen;
            this.button_SifreKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SifreKaydet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button_SifreKaydet.ForeColor = System.Drawing.Color.White;
            this.button_SifreKaydet.Location = new System.Drawing.Point(279, 211);
            this.button_SifreKaydet.Name = "button_SifreKaydet";
            this.button_SifreKaydet.Size = new System.Drawing.Size(120, 38);
            this.button_SifreKaydet.TabIndex = 9;
            this.button_SifreKaydet.Text = "Kaydet";
            this.button_SifreKaydet.UseVisualStyleBackColor = false;
            this.button_SifreKaydet.Click += new System.EventHandler(this.button_Kaydet_Click);
            // 
            // textBox_sifre2
            // 
            this.textBox_sifre2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_sifre2.Location = new System.Drawing.Point(168, 139);
            this.textBox_sifre2.Name = "textBox_sifre2";
            this.textBox_sifre2.PasswordChar = '●';
            this.textBox_sifre2.Size = new System.Drawing.Size(150, 34);
            this.textBox_sifre2.TabIndex = 8;
            // 
            // labelSifreTekrar
            // 
            this.labelSifreTekrar.AutoSize = true;
            this.labelSifreTekrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelSifreTekrar.ForeColor = System.Drawing.Color.DimGray;
            this.labelSifreTekrar.Location = new System.Drawing.Point(20, 145);
            this.labelSifreTekrar.Name = "labelSifreTekrar";
            this.labelSifreTekrar.Size = new System.Drawing.Size(121, 28);
            this.labelSifreTekrar.TabIndex = 7;
            this.labelSifreTekrar.Text = "Şifre Tekrar";
            // 
            // textBox_sifre1
            // 
            this.textBox_sifre1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_sifre1.Location = new System.Drawing.Point(168, 63);
            this.textBox_sifre1.Name = "textBox_sifre1";
            this.textBox_sifre1.PasswordChar = '●';
            this.textBox_sifre1.Size = new System.Drawing.Size(150, 34);
            this.textBox_sifre1.TabIndex = 6;
            // 
            // labelYeniSifre
            // 
            this.labelYeniSifre.AutoSize = true;
            this.labelYeniSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelYeniSifre.ForeColor = System.Drawing.Color.DimGray;
            this.labelYeniSifre.Location = new System.Drawing.Point(20, 69);
            this.labelYeniSifre.Name = "labelYeniSifre";
            this.labelYeniSifre.Size = new System.Drawing.Size(101, 28);
            this.labelYeniSifre.TabIndex = 5;
            this.labelYeniSifre.Text = "Yeni Şifre";
            // 
            // FormSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(525, 510);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi Unuttum";
            this.Load += new System.EventHandler(this.FormSifremiUnuttum_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel_SifreSifirlama.ResumeLayout(false);
            this.panel_SifreSifirlama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelBaslik;
        private System.Windows.Forms.Label labelEposta;
        private System.Windows.Forms.TextBox textBox_Eposta;
        private System.Windows.Forms.Button button_Gonder;
        private System.Windows.Forms.Label labelDogrulama;
        private System.Windows.Forms.TextBox textBox_Dogrulama;
        private System.Windows.Forms.Panel panel_SifreSifirlama;
        private System.Windows.Forms.Button button_SifreKaydet;
        private System.Windows.Forms.TextBox textBox_sifre2;
        private System.Windows.Forms.Label labelSifreTekrar;
        private System.Windows.Forms.TextBox textBox_sifre1;
        private System.Windows.Forms.Label labelYeniSifre;
    }
}