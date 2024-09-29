using System;
using Whysap.Application.Repositories;
using Whysap.Domain.Entities;
using Whysap.Persistence.Contexts;

namespace Whysap.Persistence.Repositories;

public class StatusReadRepository : ReadRepository<Status>, IStatusReadRepository
{
    public StatusReadRepository(WhysapDbContext context) : base(context)
    {
    }
}

