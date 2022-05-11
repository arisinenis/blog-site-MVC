using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult StandardFormat()
        {
            return View();
        }
        public IActionResult UserStandardFormat()
        {
            return View();
        }

        public IActionResult WriteArticle()
        {
            return View();
        }
    }
}
