using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Bolsa
    {
        [Key]
        [Column("id_bolsa")]
        public int IdBolsa { get; set; }

        [Required]
        [Column("id_mercaderia")]
        public int IdMercaderia { get; set; }

        [Required]
        [Column("peso_kg")]
        public double PesoKg { get; set; }

        [Required]
        [Column("precio_venta")]
        public int? PrecioVenta { get; set; }

        [Column("precio_compra")]
        public int? PrecioCompra { get; set; }
    }
}
