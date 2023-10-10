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
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<ProductoVendido> ProductosVendidos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
             @"Server=(localdb)\mssqllocaldb;Database=SistemaGestion;Trusted_Connection=True");
        }
    }
}
