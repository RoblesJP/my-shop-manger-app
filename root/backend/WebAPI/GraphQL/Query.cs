using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.Models;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Data;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.GraphQL
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Mercaderia> GetMercaderia([Service] ForrajeriaContext context)
        {
            return context.Mercaderia;
        }

        public Mercaderia GetMercaderiaById([Service] ForrajeriaContext context, int id)
        {
            return context.Mercaderia.Find(id);
        }

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Categoria> GetCategorias([Service] ForrajeriaContext context)
        {
            return context.Categorias;
        }

        
    }
}
