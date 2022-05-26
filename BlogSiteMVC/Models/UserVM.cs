using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Models
{
    public class UserVM
    {
        public UserRegister UserRegister { get; set; }
        public UserInformation UserInformation { get; set; }
    }
}
