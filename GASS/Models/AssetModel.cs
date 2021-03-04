using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GASS.Models
{
    [Table("assets")]
    public class AssetModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int down_count { get; set; }
        public float price { get; set; }
        public float rating { get; set; }
    }
}
