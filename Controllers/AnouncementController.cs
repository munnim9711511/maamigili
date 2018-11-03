using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using coouncil.Models;

namespace Coun.Controllers
{
    public class AnounceController : Controller
    {
        public IActionResult CouncilAnounce()
        {
            return View();
        }

        public IActionResult OrganizationAnounce()
        {
            return View();
        }
        public IActionResult LocalAnounce()
        {
            return View();
        }
      
    }
}
