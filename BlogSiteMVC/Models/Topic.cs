using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Models
{
    public class Topic : BaseEntity
    {
        public Topic()
        {
            Articles = new HashSet<Article>();
            UserInformations = new HashSet<UserInformation>();
        }
        public string Name { get; set; }

        public ICollection<Article> Articles { get; set; }
        public ICollection<UserInformation> UserInformations { get; set; }
    }
}
