using System;

namespace imobiliaria
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            // Criar um imóvel
            Imovel imovel = new Imovel
            {
                Id = 1,
                Nome = "Casa Estilo Vila Rica",
                Descricao = "Casa com quintal espaçoso",
                Valor = 300000.0,
                NroComodos = 4,
                TipoImovel = "Casa",
                Localidade = "Rural",
                TipoNegocio = "Venda"
            };

            // Exibir informações do imóvel
            Console.WriteLine($"ID: {imovel.Id}");
            Console.WriteLine($"Nome: {imovel.Nome}");
            Console.WriteLine($"Descrição: {imovel.Descricao}");
            Console.WriteLine($"Valor: {imovel.Valor:C}");
            Console.WriteLine($"Número de Cômodos: {imovel.NroComodos}");
            Console.WriteLine($"Tipo de Imóvel: {imovel.TipoImovel}");
            Console.WriteLine($"Localidade: {imovel.Localidade}");
            Console.WriteLine($"Tipo de Negócio: {imovel.TipoNegocio}");
        }
    }

    // Classe para representar um Imóvel
    public class Imovel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int NroComodos { get; set; }
        public string TipoImovel { get; set; }
        public string Localidade { get; set; }
        public string TipoNegocio { get; set; }
    }
}


