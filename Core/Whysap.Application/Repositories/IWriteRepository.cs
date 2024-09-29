using System;
using Whysap.Domain.Entities.Common;

namespace Whysap.Application.Repositories;

public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
{

}

