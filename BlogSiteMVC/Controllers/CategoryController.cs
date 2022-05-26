using AutoMapper;
using BlogSiteMVC.Models;
using Business.Abstract;
using Core.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ITopicService topicService;
        private readonly IMapper mapper;

        public CategoryController(ITopicService topicService, IMapper mapper)
        {
            this.topicService = topicService;
            this.mapper = mapper;
        }

        public IActionResult Category(int id)
        {
            var topic = topicService.GetTopicIncludeArticles(id);

            return View(topic);
        }

    }
}
