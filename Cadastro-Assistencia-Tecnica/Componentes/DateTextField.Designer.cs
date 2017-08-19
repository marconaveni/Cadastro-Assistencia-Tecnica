namespace Cadastro_Assistencia_Tecnica.Componentes
{
    partial class DateTextField
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
            this.Txt = new System.Windows.Forms.DateTimePicker();
            this.Ani = new System.Windows.Forms.PictureBox();
            this.line = new System.Windows.Forms.PictureBox();
            this.TDEntrada = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TDEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // Txt
            // 
            this.Txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Txt.Location = new System.Drawing.Point(1, -1);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(118, 26);
            this.Txt.TabIndex = 191;
            this.Txt.Enter += new System.EventHandler(this.Txt_Enter);
            this.Txt.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // Ani
            // 
            this.Ani.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ani.BackColor = System.Drawing.Color.LightGray;
            this.Ani.Location = new System.Drawing.Point(60, 25);
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
            this.line.Location = new System.Drawing.Point(1, 25);
            this.line.Margin = new System.Windows.Forms.Padding(1);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(117, 1);
            this.line.TabIndex = 168;
            this.line.TabStop = false;
            // 
            // TDEntrada
            // 
            this.TDEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TDEntrada.BackColor = System.Drawing.Color.Transparent;
            this.TDEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TDEntrada.Image = global::Cadastro_Assistencia_Tecnica.Properties.Resources.calendar;
            this.TDEntrada.Location = new System.Drawing.Point(89, 1);
            this.TDEntrada.Name = "TDEntrada";
            this.TDEntrada.Size = new System.Drawing.Size(26, 24);
            this.TDEntrada.TabIndex = 190;
            this.TDEntrada.TabStop = false;
            this.TDEntrada.Click += new System.EventHandler(this.TDEntrada_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(-6, -5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 28);
            this.pictureBox4.TabIndex = 189;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(86, -6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 28);
            this.pictureBox3.TabIndex = 188;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(4, -9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 10);
            this.pictureBox2.TabIndex = 187;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(1, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 11);
            this.pictureBox1.TabIndex = 186;
            this.pictureBox1.TabStop = false;
            // 
            // DateTextField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Ani);
            this.Controls.Add(this.line);
            this.Controls.Add(this.TDEntrada);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Txt);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(1920, 30);
            this.MinimumSize = new System.Drawing.Size(112, 30);
            this.Name = "DateTextField";
            this.Size = new System.Drawing.Size(119, 30);
            this.Load += new System.EventHandler(this.TextField_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TDEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Ani;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.Timer tm2;
        private System.Windows.Forms.PictureBox TDEntrada;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker Txt;
    }
}
