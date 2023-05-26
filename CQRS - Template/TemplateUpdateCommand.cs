using System.Threading;
using System.Threading.Tasks;
using MediatR;
using CuentasClaras.Application.Common.Interfaces;

namespace $rootnamespace$.$fileinputname$.Commands
{
    public class Update$fileinputname$Command : IRequest
    {
        //Properties Here 

        public int Id { get; set; }

        //Properties Here

        public class Handler : IRequestHandler<Update$fileinputname$Command>
        {
            private readonly IApplicationDbContext _dbContext;

            public Handler(IApplicationDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<Unit> Handle(Update$fileinputname$Command request, CancellationToken cancellationToken)
            {
                 var _$fileinputname$ = _dbContext.$fileinputname$.FirstOrDefault(e => e.Id == request.Id);
            

                _dbContext.$fileinputname$.Update(_$fileinputname$);

                await _dbContext.SaveChangesAsync(cancellationToken);

                return Unit.Value;

            }
        }
    }
}