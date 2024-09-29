using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Whysap.Domain.Entities;
using Whysap.Domain.Entities.Common;
using Whysap.Domain.Entities.Identity;

namespace Whysap.Persistence.Contexts;

public class WhysapDbContext : IdentityDbContext<AppUser,AppRole,string>
{
    public WhysapDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Call> Calls { get; set; }

    public DbSet<Message> Messages { get; set; }

    public DbSet<Profile> Profiles { get; set; }

    public DbSet<Status> Statuses { get; set; }



    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var datas = ChangeTracker.Entries<BaseEntity>();

        foreach (var data in datas)
        {
            _ = data.State switch
            {
                EntityState.Added => data.Entity.CreatedTime = DateTime.UtcNow,
                EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                _ => DateTime.UtcNow
            };
        }

        return await base.SaveChangesAsync(cancellationToken);
    }
}

