namespace Cadastro_Assistencia_Tecnica.Componentes
{
    partial class TextField
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
            this.LblText = new MaterialSkin.Controls.MaterialLabel();
            this.Background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
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
            this.Txt.Location = new System.Drawing.Point(0, 2);
            this.Txt.Margin = new System.Windows.Forms.Padding(1);
            this.Txt.MaxLength = 255;
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(135, 19);
            this.Txt.TabIndex = 167;
            this.Txt.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            this.Txt.Enter += new System.EventHandler(this.Txt_Enter);
            this.Txt.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // tm
            // 
            this.tm.Interval = 1;
            this.tm.Tick += new System.EventHandler(this.Tm_Tick);
            // 
            // tm2
            // 
            this.tm2.Interval = 1;
            this.tm2.Tick += new System.EventHandler(this.Tm2_Tick);
            // 
            // Ani
            // 
            this.Ani.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ani.BackColor = System.Drawing.Color.LightGray;
            this.Ani.Location = new System.Drawing.Point(68, 23);
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
            this.line.BackColor = System.Drawing.Color.Gainsboro;
            this.line.Location = new System.Drawing.Point(1, 23);
            this.line.Margin = new System.Windows.Forms.Padding(1);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(133, 1);
            this.line.TabIndex = 168;
            this.line.TabStop = false;
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Depth = 0;
            this.LblText.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblText.Location = new System.Drawing.Point(-3, 2);
            this.LblText.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(0, 19);
            this.LblText.TabIndex = 170;
            // 
            // Background
            // 
            this.Background.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Background.Location = new System.Drawing.Point(0, -3);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(135, 26);
            this.Background.TabIndex = 171;
            this.Background.TabStop = false;
            this.Background.Visible = false;
            // 
            // TextField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.Background);
            this.Controls.Add(this.Ani);
            this.Controls.Add(this.line);
            this.Controls.Add(this.Txt);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(1920, 30);
            this.MinimumSize = new System.Drawing.Size(135, 30);
            this.Name = "TextField";
            this.Size = new System.Drawing.Size(135, 30);
            this.Load += new System.EventHandler(this.TextField_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ani;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.TextBox Txt;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.Timer tm2;
        private MaterialSkin.Controls.MaterialLabel LblText;
        private System.Windows.Forms.PictureBox Background;
    }
}
