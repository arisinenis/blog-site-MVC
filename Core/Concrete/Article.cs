using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Concrete
{
    public class Article : BaseEntity
    {
        public Article()
        {
            Topics = new HashSet<Topic>();
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; } = DateTime.Now.Date;
        //public int TotalReading { get; set; }
        public double TotalReadingTime { get; set; }

        public int UserInformationId { get; set; }
        public UserInformation UserInformation { get; set; }

        public ICollection<Topic> Topics { get; set; }


    }
}
