using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Models
{
    public class UserInformation : BaseEntity
    {
        public UserInformation()
        {
            Articles = new HashSet<Article>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] Picture { get; set; }
        public string Description { get; set; }
        public int UserRegisterId { get; set; }
        public UserRegister UserRegister { get; set; }

        public ICollection<Article> Articles { get; set; }

    }
}
