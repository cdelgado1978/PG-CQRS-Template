using System.Threading;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;

namespace $rootnamespace$.$fileinputname$.Commands
{
   
        public class Create$fileinputname$CommandHandler : IRequestHandler<Create$fileinputname$Command>
        {

            private readonly IApplicationDbContext _dbContext;
            private readonly IMapper _mapper;

            public Create$fileinputname$CommandHandler(IApplicationDbContext dbContext, IMapper mapper)
            {
                _dbContext = dbContext;
                _mapper = mapper;
            }

            public async Task<Unit> Handle(Create$fileinputname$Command request, CancellationToken cancellationToken)
            {

                var new$fileinputname$ = _mapper.Map<Domain.Entities.$fileinputname$>(request);

                _dbContext.$fileinputname$.Add(new$fileinputname$);

                await _dbContext.SaveChangesAsync(cancellationToken);

                return Unit.Value;

            }
        }
    
}