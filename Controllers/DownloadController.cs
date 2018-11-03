using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using coouncil.Models;

namespace Coun.Controllers
{
    public class DownloadController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult Form()
        {
            return View();
        }
        public IActionResult Law()
        {
            return View();
        }
        public IActionResult Ausule()
        {
            return View();
        }
        public IActionResult Report()
        {
            return View();
        }
        public IActionResult Documents()
        {
            return View();
        }

     
    }
}
