using Domain;
using Microsoft.Extensions.Logging;
using Repository.DBContext;
using Repository.DAO;
using Service.IService;
using System;
using System.Collections.Generic;

namespace Service.Service
{
    public class AssetService : IAsset
    {
        private readonly ILogger<AssetService> _logger;
        private readonly AssetRepository _assetRepository;

        public AssetService(ILogger<AssetService> logger, ApplicationDBContext context)
        {
            _logger = logger;
            _assetRepository = new AssetRepository(context);
        }

        public int CreateAsset(Activo activo)
        {
            int success = 0;
            try
            {
                success = _assetRepository.CreateAssets(activo);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return success;
        }

        public List<Activo> GetAssets()
        {
            List<Activo> activos = new List<Activo>();

            try
            {
                activos = _assetRepository.GetAssets();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }

            return activos;
        }

        public void UpdateAsset(Activo activo)
        {
            try
            {
                _assetRepository.UpdateAsset(activo);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
        }

        public void DeleteAsset(int id)
        {
            try
            {
                _assetRepository.DeleteAsset(id);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
        }

        public Activo FindByIdAsset(int id)
        {
            Activo activo = null;

            try
            {
                activo = _assetRepository.FindByIdAsset(id);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }

            return activo;
        }
    }
}
