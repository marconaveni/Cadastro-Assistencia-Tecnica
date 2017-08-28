namespace Cadastro_Assistencia_Tecnica.Views
{
    partial class FrmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.TbConfigs = new MaterialSkin.Controls.MaterialTabControl();
            this.TbSugestion = new System.Windows.Forms.TabPage();
            this.BtnRestore = new Cadastro_Assistencia_Tecnica.Componentes.RaisedButtonRipple();
            this.BtnOderBy = new Cadastro_Assistencia_Tecnica.Componentes.RaisedButtonRipple();
            this.LblTips = new MaterialSkin.Controls.MaterialLabel();
            this.BtnMoveUp = new Cadastro_Assistencia_Tecnica.Componentes.RaisedButtonRipple();
            this.BtnMoveDown = new Cadastro_Assistencia_Tecnica.Componentes.RaisedButtonRipple();
            this.BtnRemove = new Cadastro_Assistencia_Tecnica.Componentes.RaisedButtonRipple();
            this.BtnAdd = new Cadastro_Assistencia_Tecnica.Componentes.RaisedButtonRipple();
            this.LinhaDivisoraTbCad = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.LblTextoo = new System.Windows.Forms.Label();
            this.CmbSugestion = new Cadastro_Assistencia_Tecnica.Componentes.ComboTextField();
            this.LstSugestions = new System.Windows.Forms.ListBox();
            this.BtnDefaut = new Cadastro_Assistencia_Tecnica.Componentes.ColoredButton();
            this.BtnSalvar = new Cadastro_Assistencia_Tecnica.Componentes.ColoredButton();
            this.TxtAddSugestion = new Cadastro_Assistencia_Tecnica.Componentes.TextField();
            this.TbConections = new System.Windows.Forms.TabPage();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.LblTexto = new System.Windows.Forms.Label();
            this.BtnTest = new Cadastro_Assistencia_Tecnica.Componentes.ColoredButton();
            this.BtnSalvarDb = new Cadastro_Assistencia_Tecnica.Componentes.ColoredButton();
            this.lblDbPassword = new MaterialSkin.Controls.MaterialLabel();
            this.TxtDbPassword = new Cadastro_Assistencia_Tecnica.Componentes.TextField();
            this.LblDbUser = new MaterialSkin.Controls.MaterialLabel();
            this.LblDataBase = new MaterialSkin.Controls.MaterialLabel();
            this.lblNameServer = new MaterialSkin.Controls.MaterialLabel();
            this.TxtDbUser = new Cadastro_Assistencia_Tecnica.Componentes.TextField();
            this.TxtDataBase = new Cadastro_Assistencia_Tecnica.Componentes.TextField();
            this.TxtNameSever = new Cadastro_Assistencia_Tecnica.Componentes.TextField();
            this.TbSenha = new System.Windows.Forms.TabPage();
            this.LblAlterarSenha = new System.Windows.Forms.Label();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.BtnSalvarSenha = new Cadastro_Assistencia_Tecnica.Componentes.ColoredButton();
            this.LblConfirmeSenha = new MaterialSkin.Controls.MaterialLabel();
            this.TxtConfirmarSenha = new Cadastro_Assistencia_Tecnica.Componentes.TextField();
            this.LblSenhaNova = new MaterialSkin.Controls.MaterialLabel();
            this.LlbSenhaAtual = new MaterialSkin.Controls.MaterialLabel();
            this.TxtNovaSenha = new Cadastro_Assistencia_Tecnica.Componentes.TextField();
            this.TxtAtualSenha = new Cadastro_Assistencia_Tecnica.Componentes.TextField();
            this.TbSobre = new System.Windows.Forms.TabPage();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.BtnSair = new Cadastro_Assistencia_Tecnica.Componentes.ColoredButton();
            this.label1 = new System.Windows.Forms.Label();
            this.LblDateYear = new MaterialSkin.Controls.MaterialLabel();
            this.LblNumber = new MaterialSkin.Controls.MaterialLabel();
            this.LblVersion = new MaterialSkin.Controls.MaterialLabel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Lblname = new System.Windows.Forms.Label();
            this.MTBSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.ShadowTop = new System.Windows.Forms.PictureBox();
            this.TbConfigs.SuspendLayout();
            this.TbSugestion.SuspendLayout();
            this.TbConections.SuspendLayout();
            this.TbSenha.SuspendLayout();
            this.TbSobre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShadowTop)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = null;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 54);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(747, 51);
            this.materialTabSelector1.TabIndex = 8;
            this.materialTabSelector1.TabStop = false;
            this.materialTabSelector1.Text = "MTbSelector";
            // 
            // TbConfigs
            // 
            this.TbConfigs.Controls.Add(this.TbSugestion);
            this.TbConfigs.Controls.Add(this.TbConections);
            this.TbConfigs.Controls.Add(this.TbSenha);
            this.TbConfigs.Controls.Add(this.TbSobre);
            this.TbConfigs.Depth = 0;
            this.TbConfigs.Location = new System.Drawing.Point(1, 127);
            this.TbConfigs.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbConfigs.Name = "TbConfigs";
            this.TbConfigs.SelectedIndex = 0;
            this.TbConfigs.Size = new System.Drawing.Size(849, 502);
            this.TbConfigs.TabIndex = 0;
            // 
            // TbSugestion
            // 
            this.TbSugestion.BackColor = System.Drawing.SystemColors.Control;
            this.TbSugestion.Controls.Add(this.BtnRestore);
            this.TbSugestion.Controls.Add(this.BtnOderBy);
            this.TbSugestion.Controls.Add(this.LblTips);
            this.TbSugestion.Controls.Add(this.BtnMoveUp);
            this.TbSugestion.Controls.Add(this.BtnMoveDown);
            this.TbSugestion.Controls.Add(this.BtnRemove);
            this.TbSugestion.Controls.Add(this.BtnAdd);
            this.TbSugestion.Controls.Add(this.LinhaDivisoraTbCad);
            this.TbSugestion.Controls.Add(this.materialLabel2);
            this.TbSugestion.Controls.Add(this.materialLabel1);
            this.TbSugestion.Controls.Add(this.LblTextoo);
            this.TbSugestion.Controls.Add(this.CmbSugestion);
            this.TbSugestion.Controls.Add(this.LstSugestions);
            this.TbSugestion.Controls.Add(this.BtnDefaut);
            this.TbSugestion.Controls.Add(this.BtnSalvar);
            this.TbSugestion.Controls.Add(this.TxtAddSugestion);
            this.TbSugestion.Location = new System.Drawing.Point(4, 28);
            this.TbSugestion.Name = "TbSugestion";
            this.TbSugestion.Padding = new System.Windows.Forms.Padding(3);
            this.TbSugestion.Size = new System.Drawing.Size(841, 470);
            this.TbSugestion.TabIndex = 0;
            this.TbSugestion.Text = "Editar Sugestões";
            // 
            // BtnRestore
            // 
            this.BtnRestore.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestore.Location = new System.Drawing.Point(672, 354);
            this.BtnRestore.Margin = new System.Windows.Forms.Padding(1);
            this.BtnRestore.MaximumSize = new System.Drawing.Size(118, 46);
            this.BtnRestore.MinimumSize = new System.Drawing.Size(125, 50);
            this.BtnRestore.Name = "BtnRestore";
            this.BtnRestore.Size = new System.Drawing.Size(125, 50);
            this.BtnRestore.TabIndex = 7;
            this.BtnRestore.Clicked += new System.EventHandler(this.BtnRestore_Clicked);
            // 
            // BtnOderBy
            // 
            this.BtnOderBy.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOderBy.Location = new System.Drawing.Point(672, 286);
            this.BtnOderBy.Margin = new System.Windows.Forms.Padding(1);
            this.BtnOderBy.MaximumSize = new System.Drawing.Size(118, 46);
            this.BtnOderBy.MinimumSize = new System.Drawing.Size(125, 50);
            this.BtnOderBy.Name = "BtnOderBy";
            this.BtnOderBy.Size = new System.Drawing.Size(125, 50);
            this.BtnOderBy.TabIndex = 6;
            this.BtnOderBy.Clicked += new System.EventHandler(this.BtnOderBy_Clicked);
            // 
            // LblTips
            // 
            this.LblTips.AutoSize = true;
            this.LblTips.Depth = 0;
            this.LblTips.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTips.Location = new System.Drawing.Point(317, 243);
            this.LblTips.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTips.Name = "LblTips";
            this.LblTips.Size = new System.Drawing.Size(222, 19);
            this.LblTips.TabIndex = 14;
            this.LblTips.Text = "Clique em salvar para modificar\r\n";
            this.LblTips.Visible = false;
            // 
            // BtnMoveUp
            // 
            this.BtnMoveUp.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMoveUp.Location = new System.Drawing.Point(492, 286);
            this.BtnMoveUp.Margin = new System.Windows.Forms.Padding(1);
            this.BtnMoveUp.MaximumSize = new System.Drawing.Size(118, 46);
            this.BtnMoveUp.MinimumSize = new System.Drawing.Size(125, 50);
            this.BtnMoveUp.Name = "BtnMoveUp";
            this.BtnMoveUp.Size = new System.Drawing.Size(125, 50);
            this.BtnMoveUp.TabIndex = 4;
            this.BtnMoveUp.Clicked += new System.EventHandler(this.MoveUp);
            // 
            // BtnMoveDown
            // 
            this.BtnMoveDown.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMoveDown.Location = new System.Drawing.Point(492, 354);
            this.BtnMoveDown.Margin = new System.Windows.Forms.Padding(1);
            this.BtnMoveDown.MaximumSize = new System.Drawing.Size(118, 46);
            this.BtnMoveDown.MinimumSize = new System.Drawing.Size(125, 50);
            this.BtnMoveDown.Name = "BtnMoveDown";
            this.BtnMoveDown.Size = new System.Drawing.Size(125, 50);
            this.BtnMoveDown.TabIndex = 5;
            this.BtnMoveDown.Clicked += new System.EventHandler(this.BtnMoveDown_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove.Location = new System.Drawing.Point(312, 354);
            this.BtnRemove.Margin = new System.Windows.Forms.Padding(1);
            this.BtnRemove.MaximumSize = new System.Drawing.Size(118, 46);
            this.BtnRemove.MinimumSize = new System.Drawing.Size(125, 50);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(125, 50);
            this.BtnRemove.TabIndex = 3;
            this.BtnRemove.Clicked += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(312, 286);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(1);
            this.BtnAdd.MaximumSize = new System.Drawing.Size(118, 46);
            this.BtnAdd.MinimumSize = new System.Drawing.Size(125, 50);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(125, 50);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Clicked += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LinhaDivisoraTbCad
            // 
            this.LinhaDivisoraTbCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LinhaDivisoraTbCad.Depth = 0;
            this.LinhaDivisoraTbCad.Location = new System.Drawing.Point(-29, 430);
            this.LinhaDivisoraTbCad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LinhaDivisoraTbCad.MinimumSize = new System.Drawing.Size(890, 1);
            this.LinhaDivisoraTbCad.MouseState = MaterialSkin.MouseState.HOVER;
            this.LinhaDivisoraTbCad.Name = "LinhaDivisoraTbCad";
            this.LinhaDivisoraTbCad.Size = new System.Drawing.Size(901, 1);
            this.LinhaDivisoraTbCad.TabIndex = 15;
            this.LinhaDivisoraTbCad.TabStop = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(317, 104);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(139, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Adicionar sugestão";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(317, 180);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(143, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Campo de sugestão";
            // 
            // LblTextoo
            // 
            this.LblTextoo.AutoSize = true;
            this.LblTextoo.BackColor = System.Drawing.Color.Transparent;
            this.LblTextoo.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTextoo.ForeColor = System.Drawing.Color.Black;
            this.LblTextoo.Location = new System.Drawing.Point(44, 10);
            this.LblTextoo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTextoo.Name = "LblTextoo";
            this.LblTextoo.Size = new System.Drawing.Size(443, 29);
            this.LblTextoo.TabIndex = 10;
            this.LblTextoo.Text = "Configurações de sugestões de campos";
            // 
            // CmbSugestion
            // 
            this.CmbSugestion.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSugestion.LineColor = System.Drawing.Color.LightGray;
            this.CmbSugestion.Location = new System.Drawing.Point(465, 171);
            this.CmbSugestion.Margin = new System.Windows.Forms.Padding(1);
            this.CmbSugestion.MaximumSize = new System.Drawing.Size(1920, 30);
            this.CmbSugestion.MinimumSize = new System.Drawing.Size(135, 40);
            this.CmbSugestion.Name = "CmbSugestion";
            this.CmbSugestion.SelectedIndex = -1;
            this.CmbSugestion.Size = new System.Drawing.Size(324, 40);
            this.CmbSugestion.TabIndex = 1;
            this.CmbSugestion.SelectedIndexChanged += new System.EventHandler(this.CmbSugestion_SelectedIndexChanged);
            this.CmbSugestion.Click += new System.EventHandler(this.CmbSugestion_Click);
            this.CmbSugestion.Enter += new System.EventHandler(this.CmbSugestion_Enter);
            // 
            // LstSugestions
            // 
            this.LstSugestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstSugestions.FormattingEnabled = true;
            this.LstSugestions.ItemHeight = 19;
            this.LstSugestions.Location = new System.Drawing.Point(49, 81);
            this.LstSugestions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LstSugestions.Name = "LstSugestions";
            this.LstSugestions.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstSugestions.Size = new System.Drawing.Size(234, 323);
            this.LstSugestions.TabIndex = 11;
            // 
            // BtnDefaut
            // 
            this.BtnDefaut.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDefaut.Location = new System.Drawing.Point(146, 439);
            this.BtnDefaut.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDefaut.MaximumSize = new System.Drawing.Size(118, 46);
            this.BtnDefaut.MinimumSize = new System.Drawing.Size(125, 50);
            this.BtnDefaut.Name = "BtnDefaut";
            this.BtnDefaut.Size = new System.Drawing.Size(125, 50);
            this.BtnDefaut.TabIndex = 9;
            this.BtnDefaut.Clicked += new System.EventHandler(this.BtnDefaut_Clicked);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(19, 439);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSalvar.MaximumSize = new System.Drawing.Size(118, 46);
            this.BtnSalvar.MinimumSize = new System.Drawing.Size(125, 50);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(125, 50);
            this.BtnSalvar.TabIndex = 8;
            this.BtnSalvar.Clicked += new System.EventHandler(this.BtnSalvar_Clicked);
            // 
            // TxtAddSugestion
            // 
            this.TxtAddSugestion.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddSugestion.LineColor = System.Drawing.Color.LightGray;
            this.TxtAddSugestion.Location = new System.Drawing.Point(465, 104);
            this.TxtAddSugestion.Margin = new System.Windows.Forms.Padding(1);
            this.TxtAddSugestion.MaximumSize = new System.Drawing.Size(1920, 30);
            this.TxtAddSugestion.MaxLength = 255;
            this.TxtAddSugestion.MinimumSize = new System.Drawing.Size(135, 30);
            this.TxtAddSugestion.Name = "TxtAddSugestion";
            this.TxtAddSugestion.PasswordChar = '\0';
            this.TxtAddSugestion.ReadOnly = false;
            this.TxtAddSugestion.Size = new System.Drawing.Size(324, 30);
            this.TxtAddSugestion.TabIndex = 0;
            // 
            // TbConections
            // 
            this.TbConections.BackColor = System.Drawing.SystemColors.Control;
            this.TbConections.Controls.Add(this.materialDivider1);
            this.TbConections.Controls.Add(this.LblTexto);
            this.TbConections.Controls.Add(this.BtnTest);
            this.TbConections.Controls.Add(this.BtnSalvarDb);
            this.TbConections.Controls.Add(this.lblDbPassword);
            this.TbConections.Controls.Add(this.TxtDbPassword);
            this.TbConections.Controls.Add(this.LblDbUser);
            this.TbConections.Controls.Add(this.LblDataBase);
            this.TbConections.Controls.Add(this.lblNameServer);
            this.TbConections.Controls.Add(this.TxtDbUser);
            this.TbConections.Controls.Add(this.TxtDataBase);
            this.TbConections.Controls.Add(this.TxtNameSever);
            this.TbConections.Location = new System.Drawing.Point(4, 28);
            this.TbConections.Name = "TbConections";
            this.TbConections.Padding = new System.Windows.Forms.Padding(3);
            this.TbConections.Size = new System.Drawing.Size(841, 470);
            this.TbConections.TabIndex = 1;
            this.TbConections.Text = "Conexões com banco de dados";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-29, 430);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialDivider1.MinimumSize = new System.Drawing.Size(890, 1);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(901, 1);
            this.materialDivider1.TabIndex = 11;
            this.materialDivider1.TabStop = false;
            // 
            // LblTexto
            // 
            this.LblTexto.AutoSize = true;
            this.LblTexto.BackColor = System.Drawing.Color.Transparent;
            this.LblTexto.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTexto.ForeColor = System.Drawing.Color.Black;
            this.LblTexto.Location = new System.Drawing.Point(44, 10);
            this.LblTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTexto.Name = "LblTexto";
            this.LblTexto.Size = new System.Drawing.Size(391, 29);
            this.LblTexto.TabIndex = 6;
            this.LblTexto.Text = "Configurações do Banco  de Dados";
            // 
            // BtnTest
            // 
            this.BtnTest.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTest.Location = new System.Drawing.Point(146, 439);
            this.BtnTest.Margin = new System.Windows.Forms.Padding(1);
            this.BtnTest.MaximumSize = new System.Drawing.Size(118, 46);
            this.BtnTest.MinimumSize = new System.Drawing.Size(125, 50);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(125, 50);
            this.BtnTest.TabIndex = 5;
            this.BtnTest.Clicked += new System.EventHandler(this.BtnTest_Clicked);
            // 
            // BtnSalvarDb
            // 
            this.BtnSalvarDb.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvarDb.Location = new System.Drawing.Point(19, 439);
            this.BtnSalvarDb.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSalvarDb.MaximumSize = new System.Drawing.Size(118, 46);
            this.BtnSalvarDb.MinimumSize = new System.Drawing.Size(125, 50);
            this.BtnSalvarDb.Name = "BtnSalvarDb";
            this.BtnSalvarDb.Size = new System.Drawing.Size(125, 50);
            this.BtnSalvarDb.TabIndex = 4;
            this.BtnSalvarDb.Clicked += new System.EventHandler(this.BtnSalvarDb_Clicked);
            // 
            // lblDbPassword
            // 
            this.lblDbPassword.AutoSize = true;
            this.lblDbPassword.Depth = 0;
            this.lblDbPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDbPassword.Location = new System.Drawing.Point(44, 264);
            this.lblDbPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDbPassword.Name = "lblDbPassword";
            this.lblDbPassword.Size = new System.Drawing.Size(50, 19);
            this.lblDbPassword.TabIndex = 10;
            this.lblDbPassword.Text = "Senha";
            // 
            // TxtDbPassword
            // 
            this.TxtDbPassword.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDbPassword.LineColor = System.Drawing.Color.LightGray;
            this.TxtDbPassword.Location = new System.Drawing.Point(232, 262);
            this.TxtDbPassword.Margin = new System.Windows.Forms.Padding(1);
            this.TxtDbPassword.MaximumSize = new System.Drawing.Size(1920, 30);
            this.TxtDbPassword.MaxLength = 150;
            this.TxtDbPassword.MinimumSize = new System.Drawing.Size(135, 30);
            this.TxtDbPassword.Name = "TxtDbPassword";
            this.TxtDbPassword.PasswordChar = '•';
            this.TxtDbPassword.ReadOnly = false;
            this.TxtDbPassword.Size = new System.Drawing.Size(467, 30);
            this.TxtDbPassword.TabIndex = 3;
            // 
            // LblDbUser
            // 
            this.LblDbUser.AutoSize = true;
            this.LblDbUser.Depth = 0;
            this.LblDbUser.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblDbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDbUser.Location = new System.Drawing.Point(44, 217);
            this.LblDbUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDbUser.Name = "LblDbUser";
            this.LblDbUser.Size = new System.Drawing.Size(46, 19);
            this.LblDbUser.TabIndex = 9;
            this.LblDbUser.Text = "Login";
            // 
            // LblDataBase
            // 
            this.LblDataBase.AutoSize = true;
            this.LblDataBase.Depth = 0;
            this.LblDataBase.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblDataBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDataBase.Location = new System.Drawing.Point(44, 170);
            this.LblDataBase.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDataBase.Name = "LblDataBase";
            this.LblDataBase.Size = new System.Drawing.Size(154, 19);
            this.LblDataBase.TabIndex = 8;
            this.LblDataBase.Text = "Nome Base de Dados";
            // 
            // lblNameServer
            // 
            this.lblNameServer.AutoSize = true;
            this.lblNameServer.Depth = 0;
            this.lblNameServer.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNameServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNameServer.Location = new System.Drawing.Point(44, 123);
            this.lblNameServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNameServer.Name = "lblNameServer";
            this.lblNameServer.Size = new System.Drawing.Size(130, 19);
            this.lblNameServer.TabIndex = 7;
            this.lblNameServer.Text = "Nome do Servidor";
            // 
            // TxtDbUser
            // 
            this.TxtDbUser.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDbUser.LineColor = System.Drawing.Color.LightGray;
            this.TxtDbUser.Location = new System.Drawing.Point(232, 215);
            this.TxtDbUser.Margin = new System.Windows.Forms.Padding(1);
            this.TxtDbUser.MaximumSize = new System.Drawing.Size(1920, 30);
            this.TxtDbUser.MaxLength = 150;
            this.TxtDbUser.MinimumSize = new System.Drawing.Size(135, 30);
            this.TxtDbUser.Name = "TxtDbUser";
            this.TxtDbUser.PasswordChar = '\0';
            this.TxtDbUser.ReadOnly = false;
            this.TxtDbUser.Size = new System.Drawing.Size(467, 30);
            this.TxtDbUser.TabIndex = 2;
            // 
            // TxtDataBase
            // 
            this.TxtDataBase.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDataBase.LineColor = System.Drawing.Color.LightGray;
            this.TxtDataBase.Location = new System.Drawing.Point(232, 168);
            this.TxtDataBase.Margin = new System.Windows.Forms.Padding(1);
            this.TxtDataBase.MaximumSize = new System.Drawing.Size(1920, 30);
            this.TxtDataBase.MaxLength = 150;
            this.TxtDataBase.MinimumSize = new System.Drawing.Size(135, 30);
            this.TxtDataBase.Name = "TxtDataBase";
            this.TxtDataBase.PasswordChar = '\0';
            this.TxtDataBase.ReadOnly = false;
            this.TxtDataBase.Size = new System.Drawing.Size(467, 30);
            this.TxtDataBase.TabIndex = 1;
            // 
            // TxtNameSever
            // 
            this.TxtNameSever.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNameSever.LineColor = System.Drawing.Color.LightGray;
            this.TxtNameSever.Location = new System.Drawing.Point(232, 121);
            this.TxtNameSever.Margin = new System.Windows.Forms.Padding(1);
            this.TxtNameSever.MaximumSize = new System.Drawing.Size(1920, 30);
            this.TxtNameSever.MaxLength = 150;
            this.TxtNameSever.MinimumSize = new System.Drawing.Size(135, 30);
            this.TxtNameSever.Name = "TxtNameSever";
            this.TxtNameSever.PasswordChar = '\0';
            this.TxtNameSever.ReadOnly = false;
            this.TxtNameSever.Size = new System.Drawing.Size(467, 30);
            this.TxtNameSever.TabIndex = 0;
            // 
            // TbSenha
            // 
            this.TbSenha.BackColor = System.Drawing.SystemColors.Control;
            this.TbSenha.Controls.Add(this.LblAlterarSenha);
            this.TbSenha.Controls.Add(this.materialDivider3);
            this.TbSenha.Controls.Add(this.BtnSalvarSenha);
            this.TbSenha.Controls.Add(this.LblConfirmeSenha);
            this.TbSenha.Controls.Add(this.TxtConfirmarSenha);
            this.TbSenha.Controls.Add(this.LblSenhaNova);
            this.TbSenha.Controls.Add(this.LlbSenhaAtual);
            this.TbSenha.Controls.Add(this.TxtNovaSenha);
            this.TbSenha.Controls.Add(this.TxtAtualSenha);
            this.TbSenha.Location = new System.Drawing.Point(4, 28);
            this.TbSenha.Name = "TbSenha";
            this.TbSenha.Size = new System.Drawing.Size(841, 470);
            this.TbSenha.TabIndex = 3;
            this.TbSenha.Text = "Alterar Senha";
            // 
            // LblAlterarSenha
            // 
            this.LblAlterarSenha.AutoSize = true;
            this.LblAlterarSenha.BackColor = System.Drawing.Color.Transparent;
            this.LblAlterarSenha.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlterarSenha.ForeColor = System.Drawing.Color.Black;
            this.LblAlterarSenha.Location = new System.Drawing.Point(44, 10);
            this.LblAlterarSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAlterarSenha.Name = "LblAlterarSenha";
            this.LblAlterarSenha.Size = new System.Drawing.Size(347, 29);
            this.LblAlterarSenha.TabIndex = 4;
            this.LblAlterarSenha.Text = "Alterar senha de Administrador";
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(-29, 430);
            this.materialDivider3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialDivider3.MinimumSize = new System.Drawing.Size(890, 1);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(901, 1);
            this.materialDivider3.TabIndex = 8;
            this.materialDivider3.TabStop = false;
            // 
            // BtnSalvarSenha
            // 
            this.BtnSalvarSenha.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvarSenha.Location = new System.Drawing.Point(19, 439);
            this.BtnSalvarSenha.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSalvarSenha.MaximumSize = new System.Drawing.Size(118, 46);
            this.BtnSalvarSenha.MinimumSize = new System.Drawing.Size(125, 50);
            this.BtnSalvarSenha.Name = "BtnSalvarSenha";
            this.BtnSalvarSenha.Size = new System.Drawing.Size(125, 50);
            this.BtnSalvarSenha.TabIndex = 3;
            this.BtnSalvarSenha.Clicked += new System.EventHandler(this.BtnSalvarSenha_Clicked);
            // 
            // LblConfirmeSenha
            // 
            this.LblConfirmeSenha.AutoSize = true;
            this.LblConfirmeSenha.Depth = 0;
            this.LblConfirmeSenha.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblConfirmeSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblConfirmeSenha.Location = new System.Drawing.Point(44, 241);
            this.LblConfirmeSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblConfirmeSenha.Name = "LblConfirmeSenha";
            this.LblConfirmeSenha.Size = new System.Drawing.Size(163, 19);
            this.LblConfirmeSenha.TabIndex = 7;
            this.LblConfirmeSenha.Text = "Confirme a nova senha";
            // 
            // TxtConfirmarSenha
            // 
            this.TxtConfirmarSenha.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConfirmarSenha.LineColor = System.Drawing.Color.LightGray;
            this.TxtConfirmarSenha.Location = new System.Drawing.Point(232, 241);
            this.TxtConfirmarSenha.Margin = new System.Windows.Forms.Padding(1);
            this.TxtConfirmarSenha.MaximumSize = new System.Drawing.Size(1920, 30);
            this.TxtConfirmarSenha.MaxLength = 16;
            this.TxtConfirmarSenha.MinimumSize = new System.Drawing.Size(135, 30);
            this.TxtConfirmarSenha.Name = "TxtConfirmarSenha";
            this.TxtConfirmarSenha.PasswordChar = '•';
            this.TxtConfirmarSenha.ReadOnly = false;
            this.TxtConfirmarSenha.Size = new System.Drawing.Size(467, 30);
            this.TxtConfirmarSenha.TabIndex = 2;
            this.TxtConfirmarSenha.TextChangedd += new System.EventHandler(this.AlterColorLine);
            // 
            // LblSenhaNova
            // 
            this.LblSenhaNova.AutoSize = true;
            this.LblSenhaNova.Depth = 0;
            this.LblSenhaNova.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblSenhaNova.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblSenhaNova.Location = new System.Drawing.Point(44, 195);
            this.LblSenhaNova.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSenhaNova.Name = "LblSenhaNova";
            this.LblSenhaNova.Size = new System.Drawing.Size(88, 19);
            this.LblSenhaNova.TabIndex = 6;
            this.LblSenhaNova.Text = "Nova senha";
            // 
            // LlbSenhaAtual
            // 
            this.LlbSenhaAtual.AutoSize = true;
            this.LlbSenhaAtual.Depth = 0;
            this.LlbSenhaAtual.Font = new System.Drawing.Font("Roboto", 11F);
            this.LlbSenhaAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LlbSenhaAtual.Location = new System.Drawing.Point(44, 149);
            this.LlbSenhaAtual.MouseState = MaterialSkin.MouseState.HOVER;
            this.LlbSenhaAtual.Name = "LlbSenhaAtual";
            this.LlbSenhaAtual.Size = new System.Drawing.Size(87, 19);
            this.LlbSenhaAtual.TabIndex = 5;
            this.LlbSenhaAtual.Text = "Senha atual";
            // 
            // TxtNovaSenha
            // 
            this.TxtNovaSenha.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNovaSenha.LineColor = System.Drawing.Color.LightGray;
            this.TxtNovaSenha.Location = new System.Drawing.Point(232, 195);
            this.TxtNovaSenha.Margin = new System.Windows.Forms.Padding(1);
            this.TxtNovaSenha.MaximumSize = new System.Drawing.Size(1920, 30);
            this.TxtNovaSenha.MaxLength = 16;
            this.TxtNovaSenha.MinimumSize = new System.Drawing.Size(135, 30);
            this.TxtNovaSenha.Name = "TxtNovaSenha";
            this.TxtNovaSenha.PasswordChar = '•';
            this.TxtNovaSenha.ReadOnly = false;
            this.TxtNovaSenha.Size = new System.Drawing.Size(467, 30);
            this.TxtNovaSenha.TabIndex = 1;
            this.TxtNovaSenha.TextChangedd += new System.EventHandler(this.AlterColorLine);
            // 
            // TxtAtualSenha
            // 
            this.TxtAtualSenha.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAtualSenha.LineColor = System.Drawing.Color.LightGray;
            this.TxtAtualSenha.Location = new System.Drawing.Point(232, 149);
            this.TxtAtualSenha.Margin = new System.Windows.Forms.Padding(1);
            this.TxtAtualSenha.MaximumSize = new System.Drawing.Size(1920, 30);
            this.TxtAtualSenha.MaxLength = 16;
            this.TxtAtualSenha.MinimumSize = new System.Drawing.Size(135, 30);
            this.TxtAtualSenha.Name = "TxtAtualSenha";
            this.TxtAtualSenha.PasswordChar = '•';
            this.TxtAtualSenha.ReadOnly = false;
            this.TxtAtualSenha.Size = new System.Drawing.Size(467, 30);
            this.TxtAtualSenha.TabIndex = 0;
            this.TxtAtualSenha.TextChangedd += new System.EventHandler(this.AlterColorLine);
            // 
            // TbSobre
            // 
            this.TbSobre.BackColor = System.Drawing.SystemColors.Control;
            this.TbSobre.Controls.Add(this.materialDivider2);
            this.TbSobre.Controls.Add(this.BtnSair);
            this.TbSobre.Controls.Add(this.label1);
            this.TbSobre.Controls.Add(this.LblDateYear);
            this.TbSobre.Controls.Add(this.LblNumber);
            this.TbSobre.Controls.Add(this.LblVersion);
            this.TbSobre.Controls.Add(this.Logo);
            this.TbSobre.Controls.Add(this.Lblname);
            this.TbSobre.Location = new System.Drawing.Point(4, 28);
            this.TbSobre.Name = "TbSobre";
            this.TbSobre.Size = new System.Drawing.Size(841, 470);
            this.TbSobre.TabIndex = 2;
            this.TbSobre.Text = "Sobre Cadastro de Ficha";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(-29, 430);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialDivider2.MinimumSize = new System.Drawing.Size(890, 1);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(901, 1);
            this.materialDivider2.TabIndex = 6;
            this.materialDivider2.TabStop = false;
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(19, 439);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSair.MaximumSize = new System.Drawing.Size(118, 46);
            this.BtnSair.MinimumSize = new System.Drawing.Size(125, 50);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(125, 50);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.Clicked += new System.EventHandler(this.BtnSair_Clicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sobre Cadastro de Ficha";
            // 
            // LblDateYear
            // 
            this.LblDateYear.AutoSize = true;
            this.LblDateYear.Depth = 0;
            this.LblDateYear.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblDateYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDateYear.Location = new System.Drawing.Point(309, 276);
            this.LblDateYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDateYear.Name = "LblDateYear";
            this.LblDateYear.Size = new System.Drawing.Size(90, 19);
            this.LblDateYear.TabIndex = 5;
            this.LblDateYear.Text = "LblDateYear";
            // 
            // LblNumber
            // 
            this.LblNumber.AutoSize = true;
            this.LblNumber.Depth = 0;
            this.LblNumber.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNumber.Location = new System.Drawing.Point(309, 246);
            this.LblNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(82, 19);
            this.LblNumber.TabIndex = 4;
            this.LblNumber.Text = "LblNumber";
            // 
            // LblVersion
            // 
            this.LblVersion.AutoSize = true;
            this.LblVersion.Depth = 0;
            this.LblVersion.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblVersion.Location = new System.Drawing.Point(309, 216);
            this.LblVersion.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(81, 19);
            this.LblVersion.TabIndex = 3;
            this.LblVersion.Text = "LblVersion";
            // 
            // Logo
            // 
            this.Logo.Image = global::Cadastro_Assistencia_Tecnica.Properties.Resources.toolslogo;
            this.Logo.Location = new System.Drawing.Point(49, 130);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(218, 201);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo.TabIndex = 8;
            this.Logo.TabStop = false;
            // 
            // Lblname
            // 
            this.Lblname.AutoSize = true;
            this.Lblname.BackColor = System.Drawing.Color.Transparent;
            this.Lblname.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblname.ForeColor = System.Drawing.Color.Black;
            this.Lblname.Location = new System.Drawing.Point(309, 152);
            this.Lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lblname.Name = "Lblname";
            this.Lblname.Size = new System.Drawing.Size(208, 29);
            this.Lblname.TabIndex = 2;
            this.Lblname.Text = "Cadastro de Ficha";
            // 
            // MTBSelector
            // 
            this.MTBSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MTBSelector.BaseTabControl = this.TbConfigs;
            this.MTBSelector.Depth = 0;
            this.MTBSelector.Location = new System.Drawing.Point(0, 54);
            this.MTBSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.MTBSelector.Name = "MTBSelector";
            this.MTBSelector.Size = new System.Drawing.Size(852, 51);
            this.MTBSelector.TabIndex = 16;
            this.MTBSelector.TabStop = false;
            this.MTBSelector.Text = "materialTabSelector2";
            // 
            // ShadowTop
            // 
            this.ShadowTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShadowTop.Image = ((System.Drawing.Image)(resources.GetObject("ShadowTop.Image")));
            this.ShadowTop.Location = new System.Drawing.Point(1, 105);
            this.ShadowTop.Name = "ShadowTop";
            this.ShadowTop.Size = new System.Drawing.Size(850, 20);
            this.ShadowTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShadowTop.TabIndex = 157;
            this.ShadowTop.TabStop = false;
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(852, 632);
            this.Controls.Add(this.ShadowTop);
            this.Controls.Add(this.MTBSelector);
            this.Controls.Add(this.TbConfigs);
            this.Controls.Add(this.materialTabSelector1);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfig";
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmConfig_KeyUp);
            this.TbConfigs.ResumeLayout(false);
            this.TbSugestion.ResumeLayout(false);
            this.TbSugestion.PerformLayout();
            this.TbConections.ResumeLayout(false);
            this.TbConections.PerformLayout();
            this.TbSenha.ResumeLayout(false);
            this.TbSenha.PerformLayout();
            this.TbSobre.ResumeLayout(false);
            this.TbSobre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShadowTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl TbConfigs;
        private System.Windows.Forms.TabPage TbSugestion;
        private System.Windows.Forms.ListBox LstSugestions;
        private Componentes.ColoredButton BtnDefaut;
        private Componentes.ColoredButton BtnSalvar;
        private Componentes.TextField TxtAddSugestion;
        private System.Windows.Forms.TabPage TbConections;
        private MaterialSkin.Controls.MaterialTabSelector MTBSelector;
        private Componentes.ComboTextField CmbSugestion;
        private Componentes.ColoredButton BtnSalvarDb;
        private MaterialSkin.Controls.MaterialLabel lblDbPassword;
        private Componentes.TextField TxtDbPassword;
        private MaterialSkin.Controls.MaterialLabel LblDbUser;
        private MaterialSkin.Controls.MaterialLabel LblDataBase;
        private MaterialSkin.Controls.MaterialLabel lblNameServer;
        private Componentes.TextField TxtDbUser;
        private Componentes.TextField TxtDataBase;
        private Componentes.TextField TxtNameSever;
        private Componentes.ColoredButton BtnTest;
        private System.Windows.Forms.Label LblTextoo;
        private System.Windows.Forms.Label LblTexto;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialDivider LinhaDivisoraTbCad;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private Componentes.RaisedButtonRipple BtnAdd;
        private Componentes.RaisedButtonRipple BtnMoveUp;
        private Componentes.RaisedButtonRipple BtnMoveDown;
        private Componentes.RaisedButtonRipple BtnRemove;
        private MaterialSkin.Controls.MaterialLabel LblTips;
        private System.Windows.Forms.TabPage TbSobre;
        private MaterialSkin.Controls.MaterialLabel LblVersion;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Lblname;
        private MaterialSkin.Controls.MaterialLabel LblNumber;
        private MaterialSkin.Controls.MaterialLabel LblDateYear;
        private System.Windows.Forms.PictureBox ShadowTop;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private Componentes.ColoredButton BtnSair;
        private System.Windows.Forms.Label label1;
        private Componentes.RaisedButtonRipple BtnRestore;
        private Componentes.RaisedButtonRipple BtnOderBy;
        private System.Windows.Forms.TabPage TbSenha;
        private System.Windows.Forms.Label LblAlterarSenha;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private Componentes.ColoredButton BtnSalvarSenha;
        private MaterialSkin.Controls.MaterialLabel LblConfirmeSenha;
        private Componentes.TextField TxtConfirmarSenha;
        private MaterialSkin.Controls.MaterialLabel LblSenhaNova;
        private MaterialSkin.Controls.MaterialLabel LlbSenhaAtual;
        private Componentes.TextField TxtNovaSenha;
        private Componentes.TextField TxtAtualSenha;
    }
}