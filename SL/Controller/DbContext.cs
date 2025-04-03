using Microsoft.EntityFrameworkCore;
using SL.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Controller
{
    public class dbContext : DbContext
    {
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Articulo> Articulos { get; set; }

        public DbSet<vControlAC> vControlACs { get; set; }
        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
