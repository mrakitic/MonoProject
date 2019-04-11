using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Service.Models;
using Project.Service.Data;
using Microsoft.EntityFrameworkCore;

namespace Project.Service
{
    public class VehicleService : IVehicleAsset
    {
        private CarContext _context;

        public VehicleService(CarContext context)
        {
            _context = context;
        }

        public void AddVehicleMake(VehicleMake newVehicle)
        {
            _context.Add(newVehicle);
            _context.SaveChanges();
        }

        public void AddVehicleModel(VehicleModel newModel)
        {
            _context.Add(newModel);
            _context.SaveChanges();
        }

        public VehicleMake GetAbrv(string abrv)
        {
            return _context.VehicleMakes.FirstOrDefault(asset => asset.Abrv == abrv);
        }

        public IEnumerable<VehicleMake> GetAllVehicleMake()
        {
            return _context.VehicleMakes
                .Include(asset => asset.Name)
                .Include(asset => asset.Abrv);
        }

        public IEnumerable<VehicleModel> GetAllVehicleModels()
        {
            return _context.VehicleModels
                .Include(asset => asset.Name);
        }

        public VehicleMake GetVehicleMakeById(Guid Id)
        {
            return _context.VehicleMakes
               .Include(asset => asset.Name)
               .Include(asset => asset.Abrv)
               .FirstOrDefault(asset => asset.Id == Id);
        }

        public VehicleMake GetVehicleMakeByName(string name)
        {
            return _context.VehicleMakes.FirstOrDefault(asset => asset.Name == name);
        }

        public VehicleModel GetVehicleModelById(Guid Id)
        {
            return _context.VehicleModels
               .Include(asset => asset.Name)
               .Include(asset => asset.Abrv)
               .FirstOrDefault(asset => asset.Id == Id);
        }

        public VehicleModel GetVehicleModelByName(string name)
        {
            return _context.VehicleModels.FirstOrDefault(asset => asset.Name == name);
        }
    }
}
