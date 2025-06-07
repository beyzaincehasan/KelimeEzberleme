
namespace KelimeEzberleme
{
    partial class FormAyarlar
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

        private void InitializeComponent()
        {
            this.panelAyar = new System.Windows.Forms.Panel();
            this.labelBaslik = new System.Windows.Forms.Label();
            this.labelKelimeSayisi = new System.Windows.Forms.Label();
            this.numericUpDown_KelimeSayisi = new System.Windows.Forms.NumericUpDown();
            this.button_Kaydet = new System.Windows.Forms.Button();
            this.panelAyar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_KelimeSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAyar
            // 
            this.panelAyar.BackColor = System.Drawing.Color.White;
            this.panelAyar.Controls.Add(this.labelBaslik);
            this.panelAyar.Controls.Add(this.labelKelimeSayisi);
            this.panelAyar.Controls.Add(this.numericUpDown_KelimeSayisi);
            this.panelAyar.Controls.Add(this.button_Kaydet);
            this.panelAyar.Location = new System.Drawing.Point(-6, -4);
            this.panelAyar.Name = "panelAyar";
            this.panelAyar.Size = new System.Drawing.Size(550, 327);
            this.panelAyar.TabIndex = 0;
            // 
            // labelBaslik
            // 
            this.labelBaslik.AutoSize = true;
            this.labelBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelBaslik.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelBaslik.Location = new System.Drawing.Point(87, 43);
            this.labelBaslik.Name = "labelBaslik";
            this.labelBaslik.Size = new System.Drawing.Size(362, 37);
            this.labelBaslik.TabIndex = 0;
            this.labelBaslik.Text = "Günlük Hedef Kelime Ayarı";
            this.labelBaslik.Click += new System.EventHandler(this.labelBaslik_Click);
            // 
            // labelKelimeSayisi
            // 
            this.labelKelimeSayisi.AutoSize = true;
            this.labelKelimeSayisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelKelimeSayisi.ForeColor = System.Drawing.Color.DimGray;
            this.labelKelimeSayisi.Location = new System.Drawing.Point(89, 134);
            this.labelKelimeSayisi.Name = "labelKelimeSayisi";
            this.labelKelimeSayisi.Size = new System.Drawing.Size(210, 28);
            this.labelKelimeSayisi.TabIndex = 1;
            this.labelKelimeSayisi.Text = "Günlük Kelime Sayısı";
            // 
            // numericUpDown_KelimeSayisi
            // 
            this.numericUpDown_KelimeSayisi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numericUpDown_KelimeSayisi.Location = new System.Drawing.Point(338, 128);
            this.numericUpDown_KelimeSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_KelimeSayisi.Name = "numericUpDown_KelimeSayisi";
            this.numericUpDown_KelimeSayisi.Size = new System.Drawing.Size(70, 34);
            this.numericUpDown_KelimeSayisi.TabIndex = 2;
            this.numericUpDown_KelimeSayisi.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button_Kaydet
            // 
            this.button_Kaydet.BackColor = System.Drawing.Color.SeaGreen;
            this.button_Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Kaydet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button_Kaydet.ForeColor = System.Drawing.Color.White;
            this.button_Kaydet.Location = new System.Drawing.Point(319, 213);
            this.button_Kaydet.Name = "button_Kaydet";
            this.button_Kaydet.Size = new System.Drawing.Size(120, 40);
            this.button_Kaydet.TabIndex = 3;
            this.button_Kaydet.Text = "Kaydet";
            this.button_Kaydet.UseVisualStyleBackColor = false;
            this.button_Kaydet.Click += new System.EventHandler(this.button_Kaydet_Click);
            // 
            // FormAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(540, 319);
            this.Controls.Add(this.panelAyar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAyarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.FormAyarlar_Load);
            this.panelAyar.ResumeLayout(false);
            this.panelAyar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_KelimeSayisi)).EndInit();
            this.ResumeLayout(false);

        }

         #endregion

        private System.Windows.Forms.Panel panelAyar;
        private System.Windows.Forms.Label labelBaslik;
        private System.Windows.Forms.Label labelKelimeSayisi;
        private System.Windows.Forms.NumericUpDown numericUpDown_KelimeSayisi;
        private System.Windows.Forms.Button button_Kaydet;
    }
}
   