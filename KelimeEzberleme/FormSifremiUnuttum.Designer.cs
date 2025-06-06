
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
            this.textBox_Eposta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Gonder = new System.Windows.Forms.Button();
            this.panel_SifreSifirlama = new System.Windows.Forms.Panel();
            this.button_SifreKaydet = new System.Windows.Forms.Button();
            this.textBox_sifre2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_sifre1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Dogrulama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_SifreSifirlama.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Eposta
            // 
            this.textBox_Eposta.Location = new System.Drawing.Point(127, 36);
            this.textBox_Eposta.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Eposta.Name = "textBox_Eposta";
            this.textBox_Eposta.Size = new System.Drawing.Size(276, 22);
            this.textBox_Eposta.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "E-Posta";
            // 
            // button_Gonder
            // 
            this.button_Gonder.Location = new System.Drawing.Point(297, 68);
            this.button_Gonder.Margin = new System.Windows.Forms.Padding(4);
            this.button_Gonder.Name = "button_Gonder";
            this.button_Gonder.Size = new System.Drawing.Size(107, 47);
            this.button_Gonder.TabIndex = 18;
            this.button_Gonder.Text = "Kod Gönder";
            this.button_Gonder.UseVisualStyleBackColor = true;
            this.button_Gonder.Click += new System.EventHandler(this.button_Gonder_Click);
            // 
            // panel_SifreSifirlama
            // 
            this.panel_SifreSifirlama.Controls.Add(this.button_SifreKaydet);
            this.panel_SifreSifirlama.Controls.Add(this.textBox_sifre2);
            this.panel_SifreSifirlama.Controls.Add(this.label4);
            this.panel_SifreSifirlama.Controls.Add(this.textBox_sifre1);
            this.panel_SifreSifirlama.Controls.Add(this.label2);
            this.panel_SifreSifirlama.Location = new System.Drawing.Point(45, 202);
            this.panel_SifreSifirlama.Margin = new System.Windows.Forms.Padding(4);
            this.panel_SifreSifirlama.Name = "panel_SifreSifirlama";
            this.panel_SifreSifirlama.Size = new System.Drawing.Size(405, 174);
            this.panel_SifreSifirlama.TabIndex = 19;
            this.panel_SifreSifirlama.Visible = false;
            // 
            // button_SifreKaydet
            // 
            this.button_SifreKaydet.Location = new System.Drawing.Point(135, 114);
            this.button_SifreKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.button_SifreKaydet.Name = "button_SifreKaydet";
            this.button_SifreKaydet.Size = new System.Drawing.Size(107, 47);
            this.button_SifreKaydet.TabIndex = 20;
            this.button_SifreKaydet.Text = "Kaydet";
            this.button_SifreKaydet.UseVisualStyleBackColor = true;
            this.button_SifreKaydet.Click += new System.EventHandler(this.button_Kaydet_Click);
            // 
            // textBox_sifre2
            // 
            this.textBox_sifre2.Location = new System.Drawing.Point(111, 73);
            this.textBox_sifre2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_sifre2.Name = "textBox_sifre2";
            this.textBox_sifre2.Size = new System.Drawing.Size(131, 22);
            this.textBox_sifre2.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Şifre Tekrar";
            // 
            // textBox_sifre1
            // 
            this.textBox_sifre1.Location = new System.Drawing.Point(111, 26);
            this.textBox_sifre1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_sifre1.Name = "textBox_sifre1";
            this.textBox_sifre1.Size = new System.Drawing.Size(131, 22);
            this.textBox_sifre1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Yeni Şifre";
            // 
            // textBox_Dogrulama
            // 
            this.textBox_Dogrulama.Enabled = false;
            this.textBox_Dogrulama.Location = new System.Drawing.Point(167, 142);
            this.textBox_Dogrulama.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Dogrulama.Name = "textBox_Dogrulama";
            this.textBox_Dogrulama.Size = new System.Drawing.Size(120, 22);
            this.textBox_Dogrulama.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Doğrulama Kodu";
            // 
            // FormSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 447);
            this.Controls.Add(this.panel_SifreSifirlama);
            this.Controls.Add(this.button_Gonder);
            this.Controls.Add(this.textBox_Eposta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Dogrulama);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSifremiUnuttum";
            this.Text = "FormSifremiUnuttum";
            this.Load += new System.EventHandler(this.FormSifremiUnuttum_Load);
            this.panel_SifreSifirlama.ResumeLayout(false);
            this.panel_SifreSifirlama.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Eposta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Gonder;
        private System.Windows.Forms.Panel panel_SifreSifirlama;
        private System.Windows.Forms.TextBox textBox_sifre2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_sifre1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Dogrulama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_SifreKaydet;
    }
}