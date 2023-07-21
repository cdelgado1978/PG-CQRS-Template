using System.Threading;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;

namespace $rootnamespace$.$fileinputname$.Commands
{
    public class Update$fileinputname$Command : IRequest
    {
        //Properties Here 

        public int Id { get; set; }

        //Properties Here

        public class Update$fileinputname$CommandHandler : IRequestHandler<Update$fileinputname$Command>
        {
            private readonly IApplicationDbContext _dbContext;

             private readonly IMapper _mapper;

            public Update$fileinputname$CommandHandler(IApplicationDbContext dbContext, IMapper mapper)
            {
                _dbContext = dbContext;
                _mapper = mapper;

            }

            public async Task<Unit> Handle(Update$fileinputname$Command request, CancellationToken cancellationToken)
            {
                 var _$fileinputname$ = _dbContext.$fileinputname$.FirstOrDefault(e => e.Id == request.Id) ?? throw new NotFoundException(nameof($fileinputname$), request.Id);
            
                var updated$fileinputname$ = _mapper.Map(request, _$fileinputname$);

                _dbContext.$fileinputname$.Update(updated$fileinputname$);

                await _dbContext.SaveChangesAsync(cancellationToken);

                return Unit.Value;

            }
        }
    }
}