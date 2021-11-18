using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.GraphQL.Inputs;
using WebAPI.GraphQL.Payloads;
using WebAPI.Models;

namespace WebAPI.GraphQL
{
    public class Mutation
    {
        public async Task<AddMercaderiaPayload> AddMercaderiaAsync ([Service]ForrajeriaContext context, AddMercaderiaInput input)
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

            return new AddMercaderiaPayload(mercaderia);
        }

        public async Task<DeleteMercaderiaPayload> DeleteMercaderiaAsync([Service] ForrajeriaContext context, DeleteMercaderiaInput input)
        {
            var mercaderia = context.Mercaderia.Find(input.Id);

            context.Mercaderia.Remove(mercaderia);
            await context.SaveChangesAsync();

            return new DeleteMercaderiaPayload(mercaderia);
        }

        public async Task<UpdateMercaderiaPayload> UpdateMercaderiaAsync([Service] ForrajeriaContext context, UpdateMercaderiaInput input)
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

            return new UpdateMercaderiaPayload(mercaderia);
        }
    }
}
