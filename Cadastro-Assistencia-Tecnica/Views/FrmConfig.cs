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

            BtnAdd.Text = "Adicionar";
            BtnRemove.Text = "Remover";
            BtnMoveDown.Text = "Mover Baixo";
            BtnMoveUp.Text = "Mover Cima";

            LblTips.Visible = false;

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
            LblTips.Visible = false;
            if (CmbSugestion.Text == "Aparelhos")
            {
                listname = "LIST_APARELHOS.CF";
            }
            else if (CmbSugestion.Text == "Marcas")
            {
                listname = "LIST_MARCAS.CF";
            }
            else if (CmbSugestion.Text == "Modelos")
            {
                listname = "LIST_MODELOS.CF";
            }
            else if (CmbSugestion.Text == "Acessórios")
            {
                listname = "LIST_ACESSORIOS.CF";
            }
            else if (CmbSugestion.Text == "Defeitos")
            {
                listname = "LIST_DEFEITOS.CF";
            }
            else
                return;

            LoadListSugestion();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtAddSugestion.Text.Length > 3)
            {
                LstSugestions.Items.Add(TxtAddSugestion.Text);
                TxtAddSugestion.Text = "";
            }
            LblTips.Visible = true;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
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

        private void CmbSugestion_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
