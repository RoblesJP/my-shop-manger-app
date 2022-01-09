using HotChocolate;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.GraphQL.Inputs;
using WebAPI.GraphQL.Payloads;
using WebAPI.Models;

namespace WebAPI.GraphQL.Mutations.CategoriasMutations
{
    public partial class Mutations
    {
        public async Task<CategoriaPayload> UpdateCategoria([Service] ForrajeriaContext context, UpdateCategoriaInput input)
        {
            Categoria categoria = new Categoria()
            {
                IdCategoria = input.IdCategoria,
                NombreCategoria = input.NombreCategoria
            };

            context.Categorias.Update(categoria);
            await context.SaveChangesAsync();

            return new CategoriaPayload(categoria);
        }
    }
}
