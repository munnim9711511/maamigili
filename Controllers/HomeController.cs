﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using coouncil.Models;
using Coun.Data;
using Coun.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coun.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _db;
        public HomeController(DataContext _db)
        {
            this._db = _db;
        }
        public IActionResult Index()
        {
            ViewBag.gallery = _db.GalleryModels.ToArray().Take(6);
            ViewBag.anouncements = _db.anouncementsModels.ToArray().Take(6);
            ViewBag.news = _db.NewsModels.ToArray<NewsModel>().Take<NewsModel>(6);
            ViewBag.slider = _db.SliderModels.ToArray().Take(4);
            return View(ViewBag);
        }

        [HttpGet]
        public IActionResult Cafey()
        {
            ViewBag.cafey = _db.CafeyModels.ToArray();

            return View(ViewBag);
        }

        [HttpGet]
        public IActionResult News()
        {
            ViewBag.news = _db.NewsModels.ToArray().OrderByDescending(x=>x.Id);

            return View(ViewBag);
        }

        [HttpGet]

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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