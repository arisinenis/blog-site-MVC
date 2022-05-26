using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Models
{
    public class ArticleShowMainPageVM
    {
        public ArticleShowMainPageVM()
        {
            Articles = new HashSet<Article>();
        }
        public IEnumerable<Article> Articles { get; set; }
    }
}
