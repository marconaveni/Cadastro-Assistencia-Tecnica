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
            this.BtnRemove = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnMoveDown = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnMoveUp = new MaterialSkin.Controls.MaterialFlatButton();
            this.CmbSugestion = new Cadastro_Assistencia_Tecnica.Componentes.ComboTextField();
            this.LstSugestions = new System.Windows.Forms.ListBox();
            this.BtnDefaut = new Cadastro_Assistencia_Tecnica.Componentes.ColoredButton();
            this.BtnSalvar = new Cadastro_Assistencia_Tecnica.Componentes.ColoredButton();
            this.TxtAddSugestion = new Cadastro_Assistencia_Tecnica.Componentes.TextField();
            this.TbConections = new System.Windows.Forms.TabPage();
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
            this.MTBSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.LblTexto = new System.Windows.Forms.Label();
            this.LblTextoo = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.LinhaDivisoraTbCad = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.TbConfigs.SuspendLayout();
            this.TbSugestion.SuspendLayout();
            this.TbConections.SuspendLayout();
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
            this.TbConfigs.Depth = 0;
            this.TbConfigs.Location = new System.Drawing.Point(5, 111);
            this.TbConfigs.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbConfigs.Name = "TbConfigs";
            this.TbConfigs.SelectedIndex = 0;
            this.TbConfigs.Size = new System.Drawing.Size(841, 490);
            this.TbConfigs.TabIndex = 0;
            // 
            // TbSugestion
            // 
            this.TbSugestion.BackColor = System.Drawing.SystemColors.Control;
            this.TbSugestion.Controls.Add(this.LinhaDivisoraTbCad);
            this.TbSugestion.Controls.Add(this.materialLabel2);
            this.TbSugestion.Controls.Add(this.materialLabel1);
            this.TbSugestion.Controls.Add(this.LblTextoo);
            this.TbSugestion.Controls.Add(this.BtnRemove);
            this.TbSugestion.Controls.Add(this.BtnAdd);
            this.TbSugestion.Controls.Add(this.BtnMoveDown);
            this.TbSugestion.Controls.Add(this.BtnMoveUp);
            this.TbSugestion.Controls.Add(this.CmbSugestion);
            this.TbSugestion.Controls.Add(this.LstSugestions);
            this.TbSugestion.Controls.Add(this.BtnDefaut);
            this.TbSugestion.Controls.Add(this.BtnSalvar);
            this.TbSugestion.Controls.Add(this.TxtAddSugestion);
            this.TbSugestion.Location = new System.Drawing.Point(4, 28);
            this.TbSugestion.Name = "TbSugestion";
            this.TbSugestion.Padding = new System.Windows.Forms.Padding(3);
            this.TbSugestion.Size = new System.Drawing.Size(833, 458);
            this.TbSugestion.TabIndex = 0;
            this.TbSugestion.Text = "Editar Sugestões";
            this.TbSugestion.Click += new System.EventHandler(this.TbSugestion_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.AutoSize = true;
            this.BtnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRemove.Depth = 0;
            this.BtnRemove.Icon = null;
            this.BtnRemove.Location = new System.Drawing.Point(413, 338);
            this.BtnRemove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Primary = false;
            this.BtnRemove.Size = new System.Drawing.Size(84, 36);
            this.BtnRemove.TabIndex = 6;
            this.BtnRemove.TabStop = false;
            this.BtnRemove.Text = "Remover";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.AutoSize = true;
            this.BtnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAdd.Depth = 0;
            this.BtnAdd.Icon = null;
            this.BtnAdd.Location = new System.Drawing.Point(312, 338);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Primary = false;
            this.BtnAdd.Size = new System.Drawing.Size(93, 36);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.TabStop = false;
            this.BtnAdd.Text = "Adicionar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnMoveDown
            // 
            this.BtnMoveDown.AutoSize = true;
            this.BtnMoveDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnMoveDown.Depth = 0;
            this.BtnMoveDown.Icon = null;
            this.BtnMoveDown.Location = new System.Drawing.Point(505, 338);
            this.BtnMoveDown.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnMoveDown.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnMoveDown.Name = "BtnMoveDown";
            this.BtnMoveDown.Primary = false;
            this.BtnMoveDown.Size = new System.Drawing.Size(111, 36);
            this.BtnMoveDown.TabIndex = 7;
            this.BtnMoveDown.TabStop = false;
            this.BtnMoveDown.Text = "Mover Baixo";
            this.BtnMoveDown.UseVisualStyleBackColor = true;
            this.BtnMoveDown.Click += new System.EventHandler(this.BtnMoveDown_Click);
            // 
            // BtnMoveUp
            // 
            this.BtnMoveUp.AutoSize = true;
            this.BtnMoveUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnMoveUp.Depth = 0;
            this.BtnMoveUp.Icon = null;
            this.BtnMoveUp.Location = new System.Drawing.Point(624, 338);
            this.BtnMoveUp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnMoveUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnMoveUp.Name = "BtnMoveUp";
            this.BtnMoveUp.Primary = false;
            this.BtnMoveUp.Size = new System.Drawing.Size(105, 36);
            this.BtnMoveUp.TabIndex = 8;
            this.BtnMoveUp.TabStop = false;
            this.BtnMoveUp.Text = "Mover Cima";
            this.BtnMoveUp.UseVisualStyleBackColor = true;
            this.BtnMoveUp.Click += new System.EventHandler(this.MoveUp);
            // 
            // CmbSugestion
            // 
            this.CmbSugestion.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSugestion.LineColor = System.Drawing.Color.LightGray;
            this.CmbSugestion.Location = new System.Drawing.Point(456, 213);
            this.CmbSugestion.Margin = new System.Windows.Forms.Padding(1);
            this.CmbSugestion.MaximumSize = new System.Drawing.Size(1920, 30);
            this.CmbSugestion.MinimumSize = new System.Drawing.Size(135, 40);
            this.CmbSugestion.Name = "CmbSugestion";
            this.CmbSugestion.SelectedIndex = -1;
            this.CmbSugestion.Size = new System.Drawing.Size(316, 40);
            this.CmbSugestion.TabIndex = 1;
            this.CmbSugestion.SelectedIndexChanged += new System.EventHandler(this.CmbSugestion_SelectedIndexChanged);
            // 
            // LstSugestions
            // 
            this.LstSugestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstSugestions.FormattingEnabled = true;
            this.LstSugestions.ItemHeight = 19;
            this.LstSugestions.Location = new System.Drawing.Point(49, 70);
            this.LstSugestions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LstSugestions.Name = "LstSugestions";
            this.LstSugestions.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstSugestions.Size = new System.Drawing.Size(234, 304);
            this.LstSugestions.TabIndex = 4;
            // 
            // BtnDefaut
            // 
            this.BtnDefaut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDefaut.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDefaut.Location = new System.Drawing.Point(146, 402);
            this.BtnDefaut.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDefaut.MaximumSize = new System.Drawing.Size(118, 46);
            this.BtnDefaut.MinimumSize = new System.Drawing.Size(125, 50);
            this.BtnDefaut.Name = "BtnDefaut";
            this.BtnDefaut.Size = new System.Drawing.Size(125, 50);
            this.BtnDefaut.TabIndex = 3;
            this.BtnDefaut.Clicked += new System.EventHandler(this.BtnDefaut_Clicked);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSalvar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(19, 402);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSalvar.MaximumSize = new System.Drawing.Size(118, 46);
            this.BtnSalvar.MinimumSize = new System.Drawing.Size(125, 50);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(125, 50);
            this.BtnSalvar.TabIndex = 2;
            this.BtnSalvar.Clicked += new System.EventHandler(this.BtnSalvar_Clicked);
            // 
            // TxtAddSugestion
            // 
            this.TxtAddSugestion.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddSugestion.LineColor = System.Drawing.Color.LightGray;
            this.TxtAddSugestion.Location = new System.Drawing.Point(456, 146);
            this.TxtAddSugestion.Margin = new System.Windows.Forms.Padding(1);
            this.TxtAddSugestion.MaximumSize = new System.Drawing.Size(1920, 30);
            this.TxtAddSugestion.MaxLength = 255;
            this.TxtAddSugestion.MinimumSize = new System.Drawing.Size(135, 30);
            this.TxtAddSugestion.Name = "TxtAddSugestion";
            this.TxtAddSugestion.PasswordChar = '\0';
            this.TxtAddSugestion.ReadOnly = false;
            this.TxtAddSugestion.Size = new System.Drawing.Size(316, 30);
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
            this.TbConections.Size = new System.Drawing.Size(833, 458);
            this.TbConections.TabIndex = 1;
            this.TbConections.Text = "Conexões com banco de dados";
            // 
            // BtnTest
            // 
            this.BtnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnTest.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTest.Location = new System.Drawing.Point(146, 402);
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
            this.BtnSalvarDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSalvarDb.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvarDb.Location = new System.Drawing.Point(19, 402);
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
            this.lblDbPassword.Location = new System.Drawing.Point(52, 269);
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
            this.TxtDbPassword.Location = new System.Drawing.Point(232, 269);
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
            this.LblDbUser.Location = new System.Drawing.Point(52, 222);
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
            this.LblDataBase.Location = new System.Drawing.Point(52, 175);
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
            this.lblNameServer.Location = new System.Drawing.Point(52, 128);
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
            this.TxtDbUser.Location = new System.Drawing.Point(232, 222);
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
            this.TxtDataBase.Location = new System.Drawing.Point(232, 175);
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
            this.TxtNameSever.Location = new System.Drawing.Point(232, 128);
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
            // LblTexto
            // 
            this.LblTexto.AutoSize = true;
            this.LblTexto.BackColor = System.Drawing.Color.Transparent;
            this.LblTexto.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTexto.ForeColor = System.Drawing.Color.Black;
            this.LblTexto.Location = new System.Drawing.Point(44, 21);
            this.LblTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTexto.Name = "LblTexto";
            this.LblTexto.Size = new System.Drawing.Size(391, 29);
            this.LblTexto.TabIndex = 6;
            this.LblTexto.Text = "Configurações do Banco  de Dados";
            // 
            // LblTextoo
            // 
            this.LblTextoo.AutoSize = true;
            this.LblTextoo.BackColor = System.Drawing.Color.Transparent;
            this.LblTextoo.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTextoo.ForeColor = System.Drawing.Color.Black;
            this.LblTextoo.Location = new System.Drawing.Point(44, 20);
            this.LblTextoo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTextoo.Name = "LblTextoo";
            this.LblTextoo.Size = new System.Drawing.Size(443, 29);
            this.LblTextoo.TabIndex = 10;
            this.LblTextoo.Text = "Configurações de sugestões de campos";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(308, 222);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(143, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Campo de sugestão";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(308, 146);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(139, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Adicionar sugestão";
            // 
            // LinhaDivisoraTbCad
            // 
            this.LinhaDivisoraTbCad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinhaDivisoraTbCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LinhaDivisoraTbCad.Depth = 0;
            this.LinhaDivisoraTbCad.Location = new System.Drawing.Point(-29, 393);
            this.LinhaDivisoraTbCad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LinhaDivisoraTbCad.MouseState = MaterialSkin.MouseState.HOVER;
            this.LinhaDivisoraTbCad.Name = "LinhaDivisoraTbCad";
            this.LinhaDivisoraTbCad.Size = new System.Drawing.Size(890, 1);
            this.LinhaDivisoraTbCad.TabIndex = 9;
            this.LinhaDivisoraTbCad.TabStop = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-29, 393);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(890, 1);
            this.materialDivider1.TabIndex = 11;
            this.materialDivider1.TabStop = false;
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(852, 606);
            this.Controls.Add(this.MTBSelector);
            this.Controls.Add(this.TbConfigs);
            this.Controls.Add(this.materialTabSelector1);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfig";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.TbConfigs.ResumeLayout(false);
            this.TbSugestion.ResumeLayout(false);
            this.TbSugestion.PerformLayout();
            this.TbConections.ResumeLayout(false);
            this.TbConections.PerformLayout();
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
        private MaterialSkin.Controls.MaterialFlatButton BtnMoveDown;
        private MaterialSkin.Controls.MaterialFlatButton BtnMoveUp;
        private MaterialSkin.Controls.MaterialFlatButton BtnRemove;
        private MaterialSkin.Controls.MaterialFlatButton BtnAdd;
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
    }
}