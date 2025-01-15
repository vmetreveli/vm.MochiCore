using Framework.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using vm.MochiCore.Domain.Entities;
using vm.MochiCore.Domain.Repository;

namespace vm.MochiCore.Infrastructure;

public sealed class MochiRepository(DbContext dbContext) : RepositoryBase<DbContext,Mochi, Guid>(dbContext), IMochiRepository
{
    private readonly DbContext _dbContext = dbContext;

    public Task<Mochi?> GetByNameAsync(string name, CancellationToken cancellationToken = default)
    {
      return  _dbContext.Set<Mochi>()
          .Where(i=>i.Name == name)
          .FirstOrDefaultAsync(cancellationToken);
    }
}