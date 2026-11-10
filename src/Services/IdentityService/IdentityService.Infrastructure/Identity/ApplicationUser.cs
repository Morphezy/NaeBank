using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace IdentityService.Infrastructure.Identity;

public class ApplicationUser : IdentityUser<Guid>
{
    [MaxLength(32)]
    [Required]
    public required string FirstName { get; set; }
    [MaxLength(32)]
    [Required]
    public required string LastName { get; set; }
    public  DateTimeOffset CreatedAtUtc { get; set; }
    public bool IsActive { get; set; } = true;

}