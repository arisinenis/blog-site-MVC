using BlogSiteMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Repositories.Abstract
{
    interface IArticleRepository : IBaseRepository<Article>
    {
        Article GetArticleIncludeUser(int id);
    }
}
