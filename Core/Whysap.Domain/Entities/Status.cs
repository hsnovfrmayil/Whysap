using System;
using Whysap.Domain.Entities.Common;

namespace Whysap.Domain.Entities;

public class Status : BaseEntity
{
    public string Content { get; set; }

    public DateTime ExpiryTime { get; set; }

    public Guid UserId { get; set; }

    public User User {get;set;}
}

