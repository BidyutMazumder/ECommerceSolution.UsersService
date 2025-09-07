using System.Security.Cryptography.X509Certificates;

namespace ECommerce.Core.DTO;

public record RegisterRequest(
    string? Email,
    string? Password,
    string? PersonName,
    GenderOptions Gender
    );
