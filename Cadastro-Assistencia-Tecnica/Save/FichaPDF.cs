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


            if (print.Length > 24 && fixe == 1f)
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

            cell.FixedHeight = fixe;

            if (border == 0)
                cell.Border = 0;

            return cell;

        }



        public void save()
        {
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

                        //48
                        PdfPTable table = new PdfPTable(4) { WidthPercentage = 48, RunDirection = PdfWriter.RUN_DIRECTION_LTR, ExtendLastRow = false };

                        float[] widths = new float[] { 18f, 45f, 20f, 45f };
                        table.SetWidths(widths);


                        PdfPCell cell = new PdfPCell();

                        print = "ASSISTÊNCIA TÉCNICA SANTOS";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 4f, 4f, 0f, true));
                        print = "Ferro Elétrico, Liquidificador, Aspirador de pó, Secador, Batedeira,";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 2f, 2f, 0f));
                        print = "Cafeteira, Ventilador, Chapinha e Ferramentas Elétricas em Geral.";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 2f, 2f, 0f));
                        print = "TV, Som e Microondas.";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 2f, 2f, 0f));
                        print = "Orçamento sem Compromisso";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 7f, 7f, 0f, true));
                        print = "Av. Júlio Buono, 1563 – Vila Gustavo";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 2f, 2f, 0f, true));
                        print = "2212-0986";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 2f, 2f, 0f, true));
                        print = "Entrada:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "21/08/2017";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Nº";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom, 0f));
                        print = "2123";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Cliente:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "João";
                        table.AddCell(GenerateCells(print, cell, 3, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Aparelho:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Ferro";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Marca";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Electrolux";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Modelo";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "ODI";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Acessórios:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Não";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Estado:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Não Esquenta";
                        table.AddCell(GenerateCells(print, cell, 3, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Valor RS:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "35,00";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Entrega:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom, 0f));
                        print = "21/08/2017";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Obs.: Os aparelhos prontos não retirados no prazo de 60 dias";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 8f, 2f, 0f));
                        print = "serão vendidos para o pagamento do conserto.";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 2f, 7f, 0f));
                        print = "GARANTIA DE 90 DIAS";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 2f, 7f, 0f, true));
                        print = "ASSISTÊNCIA TÉCNICA SANTOS";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.center, 0f, 5f, 7f, 0f, true));
                        print = "São Paulo,";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "21/08/2014";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Nº";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom, 0f));
                        print = "2333";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Cliente";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "João da Silva Sauro Nunes";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Telefone";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom, 0f));
                        print = "12345678 / 987654321";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Endereço:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Rua x";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Nº";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom, 0f));
                        print = "travessa 566";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Aparelho";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Ferro / M.o / secc3333333333333333333333";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 1f));
                        print = "Marca:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom, 0f));
                        print = "f333333333 333333333345";  //print = "f333333333 3333333333334444444444444444";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Modelo:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "ODI";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Acessórios";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Não";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Defeito";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Não Esquenta";
                        table.AddCell(GenerateCells(print, cell, 3, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Aprovado";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "15/08/2017";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Valor:R$";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom, 0f));
                        print = "40,00";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Ok:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "21/08/2014";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Entrega:";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.right, paddindright, paddingTopBottom, paddingTopBottom, 0f));
                        print = "21/08/2017";
                        table.AddCell(GenerateCells(print, cell, 0, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));
                        print = "Ass:";
                        table.AddCell(GenerateCells(print, cell, 4, border, AlignEnum.left, 0f, paddingTopBottom, paddingTopBottom, 0f));


                        doc.Add(table);

                        doc.Close();

                    }
                }

            }



        }


    }
}