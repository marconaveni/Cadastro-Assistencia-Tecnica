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
            ((System.ComponentModel.ISupportInitialize)(this.PDFView)).BeginInit();
            this.SuspendLayout();
            // 
            // PDFView
            // 
            this.PDFView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PDFView.Enabled = true;
            this.PDFView.Location = new System.Drawing.Point(11, 73);
            this.PDFView.Name = "PDFView";
            this.PDFView.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDFView.OcxState")));
            this.PDFView.Size = new System.Drawing.Size(1180, 715);
            this.PDFView.TabIndex = 3;
            // 
            // FrmVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.PDFView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FrmVisualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Fichas";
            this.Load += new System.EventHandler(this.FrmVisualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PDFView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AxAcroPDFLib.AxAcroPDF PDFView;
    }
}