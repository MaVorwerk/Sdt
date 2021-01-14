using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Sdt.Domain.Entities;
using Sdt.Web.Mvc.Models;

namespace Sdt.Web.Mvc.Profiles
{
    public class SpruchProfile : Profile
    {
        public SpruchProfile()
        {
            CreateMap<Spruch, SpruchDesTagesViewModel>()
                .ForMember(c => c.AutorBildType, opt => opt.MapFrom(src => src.Autor.PhotoMimeType))
                .ForMember(c => c.AutorBild, opt => opt.MapFrom(src => src.Autor.Photo));
        }
    }
}
