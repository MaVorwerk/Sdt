using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sdt.Data.Context;

namespace Sdt.Web.Mvc.Controllers
{
    public class AutorController : Controller
    {
        private readonly SdtDataContext _context;

        public AutorController(SdtDataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var autoren = _context.Autoren.ToList();
            return View(autoren);
        }
    }
}
