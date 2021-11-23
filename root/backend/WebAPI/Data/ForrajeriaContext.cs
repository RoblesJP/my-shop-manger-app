using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class ForrajeriaContext : DbContext
    {

        public ForrajeriaContext(DbContextOptions<ForrajeriaContext> options) : base(options) { }

        public DbSet<Mercaderia> Mercaderia { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Bolsa> Bolsas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Mercaderia>()
                .HasOne(m => m.Categoria)
                .WithMany()
                .HasForeignKey(m => m.IdCategoria);

            modelBuilder
                .Entity<Mercaderia>()
                .Navigation(t => t.Categoria)
                .UsePropertyAccessMode(PropertyAccessMode.Property);

            modelBuilder
                .Entity<Mercaderia>()
                .OwnsMany(m => m.Bolsas, b =>
                {
                    b.WithOwner().HasForeignKey(b => b.IdMercaderia);
                });
        }
    }
}
