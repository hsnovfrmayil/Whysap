using System;
using Whysap.Application.Repositories;
using Whysap.Domain.Entities;
using Whysap.Persistence.Contexts;

namespace Whysap.Persistence.Repositories;

public class MessageWriteRepository : WriteRepository<Message>, IMessageWriteRepository
{
    public MessageWriteRepository(WhysapDbContext context) : base(context)
    {
    }
}

