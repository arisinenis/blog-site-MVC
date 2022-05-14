using Core.Concrete;
using DataAccess.Abstract;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ArticleRepository : BaseRepository<Article>, IArticleRepository
    {
        private readonly AppDbContext db;
        public ArticleRepository(AppDbContext db) : base(db)
        {
            this.db = db;
        }

        public Article GetArticleIncludeUser(int id)
        {
            return db.Articles.Include(a => a.UserInformation).FirstOrDefault(a => a.Id == id);
        }
    }
}
