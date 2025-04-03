using Microsoft.EntityFrameworkCore;
using SL.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Controller
{
    public interface IArticuloController
    {
        Task<List<Articulo>> Get();
        Task<int> Insert(Articulo Entidad);
        Task<bool> Update(Articulo Entidad);
        Task<bool> Delete(Articulo Entidad);


    }
    public class ArticuloController : IArticuloController
    {
        readonly IDbContextFactory<dbContext> db;
        public ArticuloController(IDbContextFactory<dbContext> dbContextFactory)
        {
            db = dbContextFactory;
        }
        public async Task<List<Articulo>> Get()
        {
            using var context = db.CreateDbContext();
            return await context.Articulos.Where(a => a.Activo).ToListAsync();
        }
        public async Task<int> Insert(Articulo Entidad)
        {
            using var context = db.CreateDbContext();
            context.Articulos.Add(Entidad);
            Entidad.Activo = true;
            await context.SaveChangesAsync();
            return Entidad.idArticulo;
        }
        public async Task<bool> Update(Articulo Entidad)
        {
            using var context = db.CreateDbContext();
            context.Articulos.Update(Entidad);
            await context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> Delete(Articulo Entidad)
        {
            using var Conexion = db.CreateDbContext();
            var Registro = await Conexion.Articulos.Where(a => a.idArticulo == Entidad.idArticulo).SingleOrDefaultAsync();
            if (Registro != null)
            {
                Registro.Activo = false;
                return await Conexion.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}
