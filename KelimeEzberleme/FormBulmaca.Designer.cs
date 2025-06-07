
namespace KelimeEzberleme
{
    partial class FormBulmaca
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
            this.panelKutu = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.btnTahminEt = new System.Windows.Forms.Button();
            this.lblKalanHak = new System.Windows.Forms.Label();
            this.lblIpucu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelKutu
            // 
            this.panelKutu.AutoScroll = true;
            this.panelKutu.Location = new System.Drawing.Point(41, 129);
            this.panelKutu.Name = "panelKutu";
            this.panelKutu.Size = new System.Drawing.Size(411, 256);
            this.panelKutu.TabIndex = 0;
            // 
            // txtTahmin
            // 
            this.txtTahmin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtTahmin.Location = new System.Drawing.Point(37, 479);
            this.txtTahmin.MaxLength = 1;
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(137, 39);
            this.txtTahmin.TabIndex = 1;
            // 
            // btnTahminEt
            // 
            this.btnTahminEt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTahminEt.Location = new System.Drawing.Point(192, 479);
            this.btnTahminEt.Name = "btnTahminEt";
            this.btnTahminEt.Size = new System.Drawing.Size(137, 36);
            this.btnTahminEt.TabIndex = 2;
            this.btnTahminEt.Text = "Tahmin Et";
            this.btnTahminEt.UseVisualStyleBackColor = true;
            this.btnTahminEt.Click += new System.EventHandler(this.btnTahminEt_Click);
            // 
            // lblKalanHak
            // 
            this.lblKalanHak.AutoSize = true;
            this.lblKalanHak.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKalanHak.Location = new System.Drawing.Point(37, 11);
            this.lblKalanHak.Name = "lblKalanHak";
            this.lblKalanHak.Size = new System.Drawing.Size(97, 23);
            this.lblKalanHak.TabIndex = 3;
            this.lblKalanHak.Text = "Kalan Hak:";
            // 
            // lblIpucu
            // 
            this.lblIpucu.AutoSize = true;
            this.lblIpucu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblIpucu.Location = new System.Drawing.Point(297, 9);
            this.lblIpucu.Name = "lblIpucu";
            this.lblIpucu.Size = new System.Drawing.Size(0, 32);
            this.lblIpucu.TabIndex = 4;
            // 
            // FormBulmaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 600);
            this.Controls.Add(this.lblIpucu);
            this.Controls.Add(this.lblKalanHak);
            this.Controls.Add(this.btnTahminEt);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.panelKutu);
            this.Name = "FormBulmaca";
            this.Text = "Bulmaca";
            this.Load += new System.EventHandler(this.FormBulmaca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelKutu;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button btnTahminEt;
        private System.Windows.Forms.Label lblKalanHak;
        private System.Windows.Forms.Label lblIpucu;
    }
}