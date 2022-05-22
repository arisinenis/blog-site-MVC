using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Models
{
    public class TopicAndArticleVM
    {
        public TopicAndArticleVM()
        {
            Article = new HashSet<Article>();
        }
        public Topic Topic { get; set; }
        public IEnumerable<Article> Article { get; set; }
    }
}
