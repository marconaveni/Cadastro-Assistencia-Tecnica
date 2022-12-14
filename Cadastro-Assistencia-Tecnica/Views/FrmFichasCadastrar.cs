using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cadastro_Assistencia_Tecnica.Model;
using Cadastro_Assistencia_Tecnica.Business.Impl;
using Cadastro_Assistencia_Tecnica.Business;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;
using Cadastro_Assistencia_Tecnica.Properties;
using System.Configuration;
using System.Diagnostics;
using Cadastro_Assistencia_Tecnica.Save;

namespace Cadastro_Assistencia_Tecnica.Views
{
    public partial class FrmFichasCadastrar : MaterialForm
    {
        private IFichaService service = new FichaService();
        private readonly MaterialSkinManager materialSkinManager;
        private int id = 0;


        public FrmFichasCadastrar()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = MaterialSchemeColor.ThemeChanger();

        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            try
            {
                BtnCadastrar.Text = "Cadastrar";
                BtnAlterar.Text = "Alterar";
                BtnNovo.Text = "Novo";
                BtnImprimir.Text = "Visualizar";
                BtnExcluir.Text = "Excluir";

                BtnOpcoes.Text = "Opções";
                BtnThemeMaterial.Text = "Mudar Tema";

                CmbAprovado.Items = "Em Aberto";
                CmbAprovado.Items = "Sim";
                CmbAprovado.Items = "Não";
                CmbAprovado.SelectedIndex = 0;

                CmbOk.Items = "Não";
                CmbOk.Items = "Sim";
                CmbOk.Items = "Devolução";
                CmbOk.Items = "Sem Defeito";
                CmbOk.SelectedIndex = 0;

                CmbEntrega.Items = "Não";
                CmbEntrega.Items = "Sim";
                CmbEntrega.SelectedIndex = 0;

                CmbPesquisa.Items = "Número";
                CmbPesquisa.Items = "Cliente";
                CmbPesquisa.Items = "Telefone";
                CmbPesquisa.SelectedIndex = 0;

                Clear();
                StartTheme();

                TabMainMaterial.SelectedTab = TabPesquisaMaterial;
                TabMainMaterial.SelectedTab = TabCadastroMaterial;

                GetFichas();
                Sugestion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Sugestion()
        {
            if (File.Exists("LIST_APARELHOS.CF") && File.Exists("LIST_MARCAS.CF") && File.Exists("LIST_MODELOS.CF") && File.Exists("LIST_ACESSORIOS.CF") && File.Exists("LIST_DEFEITOS.CF"))
            {
                TxtAparelho.AutoCompleteCustomSource = Autocomplete.LerArquivo("LIST_APARELHOS.CF");
                TxtMarca.AutoCompleteCustomSource = Autocomplete.LerArquivo("LIST_MARCAS.CF");
                TxtModelo.AutoCompleteCustomSource = Autocomplete.LerArquivo("LIST_MODELOS.CF");
                TxtAcessorios.AutoCompleteCustomSource = Autocomplete.LerArquivo("LIST_ACESSORIOS.CF");
                TxtEstado.AutoCompleteCustomSource = Autocomplete.LerArquivo("LIST_DEFEITOS.CF");
            }
            else
            {
                TxtAparelho.AutoCompleteCustomSource = Autocomplete.LerArquivo("LIST_APARELHOS.CF");
                TxtMarca.AutoCompleteCustomSource = Autocomplete.LerArquivo("LIST_MARCAS.CF");
                TxtModelo.AutoCompleteCustomSource = Autocomplete.LerArquivo("LIST_MODELOS.CF");
                TxtAcessorios.AutoCompleteCustomSource = Autocomplete.LerArquivo("LIST_ACESSORIOS.CF");
                TxtEstado.AutoCompleteCustomSource = Autocomplete.LerArquivo("LIST_DEFEITOS.CF");

                MessageBox.Show("Configuração inicial feita, clique ok para reiniciar", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
        }


        /// <summary>
        /// metodo que adiciona valores aos atributos da classe de model Ficha
        /// </summary>
        /// <returns>retorna valores preenchidos da classe</returns>
        private Ficha GetForm()
        {
            System.Globalization.CultureInfo cultureinfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            Ficha ficha = new Ficha()
            {
                Id = id,
                NroFicha = TxtNumeroFicha.Text,
                DataEntrada = Convert.ToDateTime(DtEntrada.Text.ToString()),
                Cliente = cultureinfo.TextInfo.ToTitleCase(TxtCliente.Text),
                Telefone = TxtTelefone.Text,
                Endereco = cultureinfo.TextInfo.ToTitleCase(TxtEndereco.Text),
                NroEndereco = TxtNumeroEndereco.Text,
                Aparelho = cultureinfo.TextInfo.ToTitleCase(TxtAparelho.Text),
                Marca = cultureinfo.TextInfo.ToTitleCase(TxtMarca.Text),
                Modelo = cultureinfo.TextInfo.ToTitleCase(TxtModelo.Text),
                Acessorios = cultureinfo.TextInfo.ToTitleCase(TxtAcessorios.Text),
                Estado = cultureinfo.TextInfo.ToTitleCase(TxtEstado.Text)
            };
            if (TxtValor.Text.Equals("")) { TxtValor.Text = "0"; } else { ficha.Valor = Convert.ToDecimal(String.Format("{0:C}", TxtValor.Text)); }
            ficha.Aprovado = CmbAprovado.Text;
            if (ficha.Aprovado.Equals("Sim") || ficha.Aprovado.Equals("Não")) { ficha.DataAprovado = DtAprovado.Text; } else { ficha.DataAprovado = ""; }
            ficha.Ok = CmbOk.Text;
            if (ficha.Ok.Equals("Sim")) { ficha.DataOk = DtOk.Text; } else { ficha.DataOk = ""; }
            ficha.Entrega = CmbEntrega.Text;
            if (ficha.Entrega.Equals("Sim")) { ficha.DataEntrega = DtEntrega.Text; } else { ficha.DataEntrega = ""; }
            ficha.Detalhes = TxtDetalhes.Text;
            return ficha;
        }

        /// <summary>
        /// retorna aos campos valores guardados na classe
        /// </summary>
        /// <param name="ficha"></param>
        private void SetForm(Ficha ficha)
        {
            id = ficha.Id;
            TxtNumeroFicha.Text = ficha.NroFicha;
            DtEntrada.Text = ficha.DataEntrada.ToString();
            TxtCliente.Text = ficha.Cliente;
            TxtTelefone.Text = ficha.Telefone;
            TxtEndereco.Text = ficha.Endereco;
            TxtNumeroEndereco.Text = ficha.NroEndereco;
            TxtAparelho.Text = ficha.Aparelho;
            TxtMarca.Text = ficha.Marca;
            TxtModelo.Text = ficha.Modelo;
            TxtAcessorios.Text = ficha.Acessorios;
            TxtEstado.Text = ficha.Estado;
            TxtValor.Text = ficha.Valor.ToString();
            CmbAprovado.Text = ficha.Aprovado;
            DtAprovado.Text = ficha.DataAprovado;
            CmbOk.Text = ficha.Ok;
            DtOk.Text = ficha.DataOk;
            CmbEntrega.Text = ficha.Entrega;
            DtEntrega.Text = ficha.DataEntrega;
            TxtDetalhes.Text = ficha.Detalhes;
        }

        /// <summary>
        /// limpa formulário
        /// </summary>
        private void Clear()
        {
            id = 0;
            TxtNumeroFicha.Text = "";
            DtEntrada.Text = "";
            TxtCliente.Text = "";
            TxtTelefone.Text = "";
            TxtEndereco.Text = "";
            TxtNumeroEndereco.Text = "";
            TxtAparelho.Text = "";
            TxtMarca.Text = "";
            TxtModelo.Text = "";
            TxtAcessorios.Text = "Não";
            TxtEstado.Text = "";
            TxtValor.Text = "";
            CmbAprovado.SelectedIndex = 0;
            DtAprovado.Text = "";
            CmbOk.SelectedIndex = 0;
            DtOk.Text = "";
            CmbEntrega.SelectedIndex = 0;
            DtEntrega.Text = "";
            TxtDetalhes.Text = "";


            BtnAlterar.Visible = false;
            BtnExcluir.Visible = false;
            BtnCadastrar.Visible = true;
            BtnAdmin.Visible = false;
            BtnImprimir.Visible = false;
            TxtNumeroFicha.EnableTextField(true);
            TxtCliente.EnableTextField(true);
            DtEntrada.Enabled = true;
            TxtAparelho.EnableTextField(true);
            LblTexto.Text = "Cadastro de Nova Ficha";
            BtnAdmin.Icon = Resources._lock;
            BtnAdmin.Enabled = true;

            TxtNumeroFicha.Focus();
        }

        /// <summary>
        /// traz uma tabela do banco para datagrid e organiza o que vai exibir
        /// </summary>
        private void GetFichas()
        {
            try
            {
                DgViewConsultar.Columns.Clear();
                Ficha ficha = new Ficha();
                if (CmbPesquisa.Text.Equals("Cliente"))
                {
                    ficha.Cliente = TxtConsultar.Text;
                    DgViewConsultar.DataSource = service.findCliente(ficha);
                }
                else if (CmbPesquisa.Text.Equals("Número"))
                {
                    ficha.NroFicha = TxtConsultar.Text;
                    DgViewConsultar.DataSource = service.findNumero(ficha);
                }
                else if (CmbPesquisa.Text.Equals("Telefone"))
                {
                    ficha.Telefone = TxtConsultar.Text;
                    DgViewConsultar.DataSource = service.findTelefone(ficha);
                }
                FormatCells();

                if (DgViewConsultar.Rows.Count > 0)
                {
                    DgViewConsultar.Visible = true;
                    LblDgMessage.Text = "";
                    LblDgMessage.Visible = false;
                }
                else
                {
                    DgViewConsultar.Visible = false;
                    LblDgMessage.Text = "Nenhum " + CmbPesquisa.Text.ToLower() + " '" + TxtConsultar.Text.ToLower() + "' encontrado.";
                    LblDgMessage.Visible = true;
                }

            }
            catch (BusinessException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void FormatCells()
        {

            DataGridViewImageColumn img = new DataGridViewImageColumn()
            {
                ImageLayout = DataGridViewImageCellLayout.Normal
            };
            object O = Resources.ResourceManager.GetObject("pencil");
            Image image = (Image)O;
            img.Image = image;
            DgViewConsultar.Columns.Add(img);
            img.HeaderText = "Opções";
            img.Name = "img";

            for (int i = 0; i < DgViewConsultar.RowCount; i++)
            {
                DgViewConsultar.Rows[i].Height = 40;
            }

            foreach (DataGridViewColumn column in DgViewConsultar.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            DgViewConsultar.EnableHeadersVisualStyles = false;
            DgViewConsultar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgViewConsultar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DgViewConsultar.ColumnHeadersHeight = 40;

            DataGridViewCellStyle style = DgViewConsultar.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.White;
            style.ForeColor = Color.Gray;

            DgViewConsultar.Columns[0].Visible = false;
            //DgViewConsultar.Columns[1].Visible = false;
            //DgViewConsultar.Columns[2].Visible = false;
            //DgViewAltera.Columns[3].Visible = false;
            //DgViewAltera.Columns[4].Visible = false;
            DgViewConsultar.Columns[5].Visible = false;
            DgViewConsultar.Columns[6].Visible = false;
            //DgViewAltera.Columns[7].Visible = false;
            //DgViewAltera.Columns[8].Visible = false;
            DgViewConsultar.Columns[9].Visible = false;
            DgViewConsultar.Columns[10].Visible = false;
            DgViewConsultar.Columns[11].Visible = false;
            //DgViewConsultar.Columns[12].Visible = false;
            DgViewConsultar.Columns[13].Visible = false;
            DgViewConsultar.Columns[14].Visible = false;
            DgViewConsultar.Columns[15].Visible = false;
            DgViewConsultar.Columns[16].Visible = false;
            //DgViewConsultar.Columns[17].Visible = false;
            DgViewConsultar.Columns[18].Visible = false;
            DgViewConsultar.Columns[19].Visible = false;
            //DgViewAltera.Columns[20].Visible = false;


            DgViewConsultar.Columns[1].Width = 88;
            DgViewConsultar.Columns[2].Width = 68;
            DgViewConsultar.Columns[3].Width = 150;
            DgViewConsultar.Columns[4].Width = 98;
            DgViewConsultar.Columns[7].Width = 130;
            DgViewConsultar.Columns[8].Width = 100;
            DgViewConsultar.Columns[12].Width = 60;
            DgViewConsultar.Columns[17].Width = 60;
            DgViewConsultar.Columns[20].Width = 60;

            try
            {
                if (DgViewConsultar.Rows.Count > 0)
                {
                    DgViewConsultar.Rows[0].Selected = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void StartTheme(object sender, EventArgs e)
        {
            StartTheme();
        }

        private void StartTheme()
        {
            TxtNumeroFicha.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtCliente.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtTelefone.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtEndereco.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtNumeroEndereco.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtAparelho.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtMarca.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtModelo.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtAcessorios.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtEstado.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtValor.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            CmbAprovado.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            CmbOk.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            CmbEntrega.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtConsultar.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            CmbPesquisa.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            TxtDetalhes.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            DtAprovado.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            DtOk.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            DtEntrega.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
            DtEntrada.LineColor = Color.FromArgb(MaterialSchemeColor.red, MaterialSchemeColor.green, MaterialSchemeColor.blue);
        }


        /// <summary>
        /// transição de uma tab para tab cadastro
        /// </summary>
        public void DoAlterTable()
        {
            TabMainMaterial.SelectedTab = TabCadastroMaterial;
            TxtValor.Focus();
        }


        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            StartTheme();
            try
            {
                if (string.IsNullOrEmpty(TxtNumeroFicha.Text) && TxtNumeroFicha.Text.Length < 2) // propriedade IsNullOrEmpty não permite que a textbox receba um valor nulo ou que o mesmo fique vazio.
                {
                    MessageBox.Show("Informe o Número da ficha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtNumeroFicha.LineColor = Color.Red;
                    TxtNumeroFicha.Focus();
                }
                else if (string.IsNullOrEmpty(TxtCliente.Text) && TxtCliente.Text.Length < 3) // propriedade IsNullOrEmpty não permite que a textbox receba um valor nulo ou que o mesmo fique vazio.
                {
                    MessageBox.Show("Informe o Nome do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtCliente.LineColor = Color.Red;
                    TxtCliente.Focus();
                }
                else if (string.IsNullOrEmpty(TxtAparelho.Text) && TxtAparelho.Text.Length < 3) // propriedade IsNullOrEmpty não permite que a textbox receba um valor nulo ou que o mesmo fique vazio.
                {
                    MessageBox.Show("Informe o Aparelho!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtAparelho.LineColor = Color.Red;
                    TxtAparelho.Focus();
                }
                else
                {
                    Ficha ficha = GetForm();
                    service.insert(ficha);
                    MessageBox.Show("Ficha cadastrada com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    GetFichas();
                }
            }
            catch (BusinessException ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult resp;
                resp = MessageBox.Show("Deseja editar o registro selecionado ? ", "Atenção ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resp == DialogResult.Yes)
                {
                    Ficha ficha = GetForm();
                    service.insert(ficha);
                    GetFichas();
                    Clear();
                    MessageBox.Show("Registro Alterado com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (BusinessException ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (FormatException) //catch trata campo txtValor
            {
                MessageBox.Show("Digite valor correto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtValor.Focus();
            }
        }


        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resp;
                resp = MessageBox.Show("Deseja excluir o registro selecionado ? ", "Atenção ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resp == DialogResult.Yes)
                {
                    Ficha ficha = GetForm();
                    service.remove(ficha);
                    GetFichas();
                    MessageBox.Show("Registro excluido com sucesso.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            catch (BusinessException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            FrmSenha fr = new FrmSenha();
            fr.ShowDialog();
            if (fr.Senha().Equals(ConfigurationManager.AppSettings["pass"].ToString()))
            {
                BtnExcluir.Visible = true;
                TxtNumeroFicha.EnableTextField(true);
                TxtCliente.EnableTextField(true);
                DtEntrada.Enabled = true;
                TxtAparelho.EnableTextField(true);
                BtnAdmin.Icon = Resources.lockopen;
                BtnAdmin.Enabled = false;
            }

        }


        private void BtnThemeMaterial_Click(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = MaterialSchemeColor.ChangeColor();
            StartTheme();
            TxtNumeroFicha.Focus();
        }


        private void BtnOpcoes_Click(object sender, EventArgs e)
        {
            FrmSenha fr = new FrmSenha();
            fr.ShowDialog();
            if (fr.Senha().Equals(ConfigurationManager.AppSettings["pass"].ToString()))
            {
                FrmConfig cf = new FrmConfig();
                cf.ShowDialog();
                Sugestion();
            }

        }

        private void BtnCalculator_Click(object sender, EventArgs e)
        {
            string ProgramName = "calc";
            Process.Start(ProgramName);
        }

        private void BtnLimparPesquisa_Click(object sender, EventArgs e)
        {
            if (TxtConsultar.Text != "")
                TxtConsultar.Text = "";

            TxtConsultar.Focus();
        }


        private void CmbAprovado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbAprovado.Text.Equals("Sim") || CmbAprovado.Text.Equals("Não")) //verificação para ativar DtAprovado  no Formulário
            {
                DtAprovado.Visible = true;
            }
            else
            {
                DtAprovado.Visible = false;
            }
        }

        private void CmbOk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbOk.Text.Equals("Sim"))    //verificação para ativar DtOk  no Formulário
            {
                DtOk.Visible = true;
            }
            else
            {
                DtOk.Visible = false;
            }
            if (CmbOk.Text.Equals("Sem Defeito") && (TxtDetalhes.Text == "" || TxtDetalhes.Text == "Devolução"))    //verificação para ativar DtOk  no Formulário
            {
                TxtDetalhes.Text = "O aparelho não apresentou defeito";
            }
            else if (CmbOk.Text.Equals("Devolução") && (TxtDetalhes.Text == "" || TxtDetalhes.Text == "O aparelho não apresentou defeito"))    //verificação para ativar DtOk  no Formulário
            {
                TxtDetalhes.Text = "Devolução";
            }
        }

        private void CmbEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CmbEntrega.Text.Equals("Sim"))   //verificação para ativar DtEntrega no Formulário 
            {
                DtEntrega.Visible = true;
            }
            else
            {
                DtEntrega.Visible = false;
            }
        }


        /// <summary>
        /// evento de duplo clique no datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgViewConsultar_DoubleClick(object sender, EventArgs e)
        {
            DoAlterTable();
        }

        private void IMSAlterarFicha_Click(object sender, EventArgs e)
        {
            DoAlterTable();
        }

        /// <summary>
        /// evento de clique no datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgViewConsultar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgViewConsultar.Columns[e.ColumnIndex].Name == "img" && e.RowIndex != -1)
                {
                    MSDataGrid.Show(Cursor.Position);
                }
                if (DgViewConsultar.CurrentRow != null)
                {

                    Ficha ficha = new Ficha()
                    {
                        Id = Convert.ToInt16(DgViewConsultar.CurrentRow.Cells[0].Value),
                        DataEntrada = Convert.ToDateTime(DgViewConsultar.CurrentRow.Cells[1].Value.ToString()),
                        NroFicha = DgViewConsultar.CurrentRow.Cells[2].Value.ToString(),
                        Cliente = DgViewConsultar.CurrentRow.Cells[3].Value.ToString(),
                        Telefone = DgViewConsultar.CurrentRow.Cells[4].Value.ToString(),
                        Endereco = DgViewConsultar.CurrentRow.Cells[5].Value.ToString(),
                        NroEndereco = DgViewConsultar.CurrentRow.Cells[6].Value.ToString(),
                        Aparelho = DgViewConsultar.CurrentRow.Cells[7].Value.ToString(),
                        Marca = DgViewConsultar.CurrentRow.Cells[8].Value.ToString(),
                        Modelo = DgViewConsultar.CurrentRow.Cells[9].Value.ToString(),
                        Acessorios = DgViewConsultar.CurrentRow.Cells[10].Value.ToString(),
                        Estado = DgViewConsultar.CurrentRow.Cells[11].Value.ToString(),
                        Valor = Convert.ToDecimal(DgViewConsultar.CurrentRow.Cells[12].Value.ToString()),
                        Aprovado = DgViewConsultar.CurrentRow.Cells[13].Value.ToString(),
                        DataAprovado = DgViewConsultar.CurrentRow.Cells[14].Value.ToString(),
                        Ok = DgViewConsultar.CurrentRow.Cells[15].Value.ToString(),
                        DataOk = DgViewConsultar.CurrentRow.Cells[16].Value.ToString(),
                        Entrega = DgViewConsultar.CurrentRow.Cells[17].Value.ToString(),
                        DataEntrega = DgViewConsultar.CurrentRow.Cells[18].Value.ToString(),
                        Detalhes = DgViewConsultar.CurrentRow.Cells[19].Value.ToString()
                    };

                    SetForm(ficha);

                    BtnImprimir.Visible = true;
                    BtnAlterar.Visible = true;
                    BtnExcluir.Enabled = true;
                    BtnCadastrar.Visible = false;
                    BtnAdmin.Visible = true;
                    BtnExcluir.Visible = false;
                    TxtNumeroFicha.EnableTextField(false);
                    TxtCliente.EnableTextField(false);
                    DtEntrada.Enabled = false;
                    TxtAparelho.EnableTextField(false);
                    BtnAdmin.Icon = Resources._lock;
                    BtnAdmin.Enabled = true;
                    LblTexto.Text = "Alterar a ficha nº " + ficha.NroFicha;
                }


            }
            catch (Exception)
            {
                TxtConsultar.Focus();
            }
        }


        private void DgViewConsultar_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    for (int i = 1; i < DgViewConsultar.ColumnCount; i++)
                    {
                        DgViewConsultar.Rows[e.RowIndex].Cells[i].Style.BackColor = Color.FromArgb(235, 235, 235);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void DgViewConsultar_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    for (int i = 0; i < DgViewConsultar.ColumnCount; i++)
                    {
                        DgViewConsultar.Rows[e.RowIndex].Cells[i].Style.BackColor = Color.White;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CmbPesquisa_DropDownClosed(object sender, EventArgs e)
        {
            GetFichas();
        }




        /// <summary>
        /// evento txtconsultar para fazer pesquisa dinamica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtConsultar_TextChangedd(object sender, EventArgs e)
        {
            if (TxtConsultar.Text == "")
                BtnLimparPesquisa.Icon = Resources.magnify;
            else
                BtnLimparPesquisa.Icon = Resources.close;

            GetFichas();
        }



        private void IMSVisualizarFicha_Click(object sender, EventArgs e)
        {
            FichaPDF fichapdf = new FichaPDF();
            Ficha ficha = GetForm();
            bool gerou = fichapdf.Save(ficha);
            if (gerou)
            {
                FrmVisualizar vs = new FrmVisualizar();
                vs.Show();
            }

        }


        private void FrmFichasCadastrar_KeyUp(object sender, KeyEventArgs e)
        {
            Control ctl;
            ctl = (Control)sender;
            if (e.KeyCode == Keys.BrowserForward)
            {
                ctl.SelectNextControl(ActiveControl, true, true, true, true);
            }
            else if (e.KeyCode == Keys.BrowserBack)
            {
                ctl.SelectNextControl(ActiveControl, false, true, true, true);
            }

        }


    }

}




//private void Button1_Click(object sender, EventArgs e)
//{
//    DataTable dataTable = new DataTable();
//    Ficha f = new Ficha();
//    List<Ficha> fc = new List<Ficha>();

//    f.Cliente = "juarez";
//    f.NroFicha = "123";

//    fc.Add(f);
//    fc.Add(f);

//    dataTable = service.findCliente(f);
//    string v = dataTable.Rows.Count.ToString();
//    //MessageBox.Show(dataTable.Rows[0]["cliente"].ToString());

//    foreach (var i in fc)
//    {
//        MessageBox.Show(i.NroFicha);
//    }


//}


//try
//{
//    string processFilename = Microsoft.Win32.Registry.LocalMachine
//    .OpenSubKey("Software")
//    .OpenSubKey("Microsoft")
//    .OpenSubKey("Windows")
//    .OpenSubKey("CurrentVersion")
//    .OpenSubKey("App Paths")
//    .OpenSubKey("AcroRd32.exe")
//    .GetValue(String.Empty).ToString();

//    ProcessStartInfo info = new ProcessStartInfo();
//    info.Verb = "print";
//    info.FileName = processFilename;
//    info.Arguments = String.Format("/p /h {0}", "output.pdf");
//    info.CreateNoWindow = true;
//    info.WindowStyle = ProcessWindowStyle.Hidden;
//    //(It won't be hidden anyway... thanks Adobe!)
//    info.UseShellExecute = false;

//    Process p = Process.Start(info);
//    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
//}
//catch (Exception)
//{             
//    MessageBox.Show("Adobe não está instalado");
//}