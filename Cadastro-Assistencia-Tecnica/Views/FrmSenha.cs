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
        private int nroTentativas = 3;

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
            TxtSenha.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtSenha.Focus();
            BtnCancelar.Text = "Cancelar";
            BtnOk.Text = "Login";
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
            TxtSenha.Text = "";
            this.Close();
        }

        private void DoValidarSenha() {
            if (Senha().Equals(ConfigurationManager.AppSettings["pass"].ToString()))
            {
                this.Close();
            }
            else
            {              
                nroTentativas--;
                if (nroTentativas < 1)
                {
                    MessageBox.Show("Senha errada, número de tentativas excedido", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BtnOk.Enabled = false;
                    TxtSenha.EnableTextField(false);
                }
                else
                {
                    MessageBox.Show("Senha errada, só mais " + nroTentativas + " tentativa(s)", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                TxtSenha.Text = "";
            }
        
        }

        private void FrmSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (nroTentativas > 0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DoValidarSenha();
                }
            }

            if (e.KeyCode == Keys.F4)
            {
                this.Hide();
            }
        }

       
    }
}
