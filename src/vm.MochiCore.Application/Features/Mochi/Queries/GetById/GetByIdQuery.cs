using Framework.Abstractions.Queries;
using vm.MochiCore.Application.Features.Mochi.Contracts;

namespace vm.MochiCore.Application.Features.Mochi.Queries.GetById;

public sealed class GetByIdQuery: IQuery<MochiResponse>
{
   public Guid Id { get; set; }
}