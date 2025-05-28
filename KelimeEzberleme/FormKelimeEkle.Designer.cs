
namespace KelimeEzberleme
{
    partial class FormKelimeEkle
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
            this.textBox_Sifre_Tekrar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.textBox_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.label_Sifre = new System.Windows.Forms.Label();
            this.label_Kelime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Sifre_Tekrar
            // 
            this.textBox_Sifre_Tekrar.Location = new System.Drawing.Point(201, 197);
            this.textBox_Sifre_Tekrar.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Sifre_Tekrar.Name = "textBox_Sifre_Tekrar";
            this.textBox_Sifre_Tekrar.Size = new System.Drawing.Size(183, 22);
            this.textBox_Sifre_Tekrar.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Görsel";
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Location = new System.Drawing.Point(201, 146);
            this.textBox_Sifre.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.Size = new System.Drawing.Size(183, 22);
            this.textBox_Sifre.TabIndex = 21;
            // 
            // textBox_KullaniciAdi
            // 
            this.textBox_KullaniciAdi.Location = new System.Drawing.Point(201, 91);
            this.textBox_KullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_KullaniciAdi.Name = "textBox_KullaniciAdi";
            this.textBox_KullaniciAdi.Size = new System.Drawing.Size(183, 22);
            this.textBox_KullaniciAdi.TabIndex = 20;
            // 
            // label_Sifre
            // 
            this.label_Sifre.AutoSize = true;
            this.label_Sifre.Location = new System.Drawing.Point(41, 146);
            this.label_Sifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Sifre.Name = "label_Sifre";
            this.label_Sifre.Size = new System.Drawing.Size(52, 17);
            this.label_Sifre.TabIndex = 19;
            this.label_Sifre.Text = "Türkçe";
            // 
            // label_Kelime
            // 
            this.label_Kelime.AutoSize = true;
            this.label_Kelime.Location = new System.Drawing.Point(41, 91);
            this.label_Kelime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Kelime.Name = "label_Kelime";
            this.label_Kelime.Size = new System.Drawing.Size(58, 17);
            this.label_Kelime.TabIndex = 18;
            this.label_Kelime.Text = "İngilizce";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 56);
            this.button1.TabIndex = 24;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(404, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 42);
            this.button2.TabIndex = 25;
            this.button2.Text = "Dosya Seç";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormKelimeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 359);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Sifre_Tekrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Sifre);
            this.Controls.Add(this.textBox_KullaniciAdi);
            this.Controls.Add(this.label_Sifre);
            this.Controls.Add(this.label_Kelime);
            this.Name = "FormKelimeEkle";
            this.Text = "FormKelimeEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Sifre_Tekrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.TextBox textBox_KullaniciAdi;
        private System.Windows.Forms.Label label_Sifre;
        private System.Windows.Forms.Label label_Kelime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}