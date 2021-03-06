using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IArticleService : IBaseService<Article>
    {
        Article GetArticleIncludeUser(int id);
        IEnumerable<Article> GetArticlesIncludeTopics();
    }
}
