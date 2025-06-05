
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_KelimeSayisi = new System.Windows.Forms.NumericUpDown();
            this.button_Kaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_KelimeSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Günlük Kelime Sayısı";
            // 
            // numericUpDown_KelimeSayisi
            // 
            this.numericUpDown_KelimeSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown_KelimeSayisi.Location = new System.Drawing.Point(260, 56);
            this.numericUpDown_KelimeSayisi.Name = "numericUpDown_KelimeSayisi";
            this.numericUpDown_KelimeSayisi.ReadOnly = true;
            this.numericUpDown_KelimeSayisi.Size = new System.Drawing.Size(94, 30);
            this.numericUpDown_KelimeSayisi.TabIndex = 20;
            // 
            // button_Kaydet
            // 
            this.button_Kaydet.BackgroundImage = global::KelimeEzberleme.Properties.Resources.save_96px;
            this.button_Kaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Kaydet.Location = new System.Drawing.Point(374, 193);
            this.button_Kaydet.Name = "button_Kaydet";
            this.button_Kaydet.Size = new System.Drawing.Size(75, 65);
            this.button_Kaydet.TabIndex = 20;
            this.button_Kaydet.UseVisualStyleBackColor = true;
            this.button_Kaydet.Click += new System.EventHandler(this.button_Kaydet_Click);
            // 
            // FormAyarlar
            // 
            this.AcceptButton = this.button_Kaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 288);
            this.Controls.Add(this.button_Kaydet);
            this.Controls.Add(this.numericUpDown_KelimeSayisi);
            this.Controls.Add(this.label3);
            this.Name = "FormAyarlar";
            this.Text = "FormAyarlar";
            this.Load += new System.EventHandler(this.FormAyarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_KelimeSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_KelimeSayisi;
        private System.Windows.Forms.Button button_Kaydet;
    }
}