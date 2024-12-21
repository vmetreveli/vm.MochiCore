using Framework.Abstractions.Queries;
using vm.MochiCore.Application.Features.Mochi.Contracts;
using vm.MochiCore.Application.Services;

namespace vm.MochiCore.Application.Features.Mochi.Queries.GetAll;

public sealed class GetAllQueryHandler(IMochiService mochiService) : IQueryHandler<GetAllQuery, IList<MochiResponse>>
{
    public async Task<IList<MochiResponse>> Handle(GetAllQuery query, CancellationToken cancellationToken = default)
    {
        var res=await mochiService.GetAll(cancellationToken);
        return res;
    }
}