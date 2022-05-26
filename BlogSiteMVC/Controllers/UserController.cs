using AutoMapper;
using BlogSiteMVC.Models;
using Business.Abstract;
using Core.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IMapper mapper;
        private readonly IUserInformationService userInformationService;
        private readonly IUserRegisterService userRegisterService;

        public UserController(IMapper mapper, IUserInformationService userInformationService, IUserRegisterService userRegisterService)
        {
            this.mapper = mapper;
            this.userInformationService = userInformationService;
            this.userRegisterService = userRegisterService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View(new UserRegisterVM());
        }

        [HttpPost]
        public IActionResult Login(UserRegisterVM userRegisterVM)
        {
            UserRegister userRegister = userRegisterVM.UserRegister;
            var user = userRegisterService.GetByEmailAndPassword(userRegister.Email, userRegister.Password);

            if (user == null)
            {
                ViewBag.ErrorMessage = "Check your email and/or password";
            }

            HttpContext.Session.SetString("email", user.Email);
            HttpContext.Session.SetString("id", user.Id.ToString());
            var userInformation = userInformationService.GetById(user.Id);
            if (userInformation.PhotoPath != null)
            {
                HttpContext.Session.SetString("photoPath", userInformation.PhotoPath);
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("email");
            return RedirectToAction("Index", "Home");
        }

        public IActionResult SignUp()
        {
            return View(new UserVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignUp(UserVM userVM)
        {
            //UserRegister userReg = mapper.Map<UserRegister>(userVM);
            //UserInformation userInfo = mapper.Map<UserInformation>(userVM);

            UserRegister userReg = userVM.UserRegister;
            UserInformation userInfo = userVM.UserInformation;

            if (!ModelState.IsValid)
            {
                TempData["Message"] = "Please try again!";
                return View(userVM);
            }

            // Business katmanına taşınacak.
            if (userVM.UserInformation.Photo != null)
            {
                string ticks = DateTime.Now.Ticks.ToString();
                var path = Directory.GetCurrentDirectory() + @"\wwwroot\images\" + ticks + Path.GetExtension(userVM.UserInformation.Photo.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    userVM.UserInformation.Photo.CopyTo(stream);
                }
                userVM.UserInformation.PhotoPath = @"\images\" + ticks + Path.GetExtension(userVM.UserInformation.Photo.FileName);
            }

            userRegisterService.Add(userReg);
            UserRegister userRegDb = userRegisterService.GetByEmail(userReg.Email);
            userInfo.UserRegisterId = userRegDb.Id;
            userInformationService.Add(userInfo);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Setting()
        {
            return View();
        }
    }
}
