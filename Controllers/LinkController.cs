using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using coouncil.Models;
using Coun.Data;

namespace Coun.Controllers
{
    public class LinkController : Controller
    {
        private readonly DataContext _db;
        public LinkController(DataContext _db)
        {
            this._db = _db;
        }

       public IActionResult Info(string id){
           ViewBag.Info = _db.LinkModels.Where(x=>x.Catogary == id).ToArray();
           return View(ViewBag);
       }

     
    }
}
