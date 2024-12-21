using System.Reflection;
using Framework.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace vm.MochiCore.Infrastructure.Context;

public class MochiDbContext(DbContextOptions<MochiDbContext> options)
    : DbContext(options),IDbContext
{
    #region Entities

     public DbSet<MochiCore.Domain.Entities.Mochi> Mochis { get; set; }
    // public DbSet<Event> Events { get; set; }
    //public DbSet<OutboxMessage> OutboxMessages { get; set; }

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}