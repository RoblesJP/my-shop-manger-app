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
        [Key]
        [Column("id_mercaderia")]
        public int IdMercaderia { get; set; }

        [Required]
        [Column("nombre")]
        public string Nombre { get; set; }

        [Required]
        [Column("id_categoria")]
        public int IdCategoria { get; set; }

        [Column("precio_por_100gr")]
        public int?  PrecioPor100gr { get; set; }

        [Column("precio_por_kg")]
        public int? PrecioPorKg { get; set; }

#nullable enable
        public Categoria? Categoria { get; set; }
        public ICollection<Bolsa>? Bolsas { get; set; }
    }
}
