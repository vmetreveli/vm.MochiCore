using Framework.Abstractions.Queries;
using vm.MochiCore.Application.Features.Mochi.Contracts;
using vm.MochiCore.Application.Services;

namespace vm.MochiCore.Application.Features.Mochi.Queries.GetById;

public sealed class GetByIdQueryHandler(IMochiService mochiService) : IQueryHandler<GetByIdQuery, MochiResponse>
{ 
    public Task<MochiResponse> Handle(GetByIdQuery query, CancellationToken cancellationToken = default)
    {
       return mochiService.GetById(query.Id, cancellationToken);
    }
}