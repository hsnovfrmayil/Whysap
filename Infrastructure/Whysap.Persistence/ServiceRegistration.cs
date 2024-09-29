using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Whysap.Application.Abstractions.Services;
using Whysap.Application.Abstractions.UnitOfWorks;
using Whysap.Application.Repositories;
using Whysap.Domain.Entities.Identity;
using Whysap.Persistence.Contexts;
using Whysap.Persistence.Repositories;
using Whysap.Persistence.Services;
using Whysap.Persistence.UnitOfWorks;

namespace Whysap.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<WhysapDbContext>(options =>
                    options.UseNpgsql(Configuration.ConnectionString()), ServiceLifetime.Singleton);

        services.AddIdentity<AppUser, AppRole>(options =>
        {
            options.Password.RequiredLength = 3;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
        }).AddEntityFrameworkStores<WhysapDbContext>()
        .AddDefaultTokenProviders();


        services.AddSingleton<ICallReadRepository, CallReadRepository>();
        services.AddSingleton<ICallWriteRepository, CallWriteRepository>();
        services.AddSingleton<IStatusReadRepository, StatusReadRepository>();
        services.AddSingleton<IStatusWriteRepository, StatusWriteRepository>();
        services.AddSingleton<IMessageReadRepository, MessageReadRepository>();
        services.AddSingleton<IMessageWriteRepository, MessageWriteRepository>();
        services.AddSingleton<IProfileReadRepository, ProfileReadRepository>();
        services.AddSingleton<IProfileWriteRepository, ProfileWriteRepository>();

        services.AddScoped<IUserService, UserService>();

        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}

