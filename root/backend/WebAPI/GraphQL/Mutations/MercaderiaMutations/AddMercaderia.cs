using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.GraphQL.Inputs;
using WebAPI.GraphQL.Payloads;
using WebAPI.Models;

namespace WebAPI.GraphQL.Mutations
{
    public partial class Mutations
    {
        public async Task<MercaderiaPayload> AddMercaderiaAsync([Service] ForrajeriaContext context, AddMercaderiaInput input)
        {
            var mercaderia = new Mercaderia
            {
                Nombre = input.Nombre,
                IdCategoria = input.IdCategoria,
                PrecioPor100gr = input.PrecioPor100gr,
                PrecioPorKg = input.PrecioPorKg
            };

            context.Mercaderia.Add(mercaderia);
            await context.SaveChangesAsync();

            return new MercaderiaPayload(mercaderia);
        }
    }
}
