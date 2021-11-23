﻿using HotChocolate;
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
        public async Task<MercaderiaPayload> DeleteMercaderiaAsync([Service] ForrajeriaContext context, DeleteMercaderiaInput input)
        {
            var mercaderia = context.Mercaderia.Find(input.Id);

            context.Mercaderia.Remove(mercaderia);
            await context.SaveChangesAsync();

            return new MercaderiaPayload(mercaderia);
        }
    }
}
