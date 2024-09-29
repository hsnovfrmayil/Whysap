using System;
using Whysap.Application.Repositories;
using Whysap.Domain.Entities;
using Whysap.Persistence.Contexts;

namespace Whysap.Persistence.Repositories;

public class CallWriteRepository : WriteRepository<Call>, ICallWriteRepository
{
    public CallWriteRepository(WhysapDbContext context) : base(context)
    {
    }
}

