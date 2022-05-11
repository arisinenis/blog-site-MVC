using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Category()
        {
            return View();
        }

        public IActionResult UserCategory()
        {
            return View();
        }
    }
}
