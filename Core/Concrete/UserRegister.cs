using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Concrete
{
    public class UserRegister : BaseEntity
    {
        public string Email { get; set; }
        //public string Password { get; set; }
        public string UserName { get; set; }

        [NotMapped]
        public string UrlInformation { get; set; }

        public UserInformation UserInformation { get; set; }
    }
}
