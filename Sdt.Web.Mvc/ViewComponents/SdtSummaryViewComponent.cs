using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Sdt.Data.Contracts;
using Sdt.Web.Mvc.Models;

namespace Sdt.Web.Mvc.ViewComponents
{
    public class SdtSummaryViewComponent : ViewComponent
    {
        private readonly IAutorRepository _autorRepository;

        public SdtSummaryViewComponent(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        //1. Version ohne View
        //public HtmlContentViewComponentResult Invoke()
        //{
        //    return new HtmlContentViewComponentResult(new HtmlString("Das ist eine <h3>ViewComponente</h3>"));
        //}

        //2. Version mit View
        public IViewComponentResult Invoke()
        {
            var autoren = _autorRepository.GetAll().ToList();
            var sdtSummaryVm = new SdtSummaryViewModel
            {
                AnzahlAutoren = autoren.Count,
                AnzahlSprueche = autoren.Sum(c => c.Sprueche.Count)
            };
            
            //return View(sdtSummaryVm);
            return View("Alternative",sdtSummaryVm);
        }
    }
}
