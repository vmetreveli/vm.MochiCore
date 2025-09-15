using System.Reflection;
using Framework.Abstractions;
using Microsoft.EntityFrameworkCore;
using vm.MochiCore.Domain.Entities.Permission;
using vm.MochiCore.Domain.Entities.RolePermission;
using vm.MochiCore.Domain.Entities.User;
using vm.MochiCore.Domain.Entities.UserRole;

namespace vm.MochiCore.Infrastructure.Context;

public class MochiDbContext(DbContextOptions<MochiDbContext> options)
    : DbContext(options),IDbContext
{
    #region Entities

     public DbSet<Domain.Entities.Mochi> Mochis { get; set; }
     public DbSet<User> Users { get; set; }
     public DbSet<UserRole> UserRoles { get; set; }
     public DbSet<Permission> Permissions { get; set; }
     public DbSet<RolePermission> RolePermissions { get; set; }
    // public DbSet<Event> Events { get; set; }
    //public DbSet<OutboxMessage> OutboxMessages { get; set; }

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}