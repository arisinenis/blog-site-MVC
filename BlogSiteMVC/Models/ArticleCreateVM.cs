using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Models
{
    public class ArticleCreateVM
    {
        //public ArticleCreateVM()
        //{
        //    Topics = new HashSet<Topic>();
        //}
        public ArticleCreateVM()
        {
            Topics = new HashSet<Topic>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public double TotalReadingTime { get; set; }
        public IEnumerable<Topic> Topics { get; set; }

        //public Article Article { get; set; }
        //public IEnumerable<Topic> Topics { get; set; }

    }
}
