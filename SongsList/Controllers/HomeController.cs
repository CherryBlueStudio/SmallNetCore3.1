﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SongsList.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SongsList.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
