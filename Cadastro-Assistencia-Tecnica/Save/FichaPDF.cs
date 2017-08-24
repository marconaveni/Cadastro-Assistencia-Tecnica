using Cadastro_Assistencia_Tecnica.Enums;
using Cadastro_Assistencia_Tecnica.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Assistencia_Tecnica.Save
{
    class FichaPDF
    {
        public PdfPCell GenerateCells(String print, PdfPCell cell, int colspan, int border, AlignEnum Align, float right, float top, float bottom)
        {
            float fixe = 0f;
            bool bold = false;
            return GenerateCells(print, cell, colspan, border, Align, right, top, bottom, fixe, bold);
        }

        public PdfPCell GenerateCells(String print, PdfPCell cell, int colspan, int border, AlignEnum Align, float right, float top, float bottom, float fixe)
        {
            bool bold = false;
            return GenerateCells(print, cell, colspan, border, Align, right, top, bottom, fixe, bold);
        }
        /// <summary>
        /// Customizador de celula
        /// </summary>
        /// <param name="print">"O que vai imprimir na tela"</param>
        /// <param name="cell">instancia Pdfcell</param>
        /// <param name="colspan">numero de celulas a mesclar</param>
        /// <param name="border">borda "0 sem borda" e "1 com borda"</param>
        /// <param name="Align">alinhamento da celula</param>
        /// <param name="top">padding top</param>
        /// <param name="bottom">padding bottom</param>
        /// <returns></returns>
        public PdfPCell GenerateCells(String print, PdfPCell cell, int colspan, int border, AlignEnum Align, float right, float top, float bottom, float fixe, bool bold)
        {

            var FontColour = new BaseColor(35, 31, 32);
            var Roboto = FontFactory.GetFont(FontFactory.HELVETICA, 10, FontColour);
            if (bold)
            {
                Roboto = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, FontColour);
            }

            if (print.Length > 19 && fixe == 1f)
            {
                Roboto = FontFactory.GetFont(FontFactory.HELVETICA, 7, FontColour);
            }

            if (print.Length > 30 && fixe == 1f)
            {
                Roboto = FontFactory.GetFont(FontFactory.HELVETICA, 6, FontColour);
            }

            cell = new PdfPCell(new Phrase(print, Roboto));
            cell.Colspan = colspan;



            if (Align == AlignEnum.center)
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
            else if (Align == AlignEnum.top)
                cell.HorizontalAlignment = Element.ALIGN_TOP;
            else if (Align == AlignEnum.right)
                cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            else if (Align == AlignEnum.bottom)
                cell.HorizontalAlignment = Element.ALIGN_BOTTOM;
            else if (Align == AlignEnum.left)
                cell.HorizontalAlignment = Element.ALIGN_LEFT;

            cell.PaddingRight = right;
            cell.PaddingTop = top;
            cell.PaddingBottom = bottom;

            //cell.FixedHeight = fixe;

            if (border == 0)
                cell.Border = 0;

            return cell;

        }



        public void save(Ficha ficha)
        {
            string valor = "";
            if (ficha.Valor > 0 && ficha.Aprovado != "Não") valor = ficha.Valor.ToString();

            string entrada = ficha.DataEntrada.ToString("dd/MM/yyyy");

            string aprovado = "";
            if (ficha.Aprovado == "Sim") aprovado = ficha.DataAprovado.ToString();
            if (ficha.Aprovado == "Não") aprovado = "Não Aprovou";

            string ok = "";
            if (ficha.Ok == "Sim") ok = ficha.DataOk.ToString();

            string entrega = "";
            if (ficha.Entrega == "Sim") entrega = ficha.DataEntrega.ToString();

            float paddingTopBottom = 5f;
            float paddindright = 4f;
            int border = 0;
            string print;



            //Create a standard .Net FileStream for the file, setting various flags
            using (FileStream fs = new FileStream(@".\output.pdf", FileMode.Create))
            {
                //Create a new PDF document setting the size to A4
                using (Document doc = new Document(PageSize.A4.Rotate()))
                {

                    using (PdfWriter w = PdfWriter.GetInstance(doc, fs))   //Bind the PDF document to the FileStream using an iTextSharp PdfWriter
                    {

                        doc.Open();       //Open the document for writing

                        //string imageURL = @"D:\Documentos\Dropbox\Fotos\Wallpapers\Need for speed\Need For Speed The Run.jpg";
                        //iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(imageURL);
                        ////Resize image depend upon your need
                        //jpg.ScaleAbsoluteWidth(800f);   // ScaleToFit(1222f, 2f);
                        //jpg.ScaleAbsoluteHeight(400f);
                        ////Give space before image
                        //jpg.SpacingBefore = -10f;
                        ////Give some space after the image
                        //jpg.SpacingAfter = -100f;
                        //jpg.SetAbsolutePosition(100f, 100f);
                        //jpg.Alignment = Element.ALIGN_LEFT;

                        //doc.Add(jpg);

                        PdfPTable table = new PdfPTable(4) { WidthPercentage = 39, RunDirection = PdfWriter.RUN_DIRECTION_LTR, ExtendLastRow = false };

                        float[] widths = new float[] { 25f, 40f, 25f, 40f };
                        table.SetWidths(widths);


                        PdfPCell cell = new PdfPCell();

                        print = "ASSISTÊNCIA TÉCNICA SANTOS";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 0f, 6f, 0f, true));

                        print = "Ferro Elétrico, Liquidificador, Aspirador de pó, Secador, Batedeira,";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 2f, 2f));

                        print = "Cafeteira, Ventilador, Chapinha e Ferramentas Elétricas em Geral.";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 2f, 2f));

                        print = "TV, Som e Microondas.";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 2f, 2f));

                        print = "Orçamento sem Compromisso";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 7f, 7f, 0f, true));

                        print = "Av. Júlio Buono, 1563 – Vila Gustavo";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 2f, 2f, 0f, true));

                        print = "2212-0986";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 2f, 4f, 0f, true));

                        print = "Entrada:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = entrada;
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = "Nº";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom, 0f , true));

                        print = ficha.NroFicha;
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f, true));

                        print = "Cliente:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = ficha.Cliente;
                        table.AddCell(GenerateCells(print, cell, 3, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = "Aparelho:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = ficha.Aparelho;
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom ,1f));

                        print = "Marca";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom));

                        print = ficha.Marca;
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 1f));

                        print = "Modelo";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = ficha.Modelo;
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 1f));

                        print = "Acessórios:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom));

                        print = ficha.Acessorios;
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 1f));

                        print = "Estado:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = ficha.Estado;
                        table.AddCell(GenerateCells(print, cell, 3, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = "Valor RS:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = valor;
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = "Entrega:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom));

                        print = ficha.DataEntrega;
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = "Obs.: Os aparelhos prontos não retirados no prazo de 60 dias";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 8f, 2f));

                        print = "serão vendidos para o pagamento do conserto.";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 2f, 7f));

                        print = "GARANTIA DE 90 DIAS";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 2f, 7f, 0f, true));

                        print = "ASSISTÊNCIA TÉCNICA SANTOS";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 5f, 7f, 0f, true));

                        print = "São Paulo,";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = entrada;
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = "Nº";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom, 0f , true));

                        print = ficha.NroFicha;
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f , true));

                        print = "Cliente";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = ficha.Cliente;
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 1f ));

                        print = "Telefone";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom));

                        print = ficha.Telefone;
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 1f));

                        print = "Endereço:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = ficha.NroEndereco;
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = "Nº";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom));

                        print = ficha.NroEndereco;
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = "Aparelho";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = ficha.Aparelho;
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 1f));

                        print = "Marca:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom));

                        print = ficha.Marca;  //print = "f333333333 3333333333334444444444444444";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 1f));

                        print = "Modelo:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = ficha.Modelo;
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 1f));

                        print = "Acessórios:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom));

                        print = ficha.Acessorios;
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 1f));

                        print = "Defeito";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = ficha.Estado;
                        table.AddCell(GenerateCells(print, cell, 3, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = "Aprovado";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = aprovado;
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = "Valor:R$";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom));

                        print = valor;
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = "Ok:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = ok;
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = "Entrega:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom));

                        print = entrega;
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));

                        print = "Ass:";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom));


                        doc.Add(table);

                        doc.Close();

                    }
                }

            }



        }


    }
}