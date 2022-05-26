using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ITopicRepository : IBaseRepository<Topic>
    {
        Topic GetTopicIncludeArticles(int id);
    }
}
