using System;
using Whysap.Application.Repositories;

namespace Whysap.Application.Abstractions.UnitOfWorks;

public interface IUnitOfWork
{
    ICallReadRepository CallRead { get; }

    ICallWriteRepository CallWrite { get; }

    IMessageReadRepository MessageRead { get; }

    IMessageWriteRepository MessageWrite { get; }

    IStatusReadRepository StatusRead { get; }

    IStatusWriteRepository StatusWrite { get; }

    IProfileReadRepository ProfileRead { get; }

    IProfileWriteRepository ProfileWrite { get; }

    IUserReadRepository UserRead { get; }

    IUserWriteRepository UserWrite { get; }
}

