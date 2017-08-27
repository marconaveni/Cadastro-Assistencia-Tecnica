namespace Cadastro_Assistencia_Tecnica.Views
{
    partial class FrmVisualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisualizar));
            this.PDFView = new AxAcroPDFLib.AxAcroPDF();
            this.ShadowTop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PDFView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShadowTop)).BeginInit();
            this.SuspendLayout();
            // 
            // PDFView
            // 
            this.PDFView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PDFView.Enabled = true;
            this.PDFView.Location = new System.Drawing.Point(12, 73);
            this.PDFView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PDFView.Name = "PDFView";
            this.PDFView.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDFView.OcxState")));
            this.PDFView.Size = new System.Drawing.Size(1176, 744);
            this.PDFView.TabIndex = 3;
            // 
            // ShadowTop
            // 
            this.ShadowTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShadowTop.Image = ((System.Drawing.Image)(resources.GetObject("ShadowTop.Image")));
            this.ShadowTop.Location = new System.Drawing.Point(2, 63);
            this.ShadowTop.Name = "ShadowTop";
            this.ShadowTop.Size = new System.Drawing.Size(1197, 20);
            this.ShadowTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShadowTop.TabIndex = 158;
            this.ShadowTop.TabStop = false;
            // 
            // FrmVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 830);
            this.Controls.Add(this.PDFView);
            this.Controls.Add(this.ShadowTop);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "FrmVisualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Fichas";
            this.Load += new System.EventHandler(this.FrmVisualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PDFView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShadowTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AxAcroPDFLib.AxAcroPDF PDFView;
        private System.Windows.Forms.PictureBox ShadowTop;
    }
}