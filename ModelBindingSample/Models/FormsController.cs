﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ModelBindingSample.Models
{
    public class FormsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}