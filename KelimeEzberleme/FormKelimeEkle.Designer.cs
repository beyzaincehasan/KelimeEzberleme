
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
            this.textBox_Gorsel_Url = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Turkish = new System.Windows.Forms.TextBox();
            this.textBox_Eng = new System.Windows.Forms.TextBox();
            this.label_Sifre = new System.Windows.Forms.Label();
            this.label_Kelime = new System.Windows.Forms.Label();
            this.button_Kaydet = new System.Windows.Forms.Button();
            this.buttonGorselSec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Gorsel_Url
            // 
            this.textBox_Gorsel_Url.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Gorsel_Url.Location = new System.Drawing.Point(200, 152);
            this.textBox_Gorsel_Url.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Gorsel_Url.Name = "textBox_Gorsel_Url";
            this.textBox_Gorsel_Url.Size = new System.Drawing.Size(183, 28);
            this.textBox_Gorsel_Url.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(40, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Görsel";
            // 
            // textBox_Turkish
            // 
            this.textBox_Turkish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Turkish.Location = new System.Drawing.Point(200, 101);
            this.textBox_Turkish.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Turkish.Name = "textBox_Turkish";
            this.textBox_Turkish.Size = new System.Drawing.Size(183, 28);
            this.textBox_Turkish.TabIndex = 21;
            // 
            // textBox_Eng
            // 
            this.textBox_Eng.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Eng.Location = new System.Drawing.Point(200, 46);
            this.textBox_Eng.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Eng.Name = "textBox_Eng";
            this.textBox_Eng.Size = new System.Drawing.Size(183, 28);
            this.textBox_Eng.TabIndex = 20;
            // 
            // label_Sifre
            // 
            this.label_Sifre.AutoSize = true;
            this.label_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Sifre.Location = new System.Drawing.Point(40, 101);
            this.label_Sifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Sifre.Name = "label_Sifre";
            this.label_Sifre.Size = new System.Drawing.Size(75, 24);
            this.label_Sifre.TabIndex = 19;
            this.label_Sifre.Text = "Türkçe";
            // 
            // label_Kelime
            // 
            this.label_Kelime.AutoSize = true;
            this.label_Kelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Kelime.Location = new System.Drawing.Point(40, 46);
            this.label_Kelime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Kelime.Name = "label_Kelime";
            this.label_Kelime.Size = new System.Drawing.Size(87, 24);
            this.label_Kelime.TabIndex = 18;
            this.label_Kelime.Text = "İngilizce";
            // 
            // button_Kaydet
            // 
            this.button_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Kaydet.Location = new System.Drawing.Point(435, 368);
            this.button_Kaydet.Name = "button_Kaydet";
            this.button_Kaydet.Size = new System.Drawing.Size(110, 66);
            this.button_Kaydet.TabIndex = 24;
            this.button_Kaydet.Text = "Kaydet";
            this.button_Kaydet.UseVisualStyleBackColor = true;
            this.button_Kaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGorselSec
            // 
            this.buttonGorselSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGorselSec.Location = new System.Drawing.Point(403, 145);
            this.buttonGorselSec.Name = "buttonGorselSec";
            this.buttonGorselSec.Size = new System.Drawing.Size(125, 42);
            this.buttonGorselSec.TabIndex = 25;
            this.buttonGorselSec.Text = "Dosya Seç";
            this.buttonGorselSec.UseVisualStyleBackColor = true;
            this.buttonGorselSec.Click += new System.EventHandler(this.buttonGorselSec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(44, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 211);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // FormKelimeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 456);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGorselSec);
            this.Controls.Add(this.button_Kaydet);
            this.Controls.Add(this.textBox_Gorsel_Url);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Turkish);
            this.Controls.Add(this.textBox_Eng);
            this.Controls.Add(this.label_Sifre);
            this.Controls.Add(this.label_Kelime);
            this.Name = "FormKelimeEkle";
            this.Text = "FormKelimeEkle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Gorsel_Url;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Turkish;
        private System.Windows.Forms.TextBox textBox_Eng;
        private System.Windows.Forms.Label label_Sifre;
        private System.Windows.Forms.Label label_Kelime;
        private System.Windows.Forms.Button button_Kaydet;
        private System.Windows.Forms.Button buttonGorselSec;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}