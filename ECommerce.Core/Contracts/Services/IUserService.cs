using ECommerce.Core.DTO;

namespace ECommerce.Core.Contracts.Services;

public interface IUserService
{
    Task<AuthenticationResponse> LoginAsync (LoginRequest loginRequest);
    Task<AuthenticationResponse> RegisterAsync (RegisterRequest registerRequest);
}
