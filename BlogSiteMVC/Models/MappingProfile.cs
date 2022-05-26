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

            CreateMap<ArticleShowMainPageVM, Article>();
            CreateMap<Article, ArticleShowMainPageVM>();

            CreateMap<ArticleAndUserVM, Article>();
            CreateMap<Article, ArticleAndUserVM>();

            CreateMap<Topic, TopicAndArticleVM>();
            CreateMap<TopicAndArticleVM, Topic>();

            CreateMap<UserInformation, UserVM>();
            CreateMap<UserVM, UserInformation>();

            CreateMap<UserRegister, UserVM>();
            CreateMap<UserVM, UserRegister>();
        }
    }
}
