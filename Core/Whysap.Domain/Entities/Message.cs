using System;
using Whysap.Domain.Entities.Common;
using Whysap.Domain.Enums;

namespace Whysap.Domain.Entities;

public class Message : BaseEntity
{
    public string Content { get; set; }

    public MessageType MessageType { get; set; }

    public MessageStatus MessageStatus { get; set; }


    public Guid SenderUserId { get; set; }

    public Guid ReceiverUserId { get; set; }

    public User SenderUser { get; set; }

    public User ReceiverUser { get; set; }
}

