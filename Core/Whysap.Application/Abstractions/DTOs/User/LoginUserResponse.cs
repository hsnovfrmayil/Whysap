using System;
namespace Whysap.Application.Abstractions.DTOs.User;

public class LoginUserResponse
{
    public bool Succeeded { get; set; }

    public string Message { get; set; }
}

