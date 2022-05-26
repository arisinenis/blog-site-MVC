using AutoMapper;
using BlogSiteMVC.Models;
using Business.Abstract;
using Core.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;
        private readonly IUserInformationService userInformationService;
        private readonly ITopicService topicService;
        private readonly IMapper mapper;

        public ArticleController(IArticleService articleService, IMapper mapper, IUserInformationService userInformationService, ITopicService topicService)
        {
            this.articleService = articleService;
            this.userInformationService = userInformationService;
            this.topicService = topicService;
            this.mapper = mapper;
        }

        public IActionResult StandardFormat(int id)
        {
            ArticleAndUserVM articleAndUserVM = new ArticleAndUserVM();
            Article article = mapper.Map<Article>(articleAndUserVM);

            articleAndUserVM.Article = articleService.GetArticleIncludeUser(id);
            UserInformation userInformation = userInformationService.GetById(articleAndUserVM.Article.UserInformationId);
            articleAndUserVM.UserInformation = userInformation;

            return View(articleAndUserVM);
        }

        public IActionResult Create()
        {
            ArticleCreateVM articleCreateVM = new ArticleCreateVM();
            articleCreateVM.Topics = topicService.GetAll();
            return View(articleCreateVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ArticleCreateVM articleCreateVM)
        {
            //Article article = mapper.Map<Article>(articleCreateVM);
            Article article = articleCreateVM.Article;
            article.UserInformationId = Convert.ToInt32(HttpContext.Session.GetString("id"));
            article.Date = DateTime.Now.Date;

            if (!ModelState.IsValid)
            {
                return View(articleCreateVM);
            }

            articleService.Add(article);
            return RedirectToAction(nameof(Index), nameof(User));
        }
    }
}
