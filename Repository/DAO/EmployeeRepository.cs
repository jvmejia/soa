using Domain;
using Repository.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAO
{
    public class EmployeeRepository
    {
        private readonly ApplicationDBContext _context;
        public EmployeeRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        
        public List<Empleado> GetEmployees()
        {
            return _context.empleados.ToList();
        }

        public int CreateEmployee(Empleado empleado)
        {
            _context.empleados.Add(empleado);
                return _context.SaveChanges();
        }
        public void UpdateEmployee(Empleado empleado)
        {
            _context.empleados.Attach(empleado);
            _context.SaveChanges();
        }
        public void DeleteEmployee(int id)
        {
            var empleado = _context.empleados.SingleOrDefault(e=> e.Id_Persona == id);
            if (empleado!=null)
            {
                _context.empleados.Remove(empleado);
                _context.SaveChanges(); 
            }
        }
        public Empleado FindByIdEmployee(int id)
        {
            return _context.empleados.SingleOrDefault(e => e.Id_Persona == id);
        }

     
    }
}
