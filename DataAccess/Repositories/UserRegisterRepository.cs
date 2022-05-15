﻿using Core.Concrete;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Repositories
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