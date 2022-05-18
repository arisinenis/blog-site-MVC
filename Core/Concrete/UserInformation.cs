using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Concrete
{
    public class UserInformation : BaseEntity
    {
        public UserInformation()
        {
            Articles = new HashSet<Article>();
            Topics = new HashSet<Topic>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        [NotMapped]
        public byte[] Picture { get; set; }
        public string Description { get; set; }
        public int UserRegisterId { get; set; }
        public UserRegister UserRegister { get; set; }

        public ICollection<Article> Articles { get; set; }
        public ICollection<Topic> Topics { get; set; }

    }
}
