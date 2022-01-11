using HotChocolate;
using Microsoft.EntityFrameworkCore;
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
        public async Task<MercaderiaPayload> DeleteMercaderiaAsync([Service] ForrajeriaContext context, DeleteMercaderiaInput input)
        {
            var mercaderia = context.Mercaderia
                                           .Where(m => m.IdMercaderia == input.Id)
                                           .Include("Categoria")
                                           .FirstOrDefault();

            context.Mercaderia.Remove(mercaderia);
            await context.SaveChangesAsync();

            return new MercaderiaPayload(mercaderia);
        }
    }
}
