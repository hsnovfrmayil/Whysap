using System;
using System.ComponentModel.DataAnnotations.Schema;
using Whysap.Domain.Entities.Common;

namespace Whysap.Domain.Entities;

public class User :BaseEntity
{
    public string Username { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string ProfilePictureUrl { get; set; }

    public DateTime LastSeen { get; set; }

    public string Status { get; set; }

    //Message Entity

    [InverseProperty(nameof(Message.SenderUser))]
    public ICollection<Message> SenderMessages { get; set; }

    [InverseProperty(nameof(Message.ReceiverUser))]
    public ICollection<Message> ReceiverMessages { get; set; }


    //Call Entity
    [InverseProperty(nameof(Call.CallerUser))]
    public ICollection<Call> CallerCalls { get; set; }

    [InverseProperty(nameof(Call.ReceiverUser))]
    public ICollection<Call> ReceiverCalls { get; set; }


    //Status Entity

    public ICollection<Status> Statuses { get; set; }


    //Profile Entity

    public Profile Profile { get; set; }
}

