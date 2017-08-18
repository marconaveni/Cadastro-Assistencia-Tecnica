using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cadastro_Assistencia_Tecnica.Model;
using System.IO;

namespace Cadastro_Assistencia_Tecnica.Views
{
    public partial class FrmVisualizar : Form
    {
 

        public FrmVisualizar(String texto)
        {
            InitializeComponent();
            RchPrint.Text = texto;
        }

        private void FrmVisualizar_Load(object sender, EventArgs e)
        {

        }


        //codigo da impressora


        private StringReader leitor;//atributo para impressora



        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            printFicha.Document = printDocument1;
            string text = this.RchPrint.Text;
            leitor = new StringReader(text);

            if (printFicha.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void BtnVisuImprim_Click(object sender, EventArgs e)
        {
            try
            {
                string text = this.RchPrint.Text;
                leitor = new StringReader(text);
                PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                printPreviewDialog1.Document = this.printDocument1;
                printPreviewDialog1.FormBorderStyle = FormBorderStyle.Fixed3D;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception exp)
            {
                MessageBox.Show(" Erro : " + exp.Message.ToString());
            }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
   
            //variaveis usadas para definir as configurações da impressão
            float linhasPorPagina = 0;
            float yPosicao = 0;
            int contador = 0;
            float margemEsquerda = e.MarginBounds.Left;
            float margemSuperior = e.MarginBounds.Top;
            string linha = null;
            Font fonteImpressao = this.RchPrint.Font;
            SolidBrush mCaneta = new SolidBrush(Color.Black);

            // Define o numero de linhas por pagina, usando MarginBounds.
            linhasPorPagina = e.MarginBounds.Height / fonteImpressao.GetHeight(e.Graphics);

            // Itera sobre a string usando StringReader, imprimindo cada linha
            while (contador < linhasPorPagina && ((linha = leitor.ReadLine()) != null))
            {
                // calcula a posicao da proxima linha baseada
                // na altura da fonte de acordo com o dispositivo de impressão
                yPosicao = margemSuperior + (contador * fonteImpressao.GetHeight(e.Graphics));

                // desenha a proxima linha no controle RichTextBox
                e.Graphics.DrawString(linha, fonteImpressao, mCaneta, margemEsquerda, yPosicao, new StringFormat());
                contador++;
            }
            // Verifica se existe mais linhas para imprimir
            if (linha != null)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;

            //libera recursos		
            mCaneta.Dispose();
        
        }

        private void PrintPreviewDialog1_Load(object sender, EventArgs e)
        {

        }


        
        
    }


}

