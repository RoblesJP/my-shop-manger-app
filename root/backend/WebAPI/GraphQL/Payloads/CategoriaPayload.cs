using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.GraphQL.Payloads
{
    public class CategoriaPayload
    {
        public Categoria Categoria { get; }

        public CategoriaPayload(Categoria categoria)
        {
            Categoria = categoria;
        }
    }
}
