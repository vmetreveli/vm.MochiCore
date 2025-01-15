using Framework.Abstractions.Repository;
using Microsoft.EntityFrameworkCore;

namespace vm.MochiCore.Domain.Repository;

public interface IMochiRepository : IRepositoryBase<Entities.Mochi, Guid>
{
    public  Task<Entities.Mochi?> GetByNameAsync(string name, CancellationToken cancellationToken = default);

}