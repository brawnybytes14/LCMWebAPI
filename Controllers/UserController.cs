using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LCMWebAPI.Data;
using LCMWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LCMWebAPI.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var userInDb = _context.Users.Where(a => a.Email == user.Email && a.Password == user.Password).FirstOrDefault();

            if(userInDb != null)
                return Json(userInDb);

            return Json(new User());
        }

        [HttpPost]
        public IActionResult LogOut()
        {
            return Json(new User());
        }

        [HttpPost]
        public IActionResult SignUp(User user)
        {
            if (user.Password != null && user.Email != null)
            {
                var userInDb = _context.Users.Where(a => a.Email == user.Email && a.Password == user.Password).FirstOrDefault();
                if(userInDb != null)
                    return Json(userInDb);

                _context.Add(user);
                _context.SaveChanges();
            }
            return Json(user);
        }
    }
}