using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Whysap.Persistence.Contexts;

namespace Whysap.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<WhysapDbContext>
{
    public WhysapDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<WhysapDbContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString());

        return new(dbContextOptionsBuilder.Options);
    }
}

