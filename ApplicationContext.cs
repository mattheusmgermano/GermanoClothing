using GermanoClothing.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GermanoClothing
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Todo cadastro tem um ID(chave primária) e também tem um pedido.
            modelBuilder.Entity<Cadastro>().HasKey( t => t.Id);
            modelBuilder.Entity<Cadastro>().HasOne( t => t.Pedido);

            modelBuilder.Entity<Produto>().HasKey( t => t.Id);

            //Todo pedido tem um ID, muitos itens dentro de um pedido e um cadastro dentro de um pedido.
            modelBuilder.Entity<Pedido>().HasKey( t => t.Id);
            modelBuilder.Entity<Pedido>().HasMany(t => t.Itens).WithOne(t => t.Pedido);
            modelBuilder.Entity<Pedido>().HasOne(t => t.Cadastro).WithOne(t => t.Pedido)
                .HasForeignKey<Cadastro>(t => t.Id)
                .IsRequired();

            //Todo item de pedido tem um ID e encontra-se dentro de um pedido(pertence a ele).
            modelBuilder.Entity<ItemPedido>().HasKey( t => t.Id);
            modelBuilder.Entity<ItemPedido>().HasOne( t => t.Produto);
        }
    }
}
