using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace imobiliaria.Models
{
    public class TipoImovel
    {
        public string Nome { get; set; }

        public TipoImovel(string nome)
    {
        Nome = nome;
    }
   
   }
}