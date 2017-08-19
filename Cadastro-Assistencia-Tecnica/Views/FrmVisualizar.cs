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
using iTextSharp.text.pdf;
using iTextSharp.text;

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
            
   
            ////variaveis usadas para definir as configurações da impressão
            //float linhasPorPagina = 0;
            //float yPosicao = 0;
            //int contador = 0;
            //float margemEsquerda = e.MarginBounds.Left;
            //float margemSuperior = e.MarginBounds.Top;
            //string linha = null;
            //Font fonteImpressao = this.RchPrint.Font;
            //SolidBrush mCaneta = new SolidBrush(Color.Black);

            //// Define o numero de linhas por pagina, usando MarginBounds.
            //linhasPorPagina = e.MarginBounds.Height / fonteImpressao.GetHeight(e.Graphics);

            //// Itera sobre a string usando StringReader, imprimindo cada linha
            //while (contador < linhasPorPagina && ((linha = leitor.ReadLine()) != null))
            //{
            //    // calcula a posicao da proxima linha baseada
            //    // na altura da fonte de acordo com o dispositivo de impressão
            //    yPosicao = margemSuperior + (contador * fonteImpressao.GetHeight(e.Graphics));

            //    // desenha a proxima linha no controle RichTextBox
            //    e.Graphics.DrawString(linha, fonteImpressao, mCaneta, margemEsquerda, yPosicao, new StringFormat());
            //    contador++;
            //}
            //// Verifica se existe mais linhas para imprimir
            //if (linha != null)
            //    e.HasMorePages = true;
            //else
            //    e.HasMorePages = false;

            ////libera recursos		
            //mCaneta.Dispose();
        
        }

        private void PrintPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void RchPrint_Click(object sender, EventArgs e)
        {
            //using (Bitmap b = new Bitmap(RchPrint.Width, RchPrint.Height))
            //{
            //    using (Graphics g = Graphics.FromImage(b))
            //    {
            //        g.CopyFromScreen(this.Location, new Point(0, 0), this.Size);
            //    }
            //    Document doc = new Document();
            //    iTextSharp.text.Image i = iTextSharp.text.Image.GetInstance(b, System.Drawing.Imaging.ImageFormat.Bmp);
            //    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@".\output.pdf", FileMode.Create));
            //    doc.SetPageSize(new iTextSharp.text.Rectangle(RchPrint.Size.Width + doc.LeftMargin + doc.RightMargin, RchPrint.Size.Height + doc.TopMargin + doc.BottomMargin));

            //    doc.Open();

            //    doc.Add(i);
            //    doc.Close();
            //}


            //Create a standard .Net FileStream for the file, setting various flags
            using (FileStream fs = new FileStream(@".\output.pdf", FileMode.Create))
            {
                //Create a new PDF document setting the size to A4
                using (Document doc = new Document(PageSize.A4))
                {
                    //Bind the PDF document to the FileStream using an iTextSharp PdfWriter
                    using (PdfWriter w = PdfWriter.GetInstance(doc, fs))
                    {
                        //Open the document for writing
                        doc.Open();

                        //Create a table with two columns
                        PdfPTable t = new PdfPTable(4);

                        //Borders are drawn by the individual cells, not the table itself.
                        //Tell the default cell that we do not want a border drawn
                        t.DefaultCell.Border = 1;

                        //Add four cells. Cells are added starting at the top left of the table working left to right first, then down
                        t.AddCell("R1C1");
                        t.AddCell("R1C2");
                        t.AddCell("R2C1");
                        t.AddCell("R2C2");
                         
                       




                        PdfPTable table = new PdfPTable(4);

                        table.DefaultCell.Border = 0;

                        PdfPCell cell = new PdfPCell(new Phrase("linha 1 , Coluna 1, Coluna 2 e Coluna 3 juntas"));
                        cell.Colspan = 4;
                        cell.Border = 0;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);

                        table.AddCell("linha 2, Coluna 1");
                        table.AddCell("linha 2, Coluna 1");
                        table.AddCell("linha 2, Coluna 1");

                        table.AddCell("linha 3, Coluna 1");
                        cell = new PdfPCell(new Phrase("linha 3, Coluna 2 e Coluna 3 Juntas"));
                        cell.Colspan = 3;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("linha 4, Coluna 1 e Coluna 2"));
                        cell.Colspan = 3;
                        table.AddCell(cell);
                        table.AddCell("linha 4, Coluna 3");





                        doc.Add(table);







                        //Add the table to our document
                        doc.Add(t);

                        //Close our document
                        doc.Close();




  




                    }
                }
            }

            this.Close();
        }
    }


}

