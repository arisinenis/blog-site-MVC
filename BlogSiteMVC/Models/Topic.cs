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
        }
        public string Name { get; set; }
        public int TotalReading { get; set; }
    }
}
