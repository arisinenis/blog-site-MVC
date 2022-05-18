using Business.Abstract;
using Core.Concrete;
using DataAccess.Abstract;
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
        private readonly IArticleRepository articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;

        }

        public bool Add(Article entity)
        {
            return articleRepository.Add(entity);
        }

        public bool Delete(Article entity)
        {
            return articleRepository.Delete(entity);
        }

        public IEnumerable<Article> GetAll()
        {
            return articleRepository.GetAll();
        }

        public Article GetArticleIncludeUser(int id)
        {
            return articleRepository.GetArticleIncludeUser(id);
        }

        public Article GetById(int id)
        {
            return articleRepository.GetById(id);
        }

        public bool Update(Article entity)
        {
            return articleRepository.Update(entity);
        }
    }
}
