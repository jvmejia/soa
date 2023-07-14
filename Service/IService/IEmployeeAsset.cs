using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    internal interface IEmployeeAsset
    {
        List<ActivoEmpleado> GetActivoEmpleados();
        int CreateEmployeeAsset(ActivoEmpleado activoEmpleado);
        void UpdateEmployeeAsset(ActivoEmpleado activoEmpleado);
        void DeleteEmployeeAsset(ActivoEmpleado activoEmpleado);
        ActivoEmpleado FindByIdEmployeeAsset(int id);
    }
}
