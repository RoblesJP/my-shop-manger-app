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
        public async Task<BolsaPayload> AddBolsa([Service] ForrajeriaContext context, AddBolsaInput input)
        {
            Bolsa bolsa = new Bolsa()
            {
                IdMercaderia = input.IdMercaderia,
                PesoKg = input.PesoKg,
                PrecioCompra = input.PrecioCompra,
                PrecioVenta = input.PrecioVenta
            };

            context.Bolsas.Add(bolsa);
            await context.SaveChangesAsync();

            return new BolsaPayload(bolsa);
        }
    }
}
