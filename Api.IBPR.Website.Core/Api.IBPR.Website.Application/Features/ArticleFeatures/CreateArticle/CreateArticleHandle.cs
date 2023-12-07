using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Core.Application.Repositories;
using Api.IBPR.Website.Core.Domain.Entities;
using AutoMapper;
using MediatR;

namespace Api.IBPR.Website.Application.Features.ArticleFeatures.CreateArticle
{
    public sealed class CreateArticleHandle: IRequestHandler<CreateArticleRequest, CreateArticleResponse>
    {
        private readonly IArticle _repository;
        private readonly IUnitOfWork _unitOfwork;
        private readonly IMapper _mapper;

        /*public CreateArticleHandle(IArticle repository, IUnitOfWork unitOfwork, IMapper mapper) =>
            (_repository, _unitOfwork, _mapper) = (repository, unitOfwork, mapper);*/

        public CreateArticleHandle(IArticle repository, IUnitOfWork unitOfwork, IMapper mapper)
        {
            _repository = repository;
            _unitOfwork = unitOfwork;
            _mapper = mapper;
        }

        public async Task<CreateArticleResponse> Handle(CreateArticleRequest request, CancellationToken cancellationToken)
        {
            var article = _mapper.Map<Article>(request);
            _repository.SetArticle(article);
            await _unitOfwork.Save();

            return _mapper.Map<CreateArticleResponse>(article);
        }
    }
}
