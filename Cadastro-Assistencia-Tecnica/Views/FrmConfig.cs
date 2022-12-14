using Cadastro_Assistencia_Tecnica.Business;
using Cadastro_Assistencia_Tecnica.Business.Impl;
using Cadastro_Assistencia_Tecnica.Model;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Assistencia_Tecnica.Views
{
    public partial class FrmConfig : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private IConnectionService service = new ConnectionService();

        private string listname;

        public FrmConfig()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = MaterialSchemeColor.ThemeChanger();
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            TbConfigs.SelectedTab = TbSobre;
            TbConfigs.SelectedTab = TbSugestion;


            CmbSugestion.Items = "Aparelhos";
            CmbSugestion.Items = "Marcas";
            CmbSugestion.Items = "Modelos";
            CmbSugestion.Items = "Acessórios";
            CmbSugestion.Items = "Defeitos";
            CmbSugestion.SelectedIndex = 0;

            BtnSalvar.Text = "Salvar";
            BtnDefaut.Text = "Padrão";
            BtnSalvarDb.Text = "Salvar";
            BtnTest.Text = "Testar";
            BtnSalvarSenha.Text = "Salvar";
            BtnSair.Text = "Sair";

            BtnAdd.Text = "Adicionar";
            BtnRemove.Text = "Remover";
            BtnMoveDown.Text = "Mover Baixo";
            BtnMoveUp.Text = "Mover Cima";
            BtnOderBy.Text = "Ordenar A-Z";
            BtnRestore.Text = "Restaurar";

            LblTips.Visible = false;


            LblVersion.Text = "Versão:   BETA";
            LblNumber.Text = "Número da versão:  " + ProductVersion.ToString();
            LblDateYear.Text = "Copyright 2017 By Marco Naveni. Todos os direitos reservados.";

            TxtNameSever.Text = ConfigurationManager.AppSettings["nameserver"].ToString();
            TxtDataBase.Text = ConfigurationManager.AppSettings["database"].ToString();
            TxtDbUser.Text = ConfigurationManager.AppSettings["dbuser"].ToString();
            TxtDbPassword.Text = ConfigurationManager.AppSettings["dbpassword"].ToString();

            TxtAddSugestion.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            CmbSugestion.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtNameSever.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtDataBase.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtDbUser.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtDbPassword.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtAtualSenha.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtNovaSenha.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtConfirmarSenha.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);

        }

        private void LoadListSugestion()
        {
            LstSugestions.Items.Clear();

            List<string> listitems = new List<string>();
            listitems = Autocomplete.LerArquivoList(listname);
            foreach (string item in listitems)
            {
                LstSugestions.Items.Add(item);
            }
        }

        private void CmbSugestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeList();
        }

        private void ChangeList()
        {
            LblTips.Visible = false;
            if (CmbSugestion.Text == "Aparelhos")
            {
                TxtAddSugestion.MaxLength = 40;
                listname = "LIST_APARELHOS.CF";
            }
            else if (CmbSugestion.Text == "Marcas")
            {
                TxtAddSugestion.MaxLength = 40;
                listname = "LIST_MARCAS.CF";
            }
            else if (CmbSugestion.Text == "Modelos")
            {
                TxtAddSugestion.MaxLength = 25;
                listname = "LIST_MODELOS.CF";
            }
            else if (CmbSugestion.Text == "Acessórios")
            {
                TxtAddSugestion.MaxLength = 20;
                listname = "LIST_ACESSORIOS.CF";
            }
            else if (CmbSugestion.Text == "Defeitos")
            {
                TxtAddSugestion.MaxLength = 40;
                listname = "LIST_DEFEITOS.CF";
            }
            else
                return;

            LoadListSugestion();
            TxtAddSugestion.Text = "";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Add()
        {
            if (TxtAddSugestion.Text.Length > 3)
            {
                LstSugestions.Items.Add(TxtAddSugestion.Text);
                TxtAddSugestion.Text = "";
                LstSugestions.SetSelected(LstSugestions.Items.Count - 1, true);
                LblTips.Visible = true;
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Delete()
        {
            while (LstSugestions.SelectedItems.Count > 0)
            {
                LstSugestions.Items.Remove(LstSugestions.SelectedItems[0]);
            }
            LblTips.Visible = true;
        }

        private void BtnSalvar_Clicked(object sender, EventArgs e)
        {         
            Salvar();
        }

        private void BtnDefaut_Clicked(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja restaurar as sugestões padrões de " + CmbSugestion.Text.ToLower() + "? ", "Atenção ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
            {
                Autocomplete.GravarDefaultArquivo(listname);
                LoadListSugestion();
                LblTips.Visible = false;
            }
        }

        private void BtnSalvarDb_Clicked(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja salvar configurações do banco de dados?", "Atenção ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
            {
                Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                configuration.AppSettings.Settings["nameserver"].Value = TxtNameSever.Text;
                configuration.AppSettings.Settings["database"].Value = TxtDataBase.Text;
                configuration.AppSettings.Settings["dbuser"].Value = TxtDbUser.Text;
                configuration.AppSettings.Settings["dbpassword"].Value = TxtDbPassword.Text;

                configuration.Save();

                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        private void MoveUp(object sender, EventArgs e)
        {
            MoveItem(-1);
            LblTips.Visible = true;
        }

        private void BtnMoveDown_Click(object sender, EventArgs e)
        {
            MoveItem(1);
            LblTips.Visible = true;
        }

        public void MoveItem(int direction)
        {
            // Checking selected item
            if (LstSugestions.SelectedItem == null || LstSugestions.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = LstSugestions.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= LstSugestions.Items.Count)
                return; // Index out of range - nothing to do

            object selected = LstSugestions.SelectedItem;

            // Removing removable element
            LstSugestions.Items.Remove(selected);
            // Insert it in new position
            LstSugestions.Items.Insert(newIndex, selected);
            // Restore selection
            LstSugestions.SetSelected(newIndex, true);
        }

        private void BtnTest_Clicked(object sender, EventArgs e)
        {
            try
            {
                service.testaConexao();
                MessageBox.Show("Conexao efetuada com sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DataBaseNotFoundException erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Salvar()
        {
            if (LblTips.Visible == false)
                return;
            DialogResult resp;
            resp = MessageBox.Show("Deseja alterar as sugestões de " + CmbSugestion.Text.ToLower() + "? ", "Atenção ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
            {
                List<string> listitems = new List<string>();

                foreach (string item in LstSugestions.Items)
                {
                    listitems.Add(item);
                }
                Autocomplete.GravarArquivo(listname, listitems);
                LblTips.Visible = false;
            }
        }


        private void CmbSugestion_Enter(object sender, EventArgs e)
        {
            Salvar();
        }

        private void FrmConfig_KeyUp(object sender, KeyEventArgs e)
        {
            Control ctl;
            ctl = (Control)sender;
            if (e.KeyCode == Keys.BrowserForward)
            {
                ctl.SelectNextControl(ActiveControl, true, true, true, true);
            }
            else if (e.KeyCode == Keys.BrowserBack)
            {
                // MessageBox.Show(this.ActiveControl.Name);
                ctl.SelectNextControl(ActiveControl, false, true, true, true);
            }

            if (e.KeyCode == Keys.Enter)
            {
                Add();
            }
            if (e.KeyCode == Keys.Delete)
            {
                Delete();
            }
        }

        private void BtnSair_Clicked(object sender, EventArgs e)
        {
            Salvar();
            this.Close();
        }

        private void BtnOderBy_Clicked(object sender, EventArgs e)
        {
            LstSugestions.Sorted = true;
            LstSugestions.Sorted = false;
        }

        private void BtnRestore_Clicked(object sender, EventArgs e)
        {
            ChangeList();
        }

        private void BtnSalvarSenha_Clicked(object sender, EventArgs e)
        {
            if (TxtNovaSenha.Text.Length < 4)
            {
                MessageBox.Show("Nova senha deve ter no minímo 4 carácteres!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNovaSenha.LineColor = Color.Red;
                TxtConfirmarSenha.LineColor = Color.Red;
                TxtAtualSenha.Focus();
            }
            else if(ConfigurationManager.AppSettings["pass"].ToString() == TxtAtualSenha.Text)
            {
                if (TxtNovaSenha.Text == TxtConfirmarSenha.Text)
                {
                    if (TxtAtualSenha.Text != TxtNovaSenha.Text)
                    {
                        Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        configuration.AppSettings.Settings["pass"].Value = TxtNovaSenha.Text;
                        configuration.Save();
                        ConfigurationManager.RefreshSection("appSettings");
                        MessageBox.Show("Senha de Administrador alterada com sucesso.", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtAtualSenha.Text = "";
                        TxtNovaSenha.Text = "";
                        TxtConfirmarSenha.Text = "";
                        TxtAtualSenha.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("A confirmação está diferente da senha informada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtNovaSenha.Focus();
                    TxtConfirmarSenha.Text = "";
                    TxtNovaSenha.LineColor = Color.Red;
                    TxtConfirmarSenha.LineColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Senha Atual não está correta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtAtualSenha.LineColor = Color.Red;
                TxtAtualSenha.Focus();
            }

        }

        private void AlterColorLine(object sender, EventArgs e)
        {
            TxtAtualSenha.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtNovaSenha.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtConfirmarSenha.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);

        }

    }
}
