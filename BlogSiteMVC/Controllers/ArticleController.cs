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
        private readonly IMapper mapper;

        public ArticleController(IArticleService articleService, IMapper mapper)
        {
            this.articleService = articleService;
            this.mapper = mapper;
        }
        public IActionResult StandardFormat()
        {
            return View();
        }
        public IActionResult UserStandardFormat()
        {
            return View();
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
