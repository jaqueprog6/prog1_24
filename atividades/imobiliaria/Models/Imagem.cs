using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace imobiliaria.Models
{
    public class Imagem
    {
    public int Id { get; set; }
    public string Url { get; set; }

    public Imagem(int id, string url)
    {
        Id = id;
        Url = url;
    }

    }
}

