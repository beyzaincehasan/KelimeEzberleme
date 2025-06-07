
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
            this.button_TahminEt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_TahminEt
            // 
            this.button_TahminEt.Location = new System.Drawing.Point(733, 684);
            this.button_TahminEt.Name = "button_TahminEt";
            this.button_TahminEt.Size = new System.Drawing.Size(118, 108);
            this.button_TahminEt.TabIndex = 0;
            this.button_TahminEt.Text = "Tahmin Et";
            this.button_TahminEt.UseVisualStyleBackColor = true;
            this.button_TahminEt.Click += new System.EventHandler(this.button_TahminEt_Click);
            // 
            // FormBulmaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 943);
            this.Controls.Add(this.button_TahminEt);
            this.Name = "FormBulmaca";
            this.Text = "FormBulmaca";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_TahminEt;
    }
}