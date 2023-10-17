using SistemaGestionEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class SistemaGestionContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<ProductoVendido> ProductoVendido { get; set; }
        public DbSet<Venta> Venta { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
             @"Server=(localdb)\mssqllocaldb;Database=SistemaGestion;Trusted_Connection=True");
        }
    }
}
