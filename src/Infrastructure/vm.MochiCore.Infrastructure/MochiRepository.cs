using Framework.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using vm.MochiCore.Domain.Repository;

namespace vm.MochiCore.Infrastructure;

public sealed class MochiRepository(DbContext dbContext) : RepositoryBase<DbContext, MochiCore.Domain.Entities.Mochi, Guid>(dbContext), IMochiRepository;