using AutoMapper;
using BlogSiteMVC.Models;
using Business.Abstract;
using Core.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper mapper;

        private readonly IArticleService articleService;
        private readonly IUserInformationService userInformationService;
        private readonly ITopicService topicService;

        public HomeController(ILogger<HomeController> logger, IArticleService articleService, IUserInformationService userInformationService, ITopicService topicService, IMapper mapper)
        {
            _logger = logger;
            this.mapper = mapper;

            this.articleService = articleService;
            this.userInformationService = userInformationService;
            this.topicService = topicService;
        }

        public IActionResult Index()
        {
            ArticleShowMainPageVM articleShowMainPageVM = new ArticleShowMainPageVM();
            Article article = mapper.Map<Article>(articleShowMainPageVM);

            articleShowMainPageVM.Articles = articleService.GetArticlesIncludeTopics();

            return View(articleShowMainPageVM);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
