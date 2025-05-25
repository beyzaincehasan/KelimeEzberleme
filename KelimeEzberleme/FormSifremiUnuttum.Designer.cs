
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Gonder = new System.Windows.Forms.Button();
            this.panel_SifreSifirlama = new System.Windows.Forms.Panel();
            this.button_Kaydet = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Dogrulama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_SifreSifirlama.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(208, 20);
            this.textBox3.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "E-Posta";
            // 
            // button_Gonder
            // 
            this.button_Gonder.Location = new System.Drawing.Point(223, 55);
            this.button_Gonder.Name = "button_Gonder";
            this.button_Gonder.Size = new System.Drawing.Size(80, 38);
            this.button_Gonder.TabIndex = 18;
            this.button_Gonder.Text = "Kod Gönder";
            this.button_Gonder.UseVisualStyleBackColor = true;
            this.button_Gonder.Click += new System.EventHandler(this.button_Gonder_Click);
            // 
            // panel_SifreSifirlama
            // 
            this.panel_SifreSifirlama.Controls.Add(this.button_Kaydet);
            this.panel_SifreSifirlama.Controls.Add(this.textBox4);
            this.panel_SifreSifirlama.Controls.Add(this.label4);
            this.panel_SifreSifirlama.Controls.Add(this.textBox2);
            this.panel_SifreSifirlama.Controls.Add(this.label2);
            this.panel_SifreSifirlama.Location = new System.Drawing.Point(34, 164);
            this.panel_SifreSifirlama.Name = "panel_SifreSifirlama";
            this.panel_SifreSifirlama.Size = new System.Drawing.Size(304, 141);
            this.panel_SifreSifirlama.TabIndex = 19;
            this.panel_SifreSifirlama.Visible = false;
            // 
            // button_Kaydet
            // 
            this.button_Kaydet.Location = new System.Drawing.Point(211, 95);
            this.button_Kaydet.Name = "button_Kaydet";
            this.button_Kaydet.Size = new System.Drawing.Size(80, 38);
            this.button_Kaydet.TabIndex = 20;
            this.button_Kaydet.Text = "Kaydet";
            this.button_Kaydet.UseVisualStyleBackColor = true;
            this.button_Kaydet.Click += new System.EventHandler(this.button_Kaydet_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(83, 59);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(208, 20);
            this.textBox4.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Şifre Tekrar";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 20);
            this.textBox2.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Yeni Şifre";
            // 
            // textBox_Dogrulama
            // 
            this.textBox_Dogrulama.Enabled = false;
            this.textBox_Dogrulama.Location = new System.Drawing.Point(138, 108);
            this.textBox_Dogrulama.Name = "textBox_Dogrulama";
            this.textBox_Dogrulama.Size = new System.Drawing.Size(91, 20);
            this.textBox_Dogrulama.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Doğrulama Kodu";
            // 
            // FormSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 363);
            this.Controls.Add(this.panel_SifreSifirlama);
            this.Controls.Add(this.button_Gonder);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Dogrulama);
            this.Name = "FormSifremiUnuttum";
            this.Text = "FormSifremiUnuttum";
            this.panel_SifreSifirlama.ResumeLayout(false);
            this.panel_SifreSifirlama.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Gonder;
        private System.Windows.Forms.Panel panel_SifreSifirlama;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Dogrulama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Kaydet;
    }
}