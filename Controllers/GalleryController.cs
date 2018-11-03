using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using coouncil.Models;

namespace Coun.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index(string type)
        {
            
            return View();
        }

     
    }
}
