using Microsoft.AspNetCore.Mvc;
using Project.MVC.Models.Catalog;
using Project.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.MVC.Controllers
{
    public class CarController : Controller
    {
        private IVehicleAsset _assets;

        public CarController(IVehicleAsset assets)
        {
            _assets = assets;
        }

        public IActionResult Index()
        {
            var assetModels = _assets.GetAllVehicleMake();

            var listResult = assetModels
                .Select(result => new AssetMakeModel
                {
                    Id = result.Id,
                    Name = result.Name,
                    Abrv = result.Abrv,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
        });

            var model = new AssetIndexModel()
            {
                Assets = listResult
            };

            return View(model);
        }
    }
}
