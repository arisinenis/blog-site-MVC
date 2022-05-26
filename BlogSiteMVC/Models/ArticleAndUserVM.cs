using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Models
{
    public class ArticleAndUserVM
    {
        public Article Article { get; set; }
        public UserInformation UserInformation { get; set; }
    }
}
