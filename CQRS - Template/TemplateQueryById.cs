using System.Threading;
using System.Threading.Tasks;
using MediatR;
using CuentasClaras.Application.Common.Interfaces;
using CuentasClaras.Application.$fileinputname$.Responses;

namespace $rootnamespace$.$fileinputname$.Queries
{
    public class Get$fileinputname$QueryById : IRequest<$fileinputname$ResponseModel>
    {
        public int Id { get; set; }

        public class Get$fileinputname$QueryByIdHandler : IRequestHandler<Get$fileinputname$QueryById, $fileinputname$ResponseModel>
        {
            private readonly IApplicationDbContext _dbContext;
            
            private readonly IMapper _mapper;

            public Get$fileinputname$QueryByIdHandler(IApplicationDbContext dbContext, IMapper mapper)
            {
                _dbContext = dbContext;
                _mapper = mapper;
            }

            public async Task<$fileinputname$ResponseModel> Handle(Get$fileinputname$QueryById request, CancellationToken cancellationToken)
            {
                

                IQueryable<$fileinputname$> entity = _dbContext.$fileinputname$.where(e=> e.Id == request.Id);

                var result = _mapper.Map<$fileinputname$ResponseModel>(entity);

                return result;
            }
        }
    }
}