using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IArticleRepository : IBaseRepository<Article>
    {
        Article GetArticleIncludeUser(int id);
        IEnumerable<Article> GetArticlesIncludeTopics();
    }
}
