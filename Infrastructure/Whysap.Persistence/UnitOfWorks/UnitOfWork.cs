using System;
using Whysap.Application.Abstractions.UnitOfWorks;
using Whysap.Application.Repositories;
using Whysap.Persistence.Contexts;
using Whysap.Persistence.Repositories;

namespace Whysap.Persistence.UnitOfWorks;

public class UnitOfWork : IUnitOfWork
{
    private readonly WhysapDbContext _context;

    // Repositories
    private IMessageReadRepository _messageReadRepository;
    private IMessageWriteRepository _messageWriteRepository;
    private IProfileReadRepository _profileReadRepository;
    private IProfileWriteRepository _profileWriteRepository;
    private ICallReadRepository _callReadRepository;
    private ICallWriteRepository _callWriteRepository;
    private IStatusReadRepository _statusReadRepository;
    private IStatusWriteRepository _statusWriteRepository;
    private IUserReadRepository _userReadRepository;
    private IUserWriteRepository _userWriteRepository;

    public UnitOfWork(WhysapDbContext context)
    {
        _context = context;
    }

    public IMessageReadRepository MessageRead =>
        _messageReadRepository ??= new MessageReadRepository(_context);

    public IMessageWriteRepository MessageWrite =>
        _messageWriteRepository ??= new MessageWriteRepository(_context);

    public IProfileReadRepository ProfileRead =>
        _profileReadRepository ??= new ProfileReadRepository(_context);

    public IProfileWriteRepository ProfileWrite =>
        _profileWriteRepository ??= new ProfileWriteRepository(_context);

    public ICallReadRepository CallRead =>
        _callReadRepository ??= new CallReadRepository(_context);

    public ICallWriteRepository CallWrite =>
        _callWriteRepository ??= new CallWriteRepository(_context);

    public IStatusReadRepository StatusRead =>
        _statusReadRepository ??= new StatusReadRepository(_context);

    public IStatusWriteRepository StatusWrite =>
        _statusWriteRepository ??= new StatusWriteRepository(_context);

    public IUserReadRepository UserRead =>
        _userReadRepository ??= new UserReadRepository(_context);

    public IUserWriteRepository UserWrite =>
        _userWriteRepository ??= new UserWriteRepository(_context);

    public async Task<int> CompleteAsync()
    {
        return await _context.SaveChangesAsync();
    }
}

