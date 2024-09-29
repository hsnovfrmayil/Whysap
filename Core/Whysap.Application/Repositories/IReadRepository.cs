using System;
using Whysap.Domain.Entities.Common;

namespace Whysap.Application.Repositories;

public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
{

}

