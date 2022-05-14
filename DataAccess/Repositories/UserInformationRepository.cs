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
    public class UserInformationRepository : BaseRepository<UserInformation>, IUserInformationRepository
    {
        private readonly AppDbContext db;

        public UserInformationRepository(AppDbContext db) : base(db)
        {
            this.db = db;
        }

        public IEnumerable<UserInformation> GetAllWithArticles()
        {
            return db.UserInformations.Include(a => a.Articles).ToList();
        }

    }
}
