using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace CQRSTemplate.Commands
{
    public class TemplateCommand : IRequest
    {
        //Properties Here 

        //public int Id { get; set; }

        //Properties Here

        public class Handler : IRequestHandler<TemplateCommand>
        {

            public Task<Unit> Handle(TemplateCommand request, CancellationToken cancellationToken)
            {
                throw new System.NotImplementedException();
            }
        }
    }
}