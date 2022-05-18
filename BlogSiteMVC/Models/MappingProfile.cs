using AutoMapper;
using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Simetrik olarak eşleştirme yapıyoruz.
            CreateMap<ArticleCreateVM, Article>();
            CreateMap<Article, ArticleCreateVM>();
        }
    }
}
