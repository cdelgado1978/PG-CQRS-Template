using System.Threading;
using System.Threading.Tasks;
using MediatR;
using CuentasClaras.Application.Common.Interfaces;
using CuentasClaras.Application.$fileinputname$.Responses;

namespace $rootnamespace$.$fileinputname$.Queries
{
    public class Get$fileinputname$Query : IRequest<List<$fileinputname$ResponseModel>>
    {
       public class Get$fileinputname$QueryHandler : IRequestHandler<Get$fileinputname$Query, List<$fileinputname$ResponseModel>>
        {
            private readonly IApplicationDbContext _dbContext;
                        private readonly IMapper _mapper;

            public Get$fileinputname$QueryHandler(IApplicationDbContext dbContext, IMapper mapper)
            {
                _dbContext = dbContext;
                 _mapper = mapper;
            }

            public async Task<List<$fileinputname$ResponseModel>> Handle(Get$fileinputname$Query request, CancellationToken cancellationToken)
            {


                IQueryable<$fileinputname$> entity = _dbContext.$fileinputname$;

                var result = _mapper.Map<List<$fileinputname$ResponseModel>>(entity);

                return result;
            }
        }
    }
}