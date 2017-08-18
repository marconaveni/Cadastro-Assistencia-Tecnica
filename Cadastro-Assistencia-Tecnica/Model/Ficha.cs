using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro_Assistencia_Tecnica.Model
{
    /// <summary>
    /// classe de modelo com entrada de atributos cadastro de ficha
    /// </summary>
    class Ficha
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime dataEntrada;

        public DateTime DataEntrada
        {
            get { return dataEntrada; }
            set { dataEntrada = value; }
        }

        private String nroFicha;

        public String NroFicha
        {
            get { return nroFicha; }
            set { nroFicha = value; }
        }

        private String cliente;

        public String Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }


        private String telefone;

        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private String endereco;

        public String Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        private String nroEndereco;

        public String NroEndereco
        {
            get { return nroEndereco; }
            set { nroEndereco = value; }
        }

        private String Aparelho;

        public String Aparelho1
        {
            get { return Aparelho; }
            set { Aparelho = value; }
        }

        private String marca;

        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private String modelo;

        public String Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private String acessorios;

        public String Acessorios
        {
            get { return acessorios; }
            set { acessorios = value; }
        }

        private String estado;

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private Decimal valor;

        public Decimal Valor
        {
            get { return valor; }
            set
            {
                if (value.Equals(""))
                    throw new FormatException("Campo Invalido");
                valor = value;
            }
        }

        private String aprovado;

        public String Aprovado
        {
            get { return aprovado; }
            set { aprovado = value; }
        }

        private String dataAprovado;

        public String DataAprovado
        {
            get { return dataAprovado; }
            set { dataAprovado = value; }
        }

        private String ok;

        public String Ok
        {
            get { return ok; }
            set { ok = value; }
        }

        private String dataOk;

        public String DataOk
        {
            get { return dataOk; }
            set { dataOk = value; }
        }



        private String entrega;

        public String Entrega
        {
            get { return entrega; }
            set { entrega = value; }
        }

        private String dataEntrega;

        public String DataEntrega
        {
            get { return dataEntrega; }
            set { dataEntrega = value; }
        }



        private String detalhes;

        public String Detalhes
        {
            get { return detalhes; }
            set { detalhes = value; }
        }






        public String DoExibir()
        {

            StringBuilder stb = new StringBuilder();
            stb.Append("                                                Assistência Tecnica                    ");
            stb.Append("\n\n\n                     Data:  ");
            stb.Append(DataEntrada);
            stb.Append("     Nº:      ");
            stb.Append(NroFicha);

            stb.Append("\n\n                     Nome:  ");
            stb.Append(Cliente);
            stb.Append("     Telefone:   ");
            stb.Append(Telefone);

            stb.Append("\n\n                     Endereço: ");
            stb.Append(Endereco);
            stb.Append("      Nº: ");
            stb.Append(NroEndereco);

            stb.Append("\n\n                     Aparelho: ");
            stb.Append(Aparelho1);
            stb.Append("      Marca: ");
            stb.Append(Marca);

            stb.Append("\n\n                     Modelo: ");
            stb.Append(Modelo);
            stb.Append("     Acessórios: ");
            stb.Append(Acessorios);

            stb.Append("\n\n                     Estado: ");
            stb.Append(Estado);
            stb.Append("       Valor  ");
            stb.Append(String.Format("{0:C}", Valor));

            stb.Append("\n\n                     ok:    ");
            stb.Append(Ok);
            stb.Append("   ");
            stb.Append(DataOk);

            stb.Append("\n\n                     Data Entrega:  ");
            stb.Append(DataEntrega);

            stb.Append("\n\n\n-------------------------------------------------------------------------------------------------------------------------------\n\n\n");

            stb.Append("                                             Assistência Tecnica                    ");

            stb.Append("\n\n\n\n                     Nome:  ");
            stb.Append(Cliente);
            stb.Append("     Nº:      ");
            stb.Append(NroFicha);

            stb.Append("\n\n                     Aparelho: ");
            stb.Append(Aparelho1);
            stb.Append("      Marca: ");
            stb.Append(Marca);

            stb.Append("\n\n                     Modelo: ");
            stb.Append(Modelo);
            stb.Append("     Acessórios: ");
            stb.Append(Acessorios);

            stb.Append("\n\n                     Estado: ");
            stb.Append(Estado);
            stb.Append("       Valor  ");
            stb.Append(String.Format("{0:C}", Valor));

            stb.Append("\n\n                     Data Entrada:  ");
            stb.Append(DataEntrada);

            stb.Append("\n\n                     Data Entrega:  ");
            stb.Append(DataEntrega);
            stb.Append("\n\n\n\n         ");

            return stb.ToString();

        }



        public string[] ListaAparelhos()
        {
            var data = new[] {  "2 Ferros",
                                "2 Secadores",
                                "2 Chapinhas",
                                "2 Ventiladores",
                                "Aquecedor",
                                "Aspirador",
                                "Batedeira",
                                "Cafeteira",
                                "Centrifuga de Fruta",
                                "Centrifuga de Roupas",
                                "Chapinha",
                                "Churrasqueira elétrica",
                                "Circulador de Ar",
                                "Climatizador",
                                "Enceradeira",
                                "Espremedor",
                                "Faca Elétrica",
                                "Ferro",
                                "Forninho",
                                "Forno",
                                "Fritadeira",
                                "Furadeira",
                                "Grill",
                                "Inalador",
                                "Jarra Elétrica",
                                "Liquidificador",
                                "Luminária",
                                "Master",
                                "Mega Master",
                                "Microondas",
                                "Massageador",
                                "Mix",
                                "Multiprocessador",
                                "Panela Elétrica",
                                "Panificadora",
                                "Pelix",
                                "Prancha",
                                "Radio",
                                "Secador",
                                "Som",
                                "Televisor",
                                "Termocera",
                                "Torradeira",
                                "Umidificador",
                                "Vaporetto",
                                "Ventilador",
                                "Ventilador de Coluna",
                                "Ventilador de Torre",
                                "Ventilador de Teto"
                              };
            return data;
        }

        public string[] ListaMarcas()
        {
            var data = new[] {  "2 Arno",
                                "2 Black & Decker",
                                "2 Electrolux",
                                "2 Taiff",
                                "2 Walita",
                                "AOC",
                                "Arge",
                                "Arno",
                                "Black & Decker",
                                "Black + Decker",
                                "Bluesky",
                                "Bosch",
                                "Brastemp",
                                "Braun",
                                "Brisa",
                                "Britânia",
                                "Cadence",
                                "Carrefour",
                                "CCE",
                                "Conair",
                                "Consul",
                                "Continental",
                                "Cougar",
                                "Dako",
                                "Dellar",
                                "Delta",
                                "Durabrand",
                                "Eco",
                                "Electrolux",
                                "Faet",
                                "Fama",
                                "Fischer",
                                "Fogatti",
                                "Ford",
                                "Formula",
                                "Fun Kitchen",
                                "Gama",
                                "General Eletric",
                                "George Foreman",
                                "GoldStar",
                                "Gradiente",
                                "Hamilton",
                                "Home",
                                "Home Leader",
                                "Huttman",
                                "hyundai",
                                "Inalar",
                                "Industrial",
                                "Karcher",
                                "LG",
                                "Latina",
                                "Layr",
                                "Lizz",
                                "Loren Sid",
                                "Makita",
                                "Mallory",
                                "Mega",
                                "Midea",
                                "Mitsubishi",
                                "Mondial",
                                "Nano",
                                "NKS",
                                "Oster",
                                "Panasonic",
                                "Parlux",
                                "Philco",
                                "Philips",
                                "Philips Walita",
                                "Polti",
                                "Prosdócimo",
                                "Pulmosonic",
                                "Remington",
                                "Revlon",
                                "Samsung",
                                "Sanyo",
                                "Sharp",
                                "Sield",
                                "Singer",
                                "Skymsen",
                                "Sony",
                                "Star Line",
                                "Suggar",
                                "Suzuki",
                                "Taiff",
                                "Tany",
                                "Tatanium",
                                "Toshiba",
                                "Tufão",
                                "Ultra",
                                "Vent Norte",
                                "Venti Delta",
                                "Venti Silva",
                                "Ventisol",
                                "Viva vento",
                                "Walita"
                             };
            return data;
        }

        public string[] ListaModelos()
        {
            var data = new[] { "X500",
                               "Ultragliss",
                               "Liqfaz"
                             };
            return data;
        }

        public string[] ListaAcessorios()
        {
            var data = new[] { "Sim",
                               "Não",
                               "Sem Copo"
                             };
            return data;
        }

        public string[] ListaDefeitos()
        {
            var data = new[] { "Parou",
                               "Não Funciona",
                               "Não Liga"
                             };
            return data;
        }





    }
}
