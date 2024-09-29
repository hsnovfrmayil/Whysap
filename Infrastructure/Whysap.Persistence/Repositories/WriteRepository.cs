using System;
using Microsoft.EntityFrameworkCore;
using Whysap.Application.Repositories;
using Whysap.Domain.Entities.Common;
using Whysap.Persistence.Contexts;

namespace Whysap.Persistence.Repositories;

public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
{
    private readonly WhysapDbContext _context;

    public WriteRepository(WhysapDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();
}

