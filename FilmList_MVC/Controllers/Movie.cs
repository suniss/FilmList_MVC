using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmList_MVC.Controllers
{
    public class Movie : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
