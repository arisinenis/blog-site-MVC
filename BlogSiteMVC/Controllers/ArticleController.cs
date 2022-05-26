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
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;
        private readonly IUserInformationService userInformationService;
        private readonly IMapper mapper;

        public ArticleController(IArticleService articleService, IMapper mapper, IUserInformationService userInformationService)
        {
            this.articleService = articleService;
            this.userInformationService = userInformationService;
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
            return View(articleCreateVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ArticleCreateVM articleCreateVM)
        {
            Article article = mapper.Map<Article>(articleCreateVM);
            article.UserInformationId = 1;
            article.Date = DateTime.Now.Date;

            if (!ModelState.IsValid)
            {
                return View(article);
            }

            articleService.Add(article);
            return RedirectToAction(nameof(Index), nameof(User));
        }
    }
}
