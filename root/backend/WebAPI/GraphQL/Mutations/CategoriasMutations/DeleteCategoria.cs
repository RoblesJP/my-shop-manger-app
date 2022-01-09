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
        public async Task<CategoriaPayload> DeleteCategoriaAsync([Service] ForrajeriaContext context, DeleteCategoriaInput input)
        {
            Categoria categoria = context.Categorias.Find(input.IdCategoria);

            context.Categorias.Remove(categoria);
            await context.SaveChangesAsync();

            return new CategoriaPayload(categoria);
        }
    }
}
