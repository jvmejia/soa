using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    internal interface IAsset
    {
        List<Activo> GetAssets();
        int CreateAsset(Activo activo);
        void UpdateAsset(Activo activo);
        void DeleteAsset(int id);
        Activo FindByIdAsset(int id);
    }
}
