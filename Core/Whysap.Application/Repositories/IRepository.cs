using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Whysap.Domain.Entities.Common;

namespace Whysap.Application.Repositories;

public interface IRepository<T> where T : BaseEntity
{
    DbSet<T> Table { get; }
}

