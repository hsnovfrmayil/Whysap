using System;
using Microsoft.AspNetCore.Identity;
using Whysap.Application.Abstractions.DTOs.User;
using Whysap.Application.Abstractions.Services;
using Whysap.Domain.Entities.Identity;

namespace Whysap.Persistence.Services;

public class UserService : IUserService
{
    readonly UserManager<AppUser> _userManager;

    public UserService(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<CreateUserResponse> CreateAsync(CreateUser model)
    {
        IdentityResult result = await _userManager.CreateAsync(new()
        {
            Id = Guid.NewGuid().ToString(),
            UserName = model.Username,
            Email = model.Email,
            NameSurname = model.NameSurname
        },model.Password);

        CreateUserResponse response = new() { Succeeded = result.Succeeded };

        if (result.Succeeded)
            response.Message = "Istifadeci ugurla yaradildi!";
        else
            foreach (var error in result.Errors)
                response.Message += $"{error.Code}-{error.Description}<br>";

        return response;
    }
}

