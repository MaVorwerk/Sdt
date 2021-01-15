using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Protocol;
using Sdt.Data.Context;
using Sdt.Data.Contracts;
using Sdt.Domain.Entities;
using X.PagedList;

namespace Sdt.Web.Mvc.Controllers
{
    public class AutorController : Controller
    {
        #region Members/Constructor

        private readonly IAutorRepository _autorRepository;

        public AutorController(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        #endregion

        #region GET

        public IActionResult Index()
        {
            var autoren = _autorRepository.GetOnlyAutoren().ToList();
            return View(autoren);
        }
        
        public IActionResult IndexWithPaging(int page = 1)
        {
            if (page < 1) page = 1;

            var itemsPerPage = 2;
            var autoren = _autorRepository.GetOnlyAutoren().ToList();
            //var autorenPaged = autoren.Skip((page - 1) * itemsPerPage).Take(itemsPerPage); //Manuelle Version

            var autorenPaged = autoren.ToPagedList(page, itemsPerPage);

            return View(autorenPaged);
        }

        public IActionResult GetImage(int autorId)
        {
            var autor = _autorRepository.GetById(autorId);
            if (autor?.PhotoMimeType != null) //Autor Bild in Db vorhanden
            {
                return new FileContentResult(autor.Photo, autor.PhotoMimeType);
            }

            return new VirtualFileResult("~/images/noimg.jpg", "image/jpeg");
        }

        #endregion
    }
}
