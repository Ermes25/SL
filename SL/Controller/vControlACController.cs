using Microsoft.EntityFrameworkCore;
using SL.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Controller
{
    public interface IvControlACController
    {
        Task<List<vControlAC>> Get();
        Task<decimal> GetSumaCantidad();
        Task<decimal> GetSumaPrecio();
    }
    public class vControlACController : IvControlACController
    {
        private readonly IDbContextFactory<dbContext> db;

        public vControlACController(IDbContextFactory<dbContext> dbContextFactory)
        {
            db = dbContextFactory;
        }
        public async Task<List<vControlAC>> Get()
        {
            using var context = db.CreateDbContext();
            return await context.vControlACs.ToListAsync();
        }
        public async Task<decimal> GetSumaCantidad()
        {
            using var context = db.CreateDbContext();
            return await context.vControlACs
                .Where(a => a.Categoria == "Articulo")  // Filtrar por categoría
                .SumAsync(a => a.TotalCantidad);        // Sumar las cantidades
        }
        public async Task<decimal> GetSumaPrecio()
        {
            using var context = db.CreateDbContext();
            return await context.vControlACs
                .Where(a => a.Categoria == "Articulo")  // Filtra por categoría
                .SumAsync(a => a.TotalPrecio);         // Suma los precios
        }
    }
}