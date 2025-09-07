using ECommerce.Core.Contracts.Repositories;
using ECommerce.Core.Contracts.Services;
using ECommerce.Core.DTO;

namespace ECommerce.Core.Services;

internal class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<AuthenticationResponse> LoginAsync(LoginRequest loginRequest)
    {
        throw new NotImplementedException();
    }

    public async Task<AuthenticationResponse> RegisterAsync(RegisterRequest registerRequest)
    {
        throw new NotImplementedException();
    }
}
