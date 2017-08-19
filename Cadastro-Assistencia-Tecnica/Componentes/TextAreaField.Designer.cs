namespace Cadastro_Assistencia_Tecnica.Componentes
{
    partial class TextAreaField
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Txt = new System.Windows.Forms.TextBox();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.tm2 = new System.Windows.Forms.Timer(this.components);
            this.Ani = new System.Windows.Forms.PictureBox();
            this.line = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt
            // 
            this.Txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Txt.Location = new System.Drawing.Point(0, 3);
            this.Txt.Margin = new System.Windows.Forms.Padding(1);
            this.Txt.MaxLength = 188;
            this.Txt.Multiline = true;
            this.Txt.Name = "Txt";
            this.Txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt.Size = new System.Drawing.Size(282, 104);
            this.Txt.TabIndex = 167;
            this.Txt.Enter += new System.EventHandler(this.Txt_Enter);
            this.Txt.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // tm
            // 
            this.tm.Interval = 1;
            this.tm.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // tm2
            // 
            this.tm2.Interval = 1;
            this.tm2.Tick += new System.EventHandler(this.tm2_Tick);
            // 
            // Ani
            // 
            this.Ani.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ani.BackColor = System.Drawing.Color.LightGray;
            this.Ani.Location = new System.Drawing.Point(142, 110);
            this.Ani.Margin = new System.Windows.Forms.Padding(1);
            this.Ani.Name = "Ani";
            this.Ani.Size = new System.Drawing.Size(2, 3);
            this.Ani.TabIndex = 169;
            this.Ani.TabStop = false;
            // 
            // line
            // 
            this.line.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line.BackColor = System.Drawing.Color.LightGray;
            this.line.Location = new System.Drawing.Point(1, 110);
            this.line.Margin = new System.Windows.Forms.Padding(1);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(281, 1);
            this.line.TabIndex = 168;
            this.line.TabStop = false;
            // 
            // TextAreaField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Ani);
            this.Controls.Add(this.line);
            this.Controls.Add(this.Txt);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(1920, 117);
            this.MinimumSize = new System.Drawing.Size(283, 117);
            this.Name = "TextAreaField";
            this.Size = new System.Drawing.Size(283, 117);
            this.Load += new System.EventHandler(this.TextField_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ani;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.TextBox Txt;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.Timer tm2;
    }
}
