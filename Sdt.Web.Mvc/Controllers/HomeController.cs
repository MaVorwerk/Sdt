using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sdt.Web.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Sdt.Data.Context;
using Sdt.Data.Contracts;

namespace Sdt.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISpruchRepository _spruchRepository;

        public HomeController(ILogger<HomeController> logger, ISpruchRepository spruchRepository)
        {
            _logger = logger;
            _spruchRepository = spruchRepository;
        }

        public IActionResult Index()
        {
            var spruch = _spruchRepository.GetSpruchDesTages();



            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
