using System;
using Whysap.Application.Abstractions.DTOs.User;

namespace Whysap.Application.Abstractions.Services.Authentications;

public interface IInternalAuthentication
{
    Task<LoginUserResponse> LoginAsync(LoginUser loginUser);
}

