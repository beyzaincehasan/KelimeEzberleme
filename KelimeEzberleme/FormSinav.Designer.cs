namespace KelimeEzberleme
{
    partial class FormSinav
    {
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
            this.label_kelime = new System.Windows.Forms.Label();
            this.panelSecenekler = new System.Windows.Forms.Panel();
            this.radioButton_Sec1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Sec2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Sec3 = new System.Windows.Forms.RadioButton();
            this.radioButton_Sec4 = new System.Windows.Forms.RadioButton();
            this.button_Control = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_ileri = new System.Windows.Forms.Button();
            this.label_OrnekCumle = new System.Windows.Forms.Label();
            this.panelSayac = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_GunlukKelimeSayisi = new System.Windows.Forms.Label();
            this.label_CalisilanKelimeSayisi = new System.Windows.Forms.Label();
            this.label_KalanKelimeSayisi = new System.Windows.Forms.Label();
            this.panelSecenekler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSayac.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_kelime
            // 
            this.label_kelime.AutoSize = true;
            this.label_kelime.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label_kelime.ForeColor = System.Drawing.Color.SeaGreen;
            this.label_kelime.Location = new System.Drawing.Point(382, 9);
            this.label_kelime.Name = "label_kelime";
            this.label_kelime.Size = new System.Drawing.Size(152, 54);
            this.label_kelime.TabIndex = 3;
            this.label_kelime.Text = "Kelime";
            // 
            // panelSecenekler
            // 
            this.panelSecenekler.BackColor = System.Drawing.Color.White;
            this.panelSecenekler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSecenekler.Controls.Add(this.radioButton_Sec1);
            this.panelSecenekler.Controls.Add(this.radioButton_Sec2);
            this.panelSecenekler.Controls.Add(this.radioButton_Sec3);
            this.panelSecenekler.Controls.Add(this.radioButton_Sec4);
            this.panelSecenekler.Location = new System.Drawing.Point(244, 89);
            this.panelSecenekler.Name = "panelSecenekler";
            this.panelSecenekler.Size = new System.Drawing.Size(430, 420);
            this.panelSecenekler.TabIndex = 4;
            // 
            // radioButton_Sec1
            // 
            this.radioButton_Sec1.AutoSize = true;
            this.radioButton_Sec1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.radioButton_Sec1.Location = new System.Drawing.Point(40, 50);
            this.radioButton_Sec1.Name = "radioButton_Sec1";
            this.radioButton_Sec1.Size = new System.Drawing.Size(17, 16);
            this.radioButton_Sec1.TabIndex = 100;
            this.radioButton_Sec1.UseVisualStyleBackColor = true;
            this.radioButton_Sec1.CheckedChanged += new System.EventHandler(this.radioButton_Sec1_CheckedChanged);
            // 
            // radioButton_Sec2
            // 
            this.radioButton_Sec2.AutoSize = true;
            this.radioButton_Sec2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.radioButton_Sec2.Location = new System.Drawing.Point(40, 140);
            this.radioButton_Sec2.Name = "radioButton_Sec2";
            this.radioButton_Sec2.Size = new System.Drawing.Size(17, 16);
            this.radioButton_Sec2.TabIndex = 101;
            this.radioButton_Sec2.UseVisualStyleBackColor = true;
            this.radioButton_Sec2.CheckedChanged += new System.EventHandler(this.radioButton_Sec2_CheckedChanged);
            // 
            // radioButton_Sec3
            // 
            this.radioButton_Sec3.AutoSize = true;
            this.radioButton_Sec3.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.radioButton_Sec3.Location = new System.Drawing.Point(40, 230);
            this.radioButton_Sec3.Name = "radioButton_Sec3";
            this.radioButton_Sec3.Size = new System.Drawing.Size(17, 16);
            this.radioButton_Sec3.TabIndex = 102;
            this.radioButton_Sec3.UseVisualStyleBackColor = true;
            this.radioButton_Sec3.CheckedChanged += new System.EventHandler(this.radioButton_Sec3_CheckedChanged);
            // 
            // radioButton_Sec4
            // 
            this.radioButton_Sec4.AutoSize = true;
            this.radioButton_Sec4.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.radioButton_Sec4.Location = new System.Drawing.Point(40, 320);
            this.radioButton_Sec4.Name = "radioButton_Sec4";
            this.radioButton_Sec4.Size = new System.Drawing.Size(17, 16);
            this.radioButton_Sec4.TabIndex = 103;
            this.radioButton_Sec4.UseVisualStyleBackColor = true;
            this.radioButton_Sec4.CheckedChanged += new System.EventHandler(this.radioButton_Sec4_CheckedChanged);
            // 
            // button_Control
            // 
            this.button_Control.BackColor = System.Drawing.Color.SeaGreen;
            this.button_Control.BackgroundImage = global::KelimeEzberleme.Properties.Resources.Checkmark_80px;
            this.button_Control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Control.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Control.Location = new System.Drawing.Point(680, 429);
            this.button_Control.Name = "button_Control";
            this.button_Control.Size = new System.Drawing.Size(92, 80);
            this.button_Control.TabIndex = 5;
            this.button_Control.UseVisualStyleBackColor = false;
            this.button_Control.Click += new System.EventHandler(this.button_Control_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(784, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button_ileri
            // 
            this.button_ileri.BackColor = System.Drawing.Color.SeaGreen;
            this.button_ileri.BackgroundImage = global::KelimeEzberleme.Properties.Resources.right_96px;
            this.button_ileri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ileri.Location = new System.Drawing.Point(962, 640);
            this.button_ileri.Name = "button_ileri";
            this.button_ileri.Size = new System.Drawing.Size(110, 70);
            this.button_ileri.TabIndex = 0;
            this.button_ileri.UseVisualStyleBackColor = false;
            this.button_ileri.Click += new System.EventHandler(this.button_ileri_Click);
            // 
            // label_OrnekCumle
            // 
            this.label_OrnekCumle.AutoSize = true;
            this.label_OrnekCumle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label_OrnekCumle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label_OrnekCumle.Location = new System.Drawing.Point(82, 530);
            this.label_OrnekCumle.Name = "label_OrnekCumle";
            this.label_OrnekCumle.Size = new System.Drawing.Size(182, 37);
            this.label_OrnekCumle.TabIndex = 13;
            this.label_OrnekCumle.Text = "Örnek Cümle";
            this.label_OrnekCumle.Visible = false;
            // 
            // panelSayac
            // 
            this.panelSayac.BackColor = System.Drawing.Color.White;
            this.panelSayac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSayac.Controls.Add(this.label6);
            this.panelSayac.Controls.Add(this.label1);
            this.panelSayac.Controls.Add(this.label3);
            this.panelSayac.Controls.Add(this.label5);
            this.panelSayac.Controls.Add(this.label_GunlukKelimeSayisi);
            this.panelSayac.Controls.Add(this.label_CalisilanKelimeSayisi);
            this.panelSayac.Controls.Add(this.label_KalanKelimeSayisi);
            this.panelSayac.Location = new System.Drawing.Point(271, 605);
            this.panelSayac.Name = "panelSayac";
            this.panelSayac.Size = new System.Drawing.Size(492, 121);
            this.panelSayac.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(27, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bugün";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kelime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(178, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Çalışılan:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(341, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kalan:";
            // 
            // label_GunlukKelimeSayisi
            // 
            this.label_GunlukKelimeSayisi.AutoSize = true;
            this.label_GunlukKelimeSayisi.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label_GunlukKelimeSayisi.Location = new System.Drawing.Point(113, 65);
            this.label_GunlukKelimeSayisi.Name = "label_GunlukKelimeSayisi";
            this.label_GunlukKelimeSayisi.Size = new System.Drawing.Size(22, 30);
            this.label_GunlukKelimeSayisi.TabIndex = 4;
            this.label_GunlukKelimeSayisi.Text = "-";
            // 
            // label_CalisilanKelimeSayisi
            // 
            this.label_CalisilanKelimeSayisi.AutoSize = true;
            this.label_CalisilanKelimeSayisi.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label_CalisilanKelimeSayisi.Location = new System.Drawing.Point(288, 65);
            this.label_CalisilanKelimeSayisi.Name = "label_CalisilanKelimeSayisi";
            this.label_CalisilanKelimeSayisi.Size = new System.Drawing.Size(22, 30);
            this.label_CalisilanKelimeSayisi.TabIndex = 5;
            this.label_CalisilanKelimeSayisi.Text = "-";
            // 
            // label_KalanKelimeSayisi
            // 
            this.label_KalanKelimeSayisi.AutoSize = true;
            this.label_KalanKelimeSayisi.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label_KalanKelimeSayisi.Location = new System.Drawing.Point(423, 65);
            this.label_KalanKelimeSayisi.Name = "label_KalanKelimeSayisi";
            this.label_KalanKelimeSayisi.Size = new System.Drawing.Size(22, 30);
            this.label_KalanKelimeSayisi.TabIndex = 6;
            this.label_KalanKelimeSayisi.Text = "-";
            // 
            // FormSinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1162, 763);
            this.Controls.Add(this.label_kelime);
            this.Controls.Add(this.panelSecenekler);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Control);
            this.Controls.Add(this.button_ileri);
            this.Controls.Add(this.label_OrnekCumle);
            this.Controls.Add(this.panelSayac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSinav";
            this.Text = "Kelime Testi";
            this.Load += new System.EventHandler(this.FormSinav_Load);
            this.panelSecenekler.ResumeLayout(false);
            this.panelSecenekler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSayac.ResumeLayout(false);
            this.panelSayac.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_kelime;
        private System.Windows.Forms.Panel panelSecenekler;
        private System.Windows.Forms.RadioButton radioButton_Sec1;
        private System.Windows.Forms.RadioButton radioButton_Sec2;
        private System.Windows.Forms.RadioButton radioButton_Sec3;
        private System.Windows.Forms.RadioButton radioButton_Sec4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Control;
        private System.Windows.Forms.Button button_ileri;
        private System.Windows.Forms.Label label_OrnekCumle;
        private System.Windows.Forms.Panel panelSayac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_GunlukKelimeSayisi;
        private System.Windows.Forms.Label label_CalisilanKelimeSayisi;
        private System.Windows.Forms.Label label_KalanKelimeSayisi;
    }
}
