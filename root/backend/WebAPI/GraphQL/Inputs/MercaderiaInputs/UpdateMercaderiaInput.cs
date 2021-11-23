using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.GraphQL.Inputs
{
    public record UpdateMercaderiaInput
    (
        int IdMercaderia,
        string Nombre,
        int IdCategoria,
        int? PrecioPorKg,
        int? PrecioPor100gr
    );

}
