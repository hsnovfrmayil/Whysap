using System;
using Whysap.Application.Repositories;
using Whysap.Domain.Entities;
using Whysap.Persistence.Contexts;

namespace Whysap.Persistence.Repositories;

public class CallReadRepository : ReadRepository<Call>, ICallReadRepository
{
    public CallReadRepository(WhysapDbContext context) : base(context)
    {
    }
}

