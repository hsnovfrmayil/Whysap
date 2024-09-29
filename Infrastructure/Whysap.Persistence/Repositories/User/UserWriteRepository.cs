using System;
using Whysap.Application.Repositories;
using Whysap.Domain.Entities;
using Whysap.Persistence.Contexts;

namespace Whysap.Persistence.Repositories;

public class UserWriteRepository : WriteRepository<User>, IUserWriteRepository
{
    public UserWriteRepository(WhysapDbContext context) : base(context)
    {
    }
}

