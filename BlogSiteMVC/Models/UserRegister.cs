﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Models
{
    public class UserRegister : BaseEntity
    {
        public string Email { get; set; }
        //public string Password { get; set; }
        public string UserName { get; set; }
        public string UrlInformation { get; set; }

        public UserInformation UserInformation { get; set; }
    }
}
