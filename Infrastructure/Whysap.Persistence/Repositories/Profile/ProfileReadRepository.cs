using System;
using Whysap.Application.Repositories;
using Whysap.Domain.Entities;
using Whysap.Persistence.Contexts;

namespace Whysap.Persistence.Repositories;

public class ProfileReadRepository : ReadRepository<Profile>, IProfileReadRepository
{
    public ProfileReadRepository(WhysapDbContext context) : base(context)
    {
    }
}

