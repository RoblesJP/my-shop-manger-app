using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Mercaderia
    {
        private string nombre;

        [Key]
        [Column("id_mercaderia")]
        public int IdMercaderia { get; set; }

        [Required]
        public string Nombre { get => nombre; set => nombre = value.ToUpper(); }

        [Required]
        [Column("id_categoria")]
        public int IdCategoria { get; set; }

        [Column("precio_por_100gr")]
        public int?  PrecioPor100gr { get; set; }

        [Column("precio_por_kg")]
        public int? PrecioPorKg { get; set; }

#nullable enable
        public Categoria? Categoria { get; set; }
        public IList<Bolsa>? Bolsas { get; set; }
    }
}
