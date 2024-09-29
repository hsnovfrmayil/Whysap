using System;
using Whysap.Application.Repositories;
using Whysap.Domain.Entities;
using Whysap.Persistence.Contexts;

namespace Whysap.Persistence.Repositories;

public class StatusWriteRepository : WriteRepository<Status>, IStatusWriteRepository
{
    public StatusWriteRepository(WhysapDbContext context) : base(context)
    {
    }
}

