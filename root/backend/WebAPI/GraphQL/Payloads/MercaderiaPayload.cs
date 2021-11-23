
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.GraphQL.Payloads
{
    public class MercaderiaPayload
    {
        public Mercaderia Mercaderia { get; }

        public MercaderiaPayload(Mercaderia mercaderia)
        {
            Mercaderia = mercaderia; 
        }

        
    }
}
