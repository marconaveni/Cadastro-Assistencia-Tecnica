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
            this.RchPrint = new System.Windows.Forms.RichTextBox();
            this.BtnVisuImprim = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printFicha = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // RchPrint
            // 
            this.RchPrint.Location = new System.Drawing.Point(13, 25);
            this.RchPrint.Margin = new System.Windows.Forms.Padding(4);
            this.RchPrint.Name = "RchPrint";
            this.RchPrint.Size = new System.Drawing.Size(751, 334);
            this.RchPrint.TabIndex = 0;
            this.RchPrint.Text = "";
            this.RchPrint.Click += new System.EventHandler(this.RchPrint_Click);
            // 
            // BtnVisuImprim
            // 
            this.BtnVisuImprim.Image = ((System.Drawing.Image)(resources.GetObject("BtnVisuImprim.Image")));
            this.BtnVisuImprim.Location = new System.Drawing.Point(461, 374);
            this.BtnVisuImprim.Name = "BtnVisuImprim";
            this.BtnVisuImprim.Size = new System.Drawing.Size(136, 40);
            this.BtnVisuImprim.TabIndex = 1;
            this.BtnVisuImprim.Text = "Visualizar Impressão";
            this.BtnVisuImprim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVisuImprim.UseVisualStyleBackColor = true;
            this.BtnVisuImprim.Click += new System.EventHandler(this.BtnVisuImprim_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("BtnImprimir.Image")));
            this.BtnImprimir.Location = new System.Drawing.Point(623, 374);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(136, 40);
            this.BtnImprimir.TabIndex = 2;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.ShowIcon = false;
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.PrintPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printFicha
            // 
            this.printFicha.UseEXDialog = true;
            // 
            // FrmVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 426);
            this.Controls.Add(this.BtnVisuImprim);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.RchPrint);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmVisualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Fichas";
            this.Load += new System.EventHandler(this.FrmVisualizar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RchPrint;
        private System.Windows.Forms.Button BtnVisuImprim;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printFicha;
    }
}