using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface IEmployee
    {
        List<Empleado> GetEmployees();
        int CreateEmployee(Empleado empleado);
        void UpdateEmployee(Empleado empleado);
        void DeleteEmployee(int id);
        Empleado FindById(int id);
    }
}
