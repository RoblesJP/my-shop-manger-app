using HotChocolate;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.GraphQL.Inputs;
using WebAPI.GraphQL.Payloads;
using WebAPI.Models;

namespace WebAPI.GraphQL.Mutations.BolsasMutations
{
    public partial class Mutations
    {
        public async Task<BolsaPayload> UpdateBolsa([Service] ForrajeriaContext context, UpdateBolsaInput input)
        {
            Bolsa bolsa = new Bolsa()
            {
                IdBolsa = input.IdBolsa,
                IdMercaderia = input.IdMercaderia,
                PesoKg = input.PesoKg,
                PrecioCompra = input.PrecioCompra,
                PrecioVenta = input.PrecioVenta
            };

            context.Bolsas.Update(bolsa);
            await context.SaveChangesAsync();

            return new BolsaPayload(bolsa);
        }
    }
}
