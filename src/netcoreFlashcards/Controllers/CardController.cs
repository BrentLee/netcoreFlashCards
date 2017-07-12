using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace netcoreFlashcards.Controllers
{
    public class CardController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}