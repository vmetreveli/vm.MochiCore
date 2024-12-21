using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace vm.MochiCore.Infrastructure.Context;

public class MochiDbContextFactory : IDesignTimeDbContextFactory<MochiDbContext>
{
    public MochiDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<MochiDbContext>();
        optionsBuilder
            .UseNpgsql("DefaultConnection")
            .UseSnakeCaseNamingConvention();

        return new MochiDbContext(optionsBuilder.Options);
    }
}