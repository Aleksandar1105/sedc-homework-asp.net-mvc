﻿using Microsoft.AspNetCore.Mvc;
using PizzaApp.Models;
using PizzaApp.Models.Domain;
using PizzaApp.Models.Mappers;
using PizzaApp.Models.ViewModels.UserViewModel;
using System.Collections.Generic;
using System.Diagnostics;

namespace PizzaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult SeeUsers()
        {
            List<User> users = StaticDb.Users;
            List<UserListViewModel> userList = users.Select(u => u.MapFromUserToUserListViewModel()).ToList();
            return View(userList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}