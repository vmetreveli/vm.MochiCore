using Framework.Abstractions.Repository;

namespace vm.MochiCore.Domain.Repository;

public interface IMochiRepository : IRepositoryBase<Entities.Mochi, Guid>
{
}