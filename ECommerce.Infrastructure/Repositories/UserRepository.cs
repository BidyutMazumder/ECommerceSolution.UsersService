using ECommerce.Core.Contracts.Repositories;
using ECommerce.Core.Entities;

namespace ECommerce.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    public async Task<ApplicationUser?> AddUserAsync(ApplicationUser user)
    {

        throw new NotImplementedException();
    }

    public async Task<ApplicationUser?> GetUserByEmailAndPasswordAsync(string email, string password)
    {
        throw new NotImplementedException();
    }
}
