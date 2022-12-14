namespace Cadastro_Assistencia_Tecnica.Componentes
{
    partial class RaisedButtonRipple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaisedButtonRipple));
            this.Btn = new MaterialSkin.Controls.MaterialFlatButton();
            this.ShadowLeft = new System.Windows.Forms.PictureBox();
            this.ShadowRight = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.ShadowTop = new System.Windows.Forms.PictureBox();
            this.ShadowBottom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShadowLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShadowRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShadowTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShadowBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn
            // 
            this.Btn.AutoSize = true;
            this.Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn.Depth = 0;
            this.Btn.Icon = null;
            this.Btn.Location = new System.Drawing.Point(9, 6);
            this.Btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn.MaximumSize = new System.Drawing.Size(109, 36);
            this.Btn.MinimumSize = new System.Drawing.Size(109, 36);
            this.Btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn.Name = "Btn";
            this.Btn.Primary = false;
            this.Btn.Size = new System.Drawing.Size(109, 36);
            this.Btn.TabIndex = 181;
            this.Btn.Text = "RaisedButtonRipple";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.MouseEnter += new System.EventHandler(this.RaisedButtonRipple_Enter);
            this.Btn.MouseLeave += new System.EventHandler(this.RaisedButtonRipple_Leave);
            // 
            // ShadowLeft
            // 
            this.ShadowLeft.Image = ((System.Drawing.Image)(resources.GetObject("ShadowLeft.Image")));
            this.ShadowLeft.Location = new System.Drawing.Point(-9, 6);
            this.ShadowLeft.Name = "ShadowLeft";
            this.ShadowLeft.Size = new System.Drawing.Size(19, 36);
            this.ShadowLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShadowLeft.TabIndex = 184;
            this.ShadowLeft.TabStop = false;
            // 
            // ShadowRight
            // 
            this.ShadowRight.Image = ((System.Drawing.Image)(resources.GetObject("ShadowRight.Image")));
            this.ShadowRight.Location = new System.Drawing.Point(117, 6);
            this.ShadowRight.Name = "ShadowRight";
            this.ShadowRight.Size = new System.Drawing.Size(20, 36);
            this.ShadowRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShadowRight.TabIndex = 185;
            this.ShadowRight.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(122, 10);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(21, 36);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 182;
            this.pictureBox20.TabStop = false;
            // 
            // ShadowTop
            // 
            this.ShadowTop.Image = ((System.Drawing.Image)(resources.GetObject("ShadowTop.Image")));
            this.ShadowTop.Location = new System.Drawing.Point(9, -30);
            this.ShadowTop.Name = "ShadowTop";
            this.ShadowTop.Size = new System.Drawing.Size(109, 39);
            this.ShadowTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShadowTop.TabIndex = 186;
            this.ShadowTop.TabStop = false;
            // 
            // ShadowBottom
            // 
            this.ShadowBottom.Image = ((System.Drawing.Image)(resources.GetObject("ShadowBottom.Image")));
            this.ShadowBottom.Location = new System.Drawing.Point(9, 42);
            this.ShadowBottom.Name = "ShadowBottom";
            this.ShadowBottom.Size = new System.Drawing.Size(109, 31);
            this.ShadowBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShadowBottom.TabIndex = 183;
            this.ShadowBottom.TabStop = false;
            // 
            // RaisedButtonRipple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.ShadowLeft);
            this.Controls.Add(this.ShadowRight);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.ShadowTop);
            this.Controls.Add(this.ShadowBottom);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(118, 46);
            this.MinimumSize = new System.Drawing.Size(125, 50);
            this.Name = "RaisedButtonRipple";
            this.Size = new System.Drawing.Size(125, 50);
            this.Load += new System.EventHandler(this.TextField_Load);
            this.Enter += new System.EventHandler(this.RaisedButtonRipple_Enter);
            this.Leave += new System.EventHandler(this.RaisedButtonRipple_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.ShadowLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShadowRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShadowTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShadowBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton Btn;
        private System.Windows.Forms.PictureBox ShadowLeft;
        private System.Windows.Forms.PictureBox ShadowRight;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox ShadowTop;
        private System.Windows.Forms.PictureBox ShadowBottom;
    }
}
