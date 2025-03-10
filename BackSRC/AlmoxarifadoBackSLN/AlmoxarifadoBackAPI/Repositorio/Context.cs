﻿using AlmoxarifadoBackAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasKey(c=>c.Codigo);
            modelBuilder.Entity<Categoria>().Property(c => c.Codigo).ValueGeneratedOnAdd();
            modelBuilder.Entity<Produto>().HasKey(c => c.Codigo);
            modelBuilder.Entity<Produto>().Property(c => c.Codigo).ValueGeneratedOnAdd();
            modelBuilder.Entity<Fornecedor>().HasKey(c => c.Codigo);
            modelBuilder.Entity<Fornecedor>().Property(c => c.Codigo).ValueGeneratedOnAdd();
        }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Fornecedor> fornecedor { get; set; }
        public object Fornecedor { get; internal set; }
    }
}
