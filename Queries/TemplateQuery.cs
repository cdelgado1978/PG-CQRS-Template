using System.Threading;
using System.Threading.Tasks;
using CQRSTemplate.Response;
using MediatR;

namespace CQRSTemplate.Queries
{
    public class TemplateQuery : IRequest<TemplateResponseModel>
    {
        public int Id { get; set; }

        public class TemplateQueryHandler : IRequestHandler<TemplateQuery, TemplateResponseModel>
        {
            public Task<TemplateResponseModel> Handle(TemplateQuery request, CancellationToken cancellationToken)
            {
                throw new System.NotImplementedException();
            }
        }
    }
}