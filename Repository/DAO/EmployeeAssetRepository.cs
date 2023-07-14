using Domain;
using Repository.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAO
{
    public class EmployeeAssetRepository
    {
        public readonly ApplicationDBContext _context;

        public EmployeeAssetRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public List<ActivoEmpleado> GetEmployeeAsset(int id)
        {
            return _context.activoempleados.ToList();
        }
        public int CreateEmployeeAsset(ActivoEmpleado activoEmpleado)
        {
            _context.activoempleados.Add(activoEmpleado);
            return _context.SaveChanges();
        }
        public void UpdateEmployeeAsset(ActivoEmpleado activoEmpleado)
        {
            _context.activoempleados.Attach(activoEmpleado);
            _context.SaveChanges();
        }
        public void DeleteEmployeeAsset(int id)
        {
            var activoempleado = _context.activoempleados.SingleOrDefault(e => e.IdActivo == id);
            if (activoempleado != null)
            {
                _context.activoempleados.Remove(activoempleado);
                _context.SaveChanges();
            }

        }
        public ActivoEmpleado FindByIdEmployeeAsset(int id)
        {
            return _context.activoempleados.SingleOrDefault(e=> e.Id == id);
        }
    }
}
