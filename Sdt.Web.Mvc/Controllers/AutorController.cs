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
        #region Members/Constructor 

        private readonly SdtDataContext _context;

        public AutorController(SdtDataContext context)
        {
            _context = context;
        }

        #endregion

        #region GET

        public IActionResult Index()
        {
            var autoren = _context.Autoren.ToList();
            return View(autoren);
        }

        public IActionResult GetImage(int autorId)
        {
            var autor = _context.Autoren.Find(autorId);
            if (autor?.PhotoMimeType != null) //Autor Bild in Db vorhanden
            {
                return new FileContentResult(autor.Photo, autor.PhotoMimeType);
            }

            return new VirtualFileResult("~/images/noimg.jpg", "image/jpeg");
        }

        #endregion
    }
}
