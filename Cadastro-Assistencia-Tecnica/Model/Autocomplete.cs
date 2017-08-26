using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Assistencia_Tecnica.Model
{
    static class Autocomplete
    {
        public static AutoCompleteStringCollection LerArquivo(string archive_name)
        {
            AutoCompleteStringCollection dadosLista = new AutoCompleteStringCollection();

            if (File.Exists(archive_name))
            {
                Stream entrada = File.Open(archive_name, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada, System.Text.Encoding.UTF8);
                string linha = leitor.ReadLine();

                while (linha != null)
                {
                    dadosLista.Add(linha);
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();
            }
            else
            {
                GravarDefaultArquivo(archive_name);
            }
            return dadosLista;
        }


        public static List<string> LerArquivoList(string archive_name)
        {

            List<string> dadosLista = new List<string>();

            if (File.Exists(archive_name))
            {
                Stream entrada = File.Open(archive_name, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada, System.Text.Encoding.UTF8);
                string linha = leitor.ReadLine();

                while (linha != null)
                {
                    dadosLista.Add(linha);
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();
            }

            return dadosLista;
        }

        public static void GravarDefaultArquivo(string archive_name)
        {
            Ficha fc = new Ficha();

            Stream saida = File.Open(archive_name, FileMode.Create);
            StreamWriter escritor = new StreamWriter(saida, System.Text.Encoding.UTF8);
            if (archive_name == "LIST_APARELHOS.CF")
            {
                var data = fc.ListaAparelhos();
                foreach (string item in data)
                {
                    escritor.WriteLine(item);
                }

            }
            else if (archive_name == "LIST_MARCAS.CF")
            {
                var data = fc.ListaMarcas();
                foreach (string item in data)
                {
                    escritor.WriteLine(item);
                }

            }
            else if (archive_name == "LIST_MODELOS.CF")
            {
                
                var data = fc.ListaModelos();
                foreach (string item in data)
                {
                    escritor.WriteLine(item);
                }

            }
            else if (archive_name == "LIST_ACESSORIOS.CF")
            {
                var data = fc.ListaAcessorios();
                foreach (string item in data)
                {
                    escritor.WriteLine(item);
                }
            }
            else if (archive_name == "LIST_DEFEITOS.CF")
            {
                var data = fc.ListaDefeitos();
                foreach (string item in data)
                {
                    escritor.WriteLine(item);
                }
            }
            escritor.Close();
            saida.Close();
        }

        public static void GravarArquivo(string archive_name, List<string> colecao)
        {
            Stream saida = File.Open(archive_name, FileMode.Create);
            StreamWriter escritor = new StreamWriter(saida, System.Text.Encoding.UTF8);

            foreach (var item in colecao)
            {
                escritor.WriteLine(item);
            }

            escritor.Close();
            saida.Close();
        }


    }
}
