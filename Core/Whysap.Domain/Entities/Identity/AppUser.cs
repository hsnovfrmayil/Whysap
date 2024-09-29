using System;
using Microsoft.AspNetCore.Identity;

namespace Whysap.Domain.Entities.Identity;

public class AppUser :IdentityUser<string>
{
    public string NameSurname { get; set; }
}

