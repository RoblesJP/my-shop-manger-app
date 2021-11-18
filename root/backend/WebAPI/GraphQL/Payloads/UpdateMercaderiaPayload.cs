using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.GraphQL.Payloads
{
    public class UpdateMercaderiaPayload
    {
        public UpdateMercaderiaPayload(Mercaderia mercaderia)
        {
            Mercaderia = mercaderia;
        }

        public Mercaderia Mercaderia { get; }
    }
}
