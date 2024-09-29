using Whysap.Application.Abstractions.DTOs.User;

namespace Whysap.Application.Abstractions.Services;

public interface IUserService
{
    Task<CreateUserResponse> CreateAsync(CreateUser model);
}

