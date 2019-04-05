using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Models
{
    public class VehicleModel : BaseModel
    {
        
        public Guid MakeId { get; set; }        
        public string Name { get; set; }
        public string Abrv { get; set; }
        public VehicleMake VehicleMake { get; set; }
    }
}
