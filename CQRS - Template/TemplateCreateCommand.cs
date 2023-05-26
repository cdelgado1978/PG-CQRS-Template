using System.Threading;
using System.Threading.Tasks;
using MediatR;
using CuentasClaras.Application.Common.Interfaces;

namespace $rootnamespace$.$fileinputname$.Commands
{
    public class Create$fileinputname$Command : IRequest
    {
        //Properties Here 

        //public int Id { get; set; }

        //Properties Here

        public class Handler : IRequestHandler<Create$fileinputname$Command>
        {

            private readonly IApplicationDbContext _dbContext;

            public Handler(IApplicationDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<Unit> Handle(Create$fileinputname$Command request, CancellationToken cancellationToken)
            {
                 var new$fileinputname$ = new Domain.Entities.$fileinputname$();
            

                _dbContext.$fileinputname$.Add(new$fileinputname$);

                await _dbContext.SaveChangesAsync(cancellationToken);

                return Unit.Value;

            }
        }
    }
}