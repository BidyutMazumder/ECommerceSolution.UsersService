using ECommerce.Core.Entities;

namespace ECommerce.Core.Contracts.Repositories;
 
public interface IUserRepository
{
    Task<ApplicationUser?> AddUserAsync(ApplicationUser user);
    Task<ApplicationUser?> GetUserByEmailAndPasswordAsync(string email, string password);
}
