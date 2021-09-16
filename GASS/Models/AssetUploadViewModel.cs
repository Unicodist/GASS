using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GASS.Models
{
    public class AssetUploadViewModel
    {
        public string title { get; set; }
        public string description { get; set; }
        public float priceTag { get; set; }
        public string tags { get; set; }
        public IFormFile assetFile { get; set; }
    }
}
