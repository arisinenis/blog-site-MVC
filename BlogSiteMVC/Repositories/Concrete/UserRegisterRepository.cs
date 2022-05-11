using BlogSiteMVC.Models;
using BlogSiteMVC.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Repositories.Concrete
{
    public class UserRegisterRepository : BaseRepository<UserRegister>
    {
        private readonly AppDbContext db;
        public UserRegisterRepository(AppDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
