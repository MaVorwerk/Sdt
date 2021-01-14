using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sdt.Domain.Entities;

namespace Sdt.Web.Mvc.Models
{
    public static class ModelFactory
    {
        public static SpruchDesTagesViewModel CreateSpruchDesTagesViewModel(Spruch spruch)
        {
            return new SpruchDesTagesViewModel
            {
                AutorId = spruch.AutorId,
                AutorBeschreibung = spruch.Autor?.Beschreibung,
                AutorName = spruch.Autor?.Name,
                AutorGeburtsdatum = spruch.Autor?.Geburtsdatum,
                AutorBild = spruch.Autor?.Photo,
                AutorBildType = spruch.Autor?.PhotoMimeType,
                SpruchId = spruch.SpruchId,
                SpruchText = spruch.SpruchText
            };
        }
    }
}
