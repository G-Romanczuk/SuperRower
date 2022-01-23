using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperRower.Controllers
{
    public class RowerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
