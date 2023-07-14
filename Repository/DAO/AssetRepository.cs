using Domain;
using Microsoft.EntityFrameworkCore.Storage;
using Repository.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAO
{
    public class AssetRepository
    {
        private readonly ApplicationDBContext _context;

        public AssetRepository(ApplicationDBContext context) 
        {
            _context = context;
        }
        public List<Activo> GetAssets()
        {
            return _context.activos.ToList();
        }

        public int CreateAssets(Activo activo)
        {
            _context.activos.Add(activo);
            return _context.SaveChanges();
        }
        public void UpdateAsset(Activo activo)
        {
            _context.activos.Attach(activo);
            _context.SaveChanges();
        }
        public void DeleteAsset(int id)
        {
            var activo = _context.activos.SingleOrDefault(e => e.IdActivo == id);
            if (activo != null)
            {
                _context.activos.Remove(activo);
                _context.SaveChanges();
            }

        }
        public Activo FindByIdAsset(int id)
        {
            return _context.activos.SingleOrDefault(e => e.IdActivo == id);
        }
    }
}
