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
using System.Windows.Forms;

namespace Cadastro_Assistencia_Tecnica.Views
{
    public partial class FrmSenha : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public FrmSenha()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void FrmSobre_Load(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = MaterialSchemeColor.ThemeChanger();
            TxtSenha.Focus();
        }


        private void BtnOk_Click_1(object sender, EventArgs e)
        {
            DoValidarSenha();
        }



        public String Senha() { 
            return TxtSenha.Text;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DoValidarSenha() {
            if (Senha().Equals(ConfigurationManager.AppSettings["pass"].ToString()))
            {
                MessageBox.Show("Logado como Administrador", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Senha Errada", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void FrmSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter){
                DoValidarSenha();
            }

            if (e.KeyCode == Keys.F4)
            {
                this.Hide();
            }
        }

       
    }
}
