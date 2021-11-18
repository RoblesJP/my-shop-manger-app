using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.GraphQL.Payloads
{
    public class DeleteMercaderiaPayload
    {
        public DeleteMercaderiaPayload(Mercaderia mercaderia)
        {
            Mercaderia = mercaderia;
        }

        public Mercaderia Mercaderia { get; }
    }
}
