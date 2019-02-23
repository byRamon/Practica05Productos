using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Practica05Productos.Models;

namespace Practica05Productos.Data
{
    public class ProductosDbContext : DbContext
    {
        public ProductosDbContext(DbContextOptions<ProductosDbContext> options) : base(options)
        {
        }
        public DbSet<Producto> Productos { get; set; }
    }
}