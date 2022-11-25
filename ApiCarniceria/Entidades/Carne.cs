using ApiCarniceria.Entidades;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCarniceria.Entidades
{
    public class Carne
    {
        public int Id { get; set; }
        public string Carniceria { get; set; }

        public int caducidad { get; set; }
        public virtual List<Carne> Nombre { get; set; }
    }

}
