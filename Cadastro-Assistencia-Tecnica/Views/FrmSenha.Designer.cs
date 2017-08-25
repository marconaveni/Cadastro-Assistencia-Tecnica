namespace Cadastro_Assistencia_Tecnica.Views
{
    partial class FrmSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSenha));
            this.Lblsenha = new MaterialSkin.Controls.MaterialLabel();
            this.TxtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MenuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.linhaDivisora = new MaterialSkin.Controls.MaterialDivider();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.BtnCancelar = new Cadastro_Assistencia_Tecnica.Componentes.ColoredButton();
            this.BtnOk = new Cadastro_Assistencia_Tecnica.Componentes.ColoredButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // Lblsenha
            // 
            this.Lblsenha.AutoSize = true;
            this.Lblsenha.Depth = 0;
            this.Lblsenha.Font = new System.Drawing.Font("Roboto", 11F);
            this.Lblsenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lblsenha.Location = new System.Drawing.Point(49, 125);
            this.Lblsenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lblsenha.Name = "Lblsenha";
            this.Lblsenha.Size = new System.Drawing.Size(104, 19);
            this.Lblsenha.TabIndex = 3;
            this.Lblsenha.Text = "Digite a senha";
            // 
            // TxtSenha
            // 
            this.TxtSenha.AllowDrop = true;
            this.TxtSenha.ContextMenuStrip = this.MenuStrip;
            this.TxtSenha.Depth = 0;
            this.TxtSenha.Hint = "";
            this.TxtSenha.Location = new System.Drawing.Point(171, 125);
            this.TxtSenha.MaxLength = 16;
            this.TxtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '•';
            this.TxtSenha.SelectedText = "";
            this.TxtSenha.SelectionLength = 0;
            this.TxtSenha.SelectionStart = 0;
            this.TxtSenha.Size = new System.Drawing.Size(235, 23);
            this.TxtSenha.TabIndex = 4;
            this.TxtSenha.TabStop = false;
            this.TxtSenha.UseSystemPasswordChar = false;
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MenuStrip.Depth = 0;
            this.MenuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // linhaDivisora
            // 
            this.linhaDivisora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linhaDivisora.Depth = 0;
            this.linhaDivisora.Location = new System.Drawing.Point(-10, 189);
            this.linhaDivisora.MouseState = MaterialSkin.MouseState.HOVER;
            this.linhaDivisora.Name = "linhaDivisora";
            this.linhaDivisora.Size = new System.Drawing.Size(524, 1);
            this.linhaDivisora.TabIndex = 42;
            this.linhaDivisora.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1, 63);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(464, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 156;
            this.pictureBox5.TabStop = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(97, 201);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(1);
            this.BtnCancelar.MaximumSize = new System.Drawing.Size(118, 46);
            this.BtnCancelar.MinimumSize = new System.Drawing.Size(125, 50);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(125, 50);
            this.BtnCancelar.TabIndex = 157;
            this.BtnCancelar.Clicked += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.Location = new System.Drawing.Point(224, 201);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(1);
            this.BtnOk.MaximumSize = new System.Drawing.Size(118, 46);
            this.BtnOk.MinimumSize = new System.Drawing.Size(125, 50);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(125, 50);
            this.BtnOk.TabIndex = 158;
            this.BtnOk.Clicked += new System.EventHandler(this.BtnOk_Click_1);
            // 
            // FrmSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 261);
            this.ControlBox = false;
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.linhaDivisora);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.Lblsenha);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSenha";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticação";
            this.Load += new System.EventHandler(this.FrmSobre_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSenha_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel Lblsenha;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSenha;
        private MaterialSkin.Controls.MaterialDivider linhaDivisora;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MaterialSkin.Controls.MaterialContextMenuStrip MenuStrip;
        private Componentes.ColoredButton BtnCancelar;
        private Componentes.ColoredButton BtnOk;
    }
}