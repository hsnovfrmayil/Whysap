using System;
using Whysap.Domain.Entities.Common;

namespace Whysap.Domain.Entities;

public class Profile :BaseEntity
{
    public string Bio { get; set; }

    public string Website { get; set; }

    public Guid UserId { get; set; }

    public User User { get; set; }
}

