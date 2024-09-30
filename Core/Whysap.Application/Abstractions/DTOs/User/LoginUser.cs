using System;
namespace Whysap.Application.Abstractions.DTOs.User;

public class LoginUser
{
    public string UsernameOrEmail { get; set; }

    public string Password { get; set; }
}

