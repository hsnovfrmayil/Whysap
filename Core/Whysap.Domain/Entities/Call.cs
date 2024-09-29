
using Whysap.Domain.Entities.Common;
using Whysap.Domain.Enums;

namespace Whysap.Domain.Entities;

public class Call :BaseEntity
{
    public CallType CallType { get; set; }

    public DateTime CallEnd { get; set; }

    public CallStatus CallStatus { get; set; }


    public Guid CallerUserId { get; set; }

    public Guid ReceiverUserId { get; set; }

    public User CallerUser { get; set; }

    public User ReceiverUser { get; set; }
}

