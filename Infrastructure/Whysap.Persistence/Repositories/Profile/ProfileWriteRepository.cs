using System;
using Whysap.Application.Repositories;
using Whysap.Domain.Entities;
using Whysap.Persistence.Contexts;

namespace Whysap.Persistence.Repositories;

public class ProfileWriteRepository : WriteRepository<Profile>, IProfileWriteRepository
{
    public ProfileWriteRepository(WhysapDbContext context) : base(context)
    {
    }
}

