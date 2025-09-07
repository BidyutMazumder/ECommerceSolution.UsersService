using ECommerce.Core.Entities;

namespace ECommerce.Core.Contracts.Repository;
 
public interface IUserRepository
{
    Task<ApplicationUser?> AddUserAsync(ApplicationUser user);
    Task<ApplicationUser?> GetUserByEmailAndPasswordAsync(string email, string password);
}
