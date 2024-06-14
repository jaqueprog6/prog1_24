using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace imobiliaria.Models
{
    public class Imovel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int NroComodos { get; set; }
        public TipoImovel TipoImovel { get; set; }
        public Localidade Localidade { get; set; }
        public TipoNegocio TipoNegocio { get; set; }
        public List<Imagem> Imagens { get; set; }

        // Construtor da classe Imovel
        public Imovel(int id, string nome, string descricao, double valor, int nroComodos, TipoImovel tipoImovel, Localidade localidade, TipoNegocio tipoNegocio)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            NroComodos = nroComodos;
            TipoImovel = tipoImovel;
            Localidade = localidade;
            TipoNegocio = tipoNegocio;
            Imagens = new List<Imagem>();  // Inicializa a lista de imagens
        }
    }
}

    

     