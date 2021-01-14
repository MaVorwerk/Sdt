using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sdt.Web.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Sdt.Data.Context;
using Sdt.Data.Contracts;

namespace Sdt.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISpruchRepository _spruchRepository;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, ISpruchRepository spruchRepository, IMapper mapper)
        {
            _logger = logger;
            _spruchRepository = spruchRepository;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var spruch = _spruchRepository.GetSpruchDesTages();

            //var sdtVm = ModelFactory.CreateSpruchDesTagesViewModel(spruch);
            var sdtVm = _mapper.Map<SpruchDesTagesViewModel>(spruch);

            return View(sdtVm);
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
