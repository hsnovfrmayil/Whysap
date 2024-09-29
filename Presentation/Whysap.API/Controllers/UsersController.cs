using System;
using Microsoft.AspNetCore.Mvc;
using Whysap.Application.Abstractions.DTOs.User;
using Whysap.Application.Abstractions.Services;

namespace Whysap.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController :ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(CreateUser createUser)
    {
        CreateUserResponse response=await _userService.CreateAsync(createUser);
        return Ok(response);
    }
}

