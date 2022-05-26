using Core.Concrete;
using DataAccess.Abstract;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class UserRegisterRepository : BaseRepository<UserRegister>, IUserRegisterRepository
    {
        private readonly AppDbContext db;
        public UserRegisterRepository(AppDbContext db) : base(db)
        {
            this.db = db;
        }

        public UserRegister GetByEmail(string email)
        {
            return db.UserRegisters.Where(u => u.Email == email).FirstOrDefault();
        }

        public UserRegister GetByEmailAndPassword(string email, string password)
        {
            return db.UserRegisters.Where(u => u.Email == email && u.Password == password).FirstOrDefault();
        }
    }
}
