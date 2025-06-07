
namespace KelimeEzberleme
{
    partial class FormRapor
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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_Rapor = new System.Windows.Forms.DataGridView();
            this.SubjectAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamCevap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogruSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YanlisSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rapor)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridView_Rapor
            // 
            this.dataGridView_Rapor.AllowUserToAddRows = false;
            this.dataGridView_Rapor.AllowUserToDeleteRows = false;
            this.dataGridView_Rapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Rapor.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Rapor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Rapor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            // HEADER STYLING
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerStyle.BackColor = System.Drawing.Color.SeaGreen;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.SelectionBackColor = System.Drawing.Color.DarkGreen;
            headerStyle.SelectionForeColor = System.Drawing.Color.White;
            headerStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Rapor.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dataGridView_Rapor.ColumnHeadersHeight = 45;
            this.dataGridView_Rapor.EnableHeadersVisualStyles = false;

            // ROW STYLING
            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            rowStyle.ForeColor = System.Drawing.Color.Black;
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 235, 220);
            rowStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_Rapor.DefaultCellStyle = rowStyle;
            this.dataGridView_Rapor.RowTemplate.Height = 32;

            this.dataGridView_Rapor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.SubjectAciklama,
                this.ToplamCevap,
                this.DogruSayisi,
                this.YanlisSayisi});
            this.dataGridView_Rapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Rapor.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Rapor.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Rapor.Name = "dataGridView_Rapor";
            this.dataGridView_Rapor.ReadOnly = true;
            this.dataGridView_Rapor.RowHeadersVisible = false;
            this.dataGridView_Rapor.Size = new System.Drawing.Size(1187, 861);
            this.dataGridView_Rapor.TabIndex = 0;

            // 
            // SubjectAciklama
            // 
            this.SubjectAciklama.HeaderText = "Konular";
            this.SubjectAciklama.MinimumWidth = 6;
            this.SubjectAciklama.Name = "SubjectAciklama";
            this.SubjectAciklama.ReadOnly = true;

            // 
            // ToplamCevap
            // 
            this.ToplamCevap.HeaderText = "Toplam Cevap";
            this.ToplamCevap.MinimumWidth = 6;
            this.ToplamCevap.Name = "ToplamCevap";
            this.ToplamCevap.ReadOnly = true;

            // 
            // DogruSayisi
            // 
            this.DogruSayisi.HeaderText = "Doğru Cevap";
            this.DogruSayisi.MinimumWidth = 6;
            this.DogruSayisi.Name = "DogruSayisi";
            this.DogruSayisi.ReadOnly = true;

            // 
            // YanlisSayisi
            // 
            this.YanlisSayisi.HeaderText = "Yanlış Cevap";
            this.YanlisSayisi.MinimumWidth = 6;
            this.YanlisSayisi.Name = "YanlisSayisi";
            this.YanlisSayisi.ReadOnly = true;

            // 
            // FormRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            this.ClientSize = new System.Drawing.Size(1187, 861);
            this.Controls.Add(this.dataGridView_Rapor);
            this.Name = "FormRapor";
            this.Text = "İstatistik Raporu";
            this.Load += new System.EventHandler(this.FormRapor_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rapor)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Rapor;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamCevap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogruSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YanlisSayisi;
    }
}