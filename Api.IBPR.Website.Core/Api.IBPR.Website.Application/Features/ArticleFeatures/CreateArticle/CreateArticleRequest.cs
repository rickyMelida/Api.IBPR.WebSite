using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Application.Features.ArticleFeatures.CreateArticle
{
    public sealed record CreateArticleRequest(string Author,
                                              string Text ,
                                              string Title ,
                                              int UrlImage ,
                                              int Verse ,
                                              DateTime CreateAt ,
                                              int IdTag,
                                              int IdComment ): IRequest<CreateArticleResponse>;

}
