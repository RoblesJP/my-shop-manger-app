using HotChocolate;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.GraphQL.Inputs;
using WebAPI.GraphQL.Payloads;
using WebAPI.Models;

namespace WebAPI.GraphQL.Mutations
{
    public partial class Mutations
    {
        public async Task<CategoriaPayload> AddCategoriaAsync([Service] ForrajeriaContext context, AddCategoriaInput input)
        {
            var categoria = new Categoria
            {
                NombreCategoria = input.NombreCategoria
            };

            context.Categorias.Add(categoria);
            await context.SaveChangesAsync();

            return new CategoriaPayload(categoria);
        }
    }
}
