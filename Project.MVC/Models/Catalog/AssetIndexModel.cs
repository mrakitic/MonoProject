using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.MVC.Models.Catalog
{
    public class AssetIndexModel
    {
        public IEnumerable<AssetMakeModel> Assets { get; set; }
    }
}
