using System;
namespace Whysap.Domain.Entities.Common;

public class BaseEntity
{
    public Guid Id { get; set; }

    public DateTime CreatedTime { get; set; }

    virtual public DateTime UpdatedDate { get; set; }
}

