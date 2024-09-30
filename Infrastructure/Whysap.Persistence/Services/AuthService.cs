using System;
using Microsoft.AspNetCore.Identity;
using Whysap.Application.Abstractions.DTOs;
using Whysap.Application.Abstractions.DTOs.User;
using Whysap.Application.Abstractions.Services;
using Whysap.Domain.Entities.Identity;

namespace Whysap.Persistence.Services;

public class AuthService : IAuthService
{
    readonly UserManager<AppUser> _userManager;
    readonly SignInManager<AppUser> _signInManager;

    public AuthService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task<LoginUserResponse> LoginAsync(LoginUser loginUser)
    {
        AppUser user = await _userManager.FindByEmailAsync(loginUser.UsernameOrEmail);

        if (user == null)
            user = await _userManager.FindByNameAsync(loginUser.UsernameOrEmail);

        if (user == null)
            throw new Exception();

        SignInResult result = await _signInManager.CheckPasswordSignInAsync(user, loginUser.Password, false);

        LoginUserResponse response = new() { Succeeded = result.Succeeded };

        if (result.Succeeded)
            response.Message = "Ugurla daxil oldu";

        return response;
    }
}

