﻿using Core.Concrete;
using DataAccess.Abstract;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class TopicRepository : BaseRepository<Topic>, ITopicRepository
    {
        private readonly AppDbContext db;
        public TopicRepository(AppDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
