﻿using Business.Abstract;
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
    public class TopicService : ITopicService
    {
        private readonly AppDbContext db;
        TopicRepository _topicRepository;
        public TopicService()
        {
            _topicRepository = new TopicRepository(db);
        }
        public bool Add(Topic entity)
        {
            return _topicRepository.Add(entity);
        }

        public bool Delete(Topic entity)
        {
            return _topicRepository.Delete(entity);
        }

        public IEnumerable<Topic> GetAll()
        {
            return _topicRepository.GetAll();
        }

        public Topic GetById(int id)
        {
            return _topicRepository.GetById(id);
        }

        public bool Update(Topic entity)
        {
            return _topicRepository.Update(entity);
        }
    }
}