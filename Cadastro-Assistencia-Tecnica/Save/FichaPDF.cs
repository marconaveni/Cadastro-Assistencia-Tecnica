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
        public void save()
        {
            float paddingTopBottom = 5f;
            float paddindright = 8f;
            int border = 0;




            //Create a standard .Net FileStream for the file, setting various flags
            using (FileStream fs = new FileStream(@".\output.pdf", FileMode.Create))
            {
                //Create a new PDF document setting the size to A4
                using (Document doc = new Document(PageSize.A4.Rotate()))
                {
                    //Bind the PDF document to the FileStream using an iTextSharp PdfWriter
                    using (PdfWriter w = PdfWriter.GetInstance(doc, fs))
                    {
                        //Open the document for writing
                        doc.Open();


                        
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


                        PdfPTable table = new PdfPTable(4) { WidthPercentage = 48, RunDirection = PdfWriter.RUN_DIRECTION_LTR, ExtendLastRow = false };
                        table.DefaultCell.PaddingTop = paddingTopBottom;
                        table.DefaultCell.PaddingBottom = paddingTopBottom;
                        float[] widths = new float[] { 20f, 45f, 26f, 45f };
                        table.SetWidths(widths);

                        var FontColour = new BaseColor(35, 31, 32);
                        var Roboto = FontFactory.GetFont(@"D:\Documentos\Área de Trabalho\Material Beta dev\Cadastro-Assistencia-Tecnica\Cadastro-Assistencia-Tecnica\Resources\Roboto-Regular.ttf", 10, FontColour);


                        PdfPCell cell = new PdfPCell(new Phrase("ASSISTÊNCIA TÉCNICA SANTOS" , Roboto));
                        cell.Colspan = 4;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.PaddingTop = 5f;
                        cell.PaddingBottom = 10f;
                        cell.Border = border;
                        table.AddCell(cell);

                        //cell = new PdfPCell(new Phrase("Ferro Elétrico, Liquidificador, Aspirador de pó, Secador, Batedeira,", Roboto));
                        //cell.Colspan = 4;
                        //cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        //cell.PaddingTop = 2f;
                        //cell.PaddingBottom = 2f;
                        //cell.Border = border;
                        //table.AddCell(cell);
                        table.AddCell(GenerateCells(cell, border));

                        cell = new PdfPCell(new Phrase("Cafeteira, Ventilador, Chapinha e Ferramentas Elétricas em Geral.", Roboto));
                        cell.Colspan = 4;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.PaddingTop = 2f;
                        cell.PaddingBottom = 2f;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("TV, Som e Microondas.", Roboto));
                        cell.Colspan = 4;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.PaddingTop = 2f;
                        cell.PaddingBottom = 2f;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Orçamento sem Compromisso", Roboto));
                        cell.Colspan = 4;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.PaddingTop = 10f;
                        cell.PaddingBottom = 10f;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Av. Júlio Buono, 1563 – Vila Gustavo", Roboto));
                        cell.Colspan = 4;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.PaddingTop = 2f;
                        cell.PaddingBottom = 2f;
                        cell.Border = border;
                        table.AddCell(cell);


                        cell = new PdfPCell(new Phrase("2212-0986", Roboto));
                        cell.Colspan = 4;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.PaddingTop = paddindright;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Entrada:", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("21/08/2017", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Nº:", Roboto));
                        cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        cell.PaddingRight = paddindright;
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("123", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);


                        cell = new PdfPCell(new Phrase("Cliente:", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("João", Roboto));
                        cell.Colspan = 3;
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Aparelho:", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Ferro", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Marca:", Roboto));
                        cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        cell.PaddingRight = paddindright;
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Electrolux", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Modelo:", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("X500", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Acessórios:", Roboto));
                        cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        cell.PaddingRight = paddindright;
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Não", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Estado:", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Não esquenta", Roboto));
                        cell.Colspan = 3;
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Valor R$:", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("35,00", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Entrega:", Roboto));
                        cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        cell.PaddingRight = paddindright;
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("21/08/2017", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);


                        cell = new PdfPCell(new Phrase("Obs.: Os aparelhos prontos não retirados no prazo de 60 dias", Roboto));
                        cell.Colspan = 4;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.PaddingTop = 8f;
                        cell.PaddingBottom = 2f;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("serão vendidos para o pagamento do conserto.", Roboto));
                        cell.Colspan = 4;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.PaddingTop = 2f;
                        cell.PaddingBottom = 10f;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("GARANTIA DE 90 DIAS", Roboto));
                        cell.Colspan = 4;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.PaddingTop = 2f;
                        cell.PaddingBottom = 10f;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("ASSISTÊNCIA TÉCNICA SANTOS", Roboto));
                        cell.Colspan = 4;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.PaddingTop = 5f;
                        cell.PaddingBottom = 10f;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("São Paulo,", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("21/08/2017", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Nº:", Roboto));
                        cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        cell.PaddingRight = paddindright;
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);


                        cell = new PdfPCell(new Phrase("1234", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Cliente:", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("João", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Telefone:", Roboto));
                        cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        cell.PaddingRight = paddindright;
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("12345678 / 22222222", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);


                        cell = new PdfPCell(new Phrase("Endereço:", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Rua 1", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);


                        cell = new PdfPCell(new Phrase("nº", Roboto));
                        cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        cell.PaddingRight = paddindright;
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("travessa 23", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Aparelho:", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Ferro / M.0. / Sec", Roboto));
                        cell.FixedHeight = 1f;
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Marca:", Roboto));
                        cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        cell.PaddingRight = paddindright;
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Electrolux / Brastemp", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Modelo:", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Odi", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Acessórios", Roboto));
                        cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        cell.PaddingRight = paddindright;
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Não", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Defeito", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Não esquenta", Roboto));
                        cell.Colspan = 3;
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Aprovado", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("15/08/2017", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Valor R$", Roboto));
                        cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        cell.PaddingRight = paddindright;
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("40,00", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("ok:", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("21/08/2017", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Entregue:", Roboto));
                        cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        cell.PaddingRight = paddindright;
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("21/08/2017", Roboto));
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Ass:", Roboto));
                        cell.Colspan = 4;
                        cell.PaddingTop = paddingTopBottom;
                        cell.PaddingBottom = paddingTopBottom;
                        cell.Border = border;
                        table.AddCell(cell);


                        //cell = new PdfPCell(new Phrase("linha 3, Coluna 2 e Coluna 3 Juntas"));
                        //cell.Colspan = 3;
                        //table.AddCell(cell);

                        //cell = new PdfPCell(new Phrase("linha 4, Coluna 1 e Coluna 2"));
                        //cell.Colspan = 3;
                        //table.AddCell(cell);
                        //table.AddCell("linha 4, Coluna 3");


                        doc.Add(table);

                        doc.Close();

                    }
                }

            }



        }

        public PdfPCell GenerateCells(PdfPCell cell, int border)
        {
            var FontColour = new BaseColor(35, 31, 32);
            var Roboto = FontFactory.GetFont(@"D:\Documentos\Área de Trabalho\Material Beta dev\Cadastro-Assistencia-Tecnica\Cadastro-Assistencia-Tecnica\Resources\Roboto-Regular.ttf", 10, FontColour);

            cell = new PdfPCell(new Phrase("Ferro Elétrico, Liquidificador, Aspirador de pó, Secador, Batedeira,", Roboto));
            cell.Colspan = 4;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.PaddingTop = 2f;
            cell.PaddingBottom = 2f;
            cell.Border = border;
            return cell;

        }
    }
}