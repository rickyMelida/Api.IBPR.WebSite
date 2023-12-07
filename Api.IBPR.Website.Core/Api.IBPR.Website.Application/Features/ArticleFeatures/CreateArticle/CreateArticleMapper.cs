using Api.IBPR.Website.Core.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Application.Features.ArticleFeatures.CreateArticle
{
    public sealed class CreateArticleMapper: Profile
    {
        public CreateArticleMapper()
        {
            CreateMap<CreateArticleRequest, Article>();
            CreateMap<Article, CreateArticleResponse>();

        }

    }
}
