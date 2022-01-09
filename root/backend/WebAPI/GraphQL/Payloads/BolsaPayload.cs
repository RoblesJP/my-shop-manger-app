using WebAPI.Models;

namespace WebAPI.GraphQL.Payloads
{
    public class BolsaPayload
    {
        public Bolsa Bolsa { get; set; }

        public BolsaPayload(Bolsa bolsa)
        {
            Bolsa = bolsa;
        }
    }
}
