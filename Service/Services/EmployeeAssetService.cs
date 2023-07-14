using Domain;
using Microsoft.Extensions.Logging;
using Repository.DAO;
using Repository.DBContext;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class EmployeeAssetService : IEmployeeAsset
    {
        private readonly ILogger<EmployeeAssetService> _logger;
        private readonly EmployeeAssetRepository employeeAssetRepository;
        public EmployeeAssetService(ILogger<EmployeeAssetService> logger, ApplicationDBContext context)
        {
            _logger = logger;
            employeeAssetRepository = new EmployeeAssetRepository(context);
        }
        public List<ActivoEmpleado> GetEmployeeAsset()
        {
            List<ActivoEmpleado> employeeAssets = new List<ActivoEmpleado>();
            try
            {
                employeeAssets = employeeAssetRepository.GetEmployeeAsset();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }

            return employeeAssets;
        }
        public int CreateEmployeeAsset(ActivoEmpleado activoEmpleado)
        {
            int success = 0;
            try
            {
                success = employeeAssetRepository.CreateEmployeeAsset(activoEmpleado);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return success;
        }
    }
}
