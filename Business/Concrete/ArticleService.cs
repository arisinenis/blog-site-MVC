using Business.Abstract;
using Core.Concrete;
using DataAccess.Context;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ArticleService : IArticleService
    {
        AppDbContext db;
        ArticleRepository _articleRepository;
        public ArticleService()
        {
            _articleRepository = new ArticleRepository(db);
        }

        public bool Add(Article entity)
        {
            return _articleRepository.Add(entity);
        }

        public bool Delete(Article entity)
        {
            return _articleRepository.Delete(entity);
        }

        public IEnumerable<Article> GetAll()
        {
            return _articleRepository.GetAll();
        }

        public Article GetArticleIncludeUser(int id)
        {
            return _articleRepository.GetArticleIncludeUser(id);
        }

        public Article GetById(int id)
        {
            return _articleRepository.GetById(id);
        }

        public bool Update(Article entity)
        {
            return _articleRepository.Update(entity);
        }
    }
}
