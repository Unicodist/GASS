using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dbpro1.Models
{
    public class UserRegisterModel
    {
        public string regFName { get; set; }
        public string regLName { get; set; }
        public string regUserName { get; set; }
        public string regPW { get; set; }
        public string regConfirm { get; set; }
        public string regEmail { get; set; }
    }
}
