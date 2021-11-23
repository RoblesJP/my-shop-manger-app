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
    public partial class Mutation
    {
        public async Task<MercaderiaPayload> UpdateMercaderiaAsync([Service] ForrajeriaContext context, UpdateMercaderiaInput input)
        {
            Mercaderia mercaderia = new Mercaderia
            {
                IdMercaderia = input.IdMercaderia,
                Nombre = input.Nombre,
                IdCategoria = input.IdCategoria,
                PrecioPorKg = input.PrecioPorKg,
                PrecioPor100gr = input.PrecioPor100gr
            };

            context.Update(mercaderia);
            await context.SaveChangesAsync();

            return new MercaderiaPayload(mercaderia);
        }
    }
}
