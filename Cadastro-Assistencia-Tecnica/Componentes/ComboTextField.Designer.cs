namespace Cadastro_Assistencia_Tecnica.Componentes
{
    partial class ComboTextField
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
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.tm2 = new System.Windows.Forms.Timer(this.components);
            this.Txt = new System.Windows.Forms.ComboBox();
            this.lblTxt = new MaterialSkin.Controls.MaterialLabel();
            this.Ani = new System.Windows.Forms.PictureBox();
            this.line = new System.Windows.Forms.PictureBox();
            this.DWAprovado = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DWAprovado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
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
            // Txt
            // 
            this.Txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Txt.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt.FormattingEnabled = true;
            this.Txt.Location = new System.Drawing.Point(2, 0);
            this.Txt.Margin = new System.Windows.Forms.Padding(4);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(134, 27);
            this.Txt.TabIndex = 186;
            this.Txt.SelectedIndexChanged += new System.EventHandler(this.Txt_SelectedIndexChanged);
            this.Txt.Enter += new System.EventHandler(this.Txt_Enter);
            this.Txt.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.Depth = 0;
            this.lblTxt.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTxt.Location = new System.Drawing.Point(-2, 9);
            this.lblTxt.Margin = new System.Windows.Forms.Padding(0);
            this.lblTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(29, 19);
            this.lblTxt.TabIndex = 189;
            this.lblTxt.Text = "Lbl";
            this.lblTxt.Click += new System.EventHandler(this.DWAprovado_Click);
            this.lblTxt.Enter += new System.EventHandler(this.DWAprovado_Click);
            // 
            // Ani
            // 
            this.Ani.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ani.BackColor = System.Drawing.Color.LightGray;
            this.Ani.Location = new System.Drawing.Point(68, 30);
            this.Ani.Margin = new System.Windows.Forms.Padding(0);
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
            this.line.Location = new System.Drawing.Point(3, 30);
            this.line.Margin = new System.Windows.Forms.Padding(0);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(135, 1);
            this.line.TabIndex = 168;
            this.line.TabStop = false;
            // 
            // DWAprovado
            // 
            this.DWAprovado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DWAprovado.BackColor = System.Drawing.Color.Transparent;
            this.DWAprovado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DWAprovado.Image = global::Cadastro_Assistencia_Tecnica.Properties.Resources.down;
            this.DWAprovado.Location = new System.Drawing.Point(106, 9);
            this.DWAprovado.Margin = new System.Windows.Forms.Padding(0);
            this.DWAprovado.Name = "DWAprovado";
            this.DWAprovado.Size = new System.Drawing.Size(26, 24);
            this.DWAprovado.TabIndex = 188;
            this.DWAprovado.TabStop = false;
            this.DWAprovado.Click += new System.EventHandler(this.DWAprovado_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(0, -6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(136, 34);
            this.pictureBox6.TabIndex = 187;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.DWAprovado_Click);
            // 
            // ComboTextField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Ani);
            this.Controls.Add(this.line);
            this.Controls.Add(this.DWAprovado);
            this.Controls.Add(this.lblTxt);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Txt);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(1920, 30);
            this.MinimumSize = new System.Drawing.Size(135, 40);
            this.Name = "ComboTextField";
            this.Size = new System.Drawing.Size(136, 40);
            this.Load += new System.EventHandler(this.TextField_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DWAprovado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ani;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.Timer tm2;
        private System.Windows.Forms.PictureBox DWAprovado;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ComboBox Txt;
        private MaterialSkin.Controls.MaterialLabel lblTxt;
    }
}
