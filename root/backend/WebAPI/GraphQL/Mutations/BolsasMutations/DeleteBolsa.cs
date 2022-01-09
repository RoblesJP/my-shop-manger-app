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
        public async Task<BolsaPayload> DeleteBolsa([Service] ForrajeriaContext context, DeleteBolsaInput input)
        {
            Bolsa bolsa = context.Bolsas.Find(input.IdBolsa);

            context.Bolsas.Remove(bolsa);
            await context.SaveChangesAsync();

            return new BolsaPayload(bolsa);
        }
    }
}
