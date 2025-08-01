using TutorCabinet.Core.Entities;

namespace TutorCabinet.Infrastructure.Data.Models;

/// <summary>
/// Представление <see cref="User"/> в базе данных
/// </summary>
public class UserEntity
{
    public Guid Id { get; init; }
    public string Email { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; init; }
    public DateTime UpdatedAt { get; set; }
    public string PasswordHash { get; set; }
}