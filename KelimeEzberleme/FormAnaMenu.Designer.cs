
namespace KelimeEzberleme
{
    partial class FormAnaMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Ayarlar = new System.Windows.Forms.Button();
            this.button_Profil = new System.Windows.Forms.Button();
            this.button_Rapor = new System.Windows.Forms.Button();
            this.button_KelimeEkle = new System.Windows.Forms.Button();
            this.button_KelimeEzberle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Ayarlar);
            this.panel1.Controls.Add(this.button_Profil);
            this.panel1.Controls.Add(this.button_Rapor);
            this.panel1.Controls.Add(this.button_KelimeEkle);
            this.panel1.Controls.Add(this.button_KelimeEzberle);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 962);
            this.panel1.TabIndex = 0;
            // 
            // button_Ayarlar
            // 
            this.button_Ayarlar.BackgroundImage = global::KelimeEzberleme.Properties.Resources.automation_80px;
            this.button_Ayarlar.Location = new System.Drawing.Point(26, 787);
            this.button_Ayarlar.Name = "button_Ayarlar";
            this.button_Ayarlar.Size = new System.Drawing.Size(111, 78);
            this.button_Ayarlar.TabIndex = 4;
            this.button_Ayarlar.Text = "Ayarlar";
            this.button_Ayarlar.UseVisualStyleBackColor = true;
            this.button_Ayarlar.Click += new System.EventHandler(this.button_Ayarlar_Click);
            // 
            // button_Profil
            // 
            this.button_Profil.Location = new System.Drawing.Point(26, 871);
            this.button_Profil.Name = "button_Profil";
            this.button_Profil.Size = new System.Drawing.Size(111, 78);
            this.button_Profil.TabIndex = 3;
            this.button_Profil.Text = "Profil";
            this.button_Profil.UseVisualStyleBackColor = true;
            // 
            // button_Rapor
            // 
            this.button_Rapor.Location = new System.Drawing.Point(14, 193);
            this.button_Rapor.Name = "button_Rapor";
            this.button_Rapor.Size = new System.Drawing.Size(111, 78);
            this.button_Rapor.TabIndex = 2;
            this.button_Rapor.Text = "Rapor";
            this.button_Rapor.UseVisualStyleBackColor = true;
            // 
            // button_KelimeEkle
            // 
            this.button_KelimeEkle.Location = new System.Drawing.Point(14, 100);
            this.button_KelimeEkle.Name = "button_KelimeEkle";
            this.button_KelimeEkle.Size = new System.Drawing.Size(111, 78);
            this.button_KelimeEkle.TabIndex = 1;
            this.button_KelimeEkle.Text = "Kelime Ekle";
            this.button_KelimeEkle.UseVisualStyleBackColor = true;
            this.button_KelimeEkle.Click += new System.EventHandler(this.button_KelimeEkle_Click);
            // 
            // button_KelimeEzberle
            // 
            this.button_KelimeEzberle.Location = new System.Drawing.Point(14, 16);
            this.button_KelimeEzberle.Name = "button_KelimeEzberle";
            this.button_KelimeEzberle.Size = new System.Drawing.Size(111, 78);
            this.button_KelimeEzberle.TabIndex = 0;
            this.button_KelimeEzberle.Text = "Kelime Ezberle";
            this.button_KelimeEzberle.UseVisualStyleBackColor = true;
            this.button_KelimeEzberle.Click += new System.EventHandler(this.button_KelimeEzberle_Click);
            // 
            // FormAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 979);
            this.Controls.Add(this.panel1);
            this.Name = "FormAnaMenu";
            this.Text = "FormAnaMenu";
            this.Load += new System.EventHandler(this.FormAnaMenu_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_KelimeEkle;
        private System.Windows.Forms.Button button_KelimeEzberle;
        private System.Windows.Forms.Button button_Rapor;
        private System.Windows.Forms.Button button_Ayarlar;
        private System.Windows.Forms.Button button_Profil;
    }
}