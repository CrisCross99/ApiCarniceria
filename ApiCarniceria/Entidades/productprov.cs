using ApiCarniceria.Entidades;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCarniceria.Entidades
{
    public class productprov
    {
        public int Id { get; set; }

        public string Disatribuidora { get; set; }

        public int precio { get; set; }

        public string genero { get; set; }
    }
}

 
