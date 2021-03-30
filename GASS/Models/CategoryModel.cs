using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GASS.Models
{
    [Table("game_category")]
    public class CategoryModel
    {
        [Key]
        public int id { get; set; }
        public string category_name { get; set; }
        public string category_description { get; set; }

        
    }
}
