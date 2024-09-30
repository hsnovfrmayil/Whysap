using System;
using Whysap.Application.Abstractions.Services.Authentications;

namespace Whysap.Application.Abstractions.Services;

public interface IAuthService : IInternalAuthentication, IExternalAuthentication
{

}

