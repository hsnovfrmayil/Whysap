using System;
using Whysap.Application.Repositories;
using Whysap.Domain.Entities;
using Whysap.Persistence.Contexts;

namespace Whysap.Persistence.Repositories;

public class MessageReadRepository : ReadRepository<Message>, IMessageReadRepository
{
    public MessageReadRepository(WhysapDbContext context) : base(context)
    {
    }
}

