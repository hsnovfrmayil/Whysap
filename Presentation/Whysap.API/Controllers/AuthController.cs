using System;
using Microsoft.AspNetCore.Mvc;
using Whysap.Application.Abstractions.DTOs.User;
using Whysap.Application.Abstractions.Services;

namespace Whysap.API.Controllers;

public class AuthController :ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Login(LoginUser loginUser)
    {
        LoginUserResponse response = await _authService.LoginAsync(loginUser);
        return Ok(response);
    }
}

