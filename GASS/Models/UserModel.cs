using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GASS.Models
{
    [Table("userinfomodel")]
    public class UserModel
    {
        [Key]
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public UserModel(string firstname, string lastname, string username, string email, string password, string role)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.username = username;
            this.email = email;
            this.password = password;
            this.role = role;
        }
    }
}
