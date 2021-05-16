﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCDependencyInjectionType.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDependencyInjectionType.Controllers
{
    public class HomeController : Controller
    {

        private readonly ITransient _transient;
        private readonly IScoped _scoped;
        private readonly ISingleton _singleton;

        private readonly ITransient _transient2;
        private readonly IScoped _scoped2;
        private readonly ISingleton _singleton2;

        public HomeController(ITransient transient, IScoped scoped, ISingleton singleton, ITransient transient2, IScoped scoped2, ISingleton singleton2)
        {
            _transient = transient;
            _scoped = scoped;
            _singleton = singleton;

            _transient2 = transient2;
            _scoped2 = scoped2;
            _singleton2 = singleton2;

        }

        public IActionResult Index()
        {

            ViewBag.transient = _transient;
            ViewBag.scoped = _scoped;
            ViewBag.singleton = _singleton;

            ViewBag.transient2 = _transient2;
            ViewBag.scoped2 = _scoped2;
            ViewBag.singleton2 = _singleton2;

            return View();
        }

       
    }
}
