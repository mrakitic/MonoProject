using Project.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service
{
    public interface IVehicleAsset
    {
        IEnumerable<VehicleMake> GetAllVehicleMake();
        IEnumerable<VehicleModel> GetAllVehicleModels();
        
        VehicleMake GetVehicleMakeById(Guid Id);
        VehicleModel GetVehicleModelById(Guid Id);
        VehicleMake GetVehicleMakeByName(string name);
        VehicleModel GetVehicleModelByName(string name);
        void AddVehicleMake(VehicleMake newVehicle);
        void AddVehicleModel(VehicleModel newModel);

        string GetAbrv(string abrv);
    }
}
