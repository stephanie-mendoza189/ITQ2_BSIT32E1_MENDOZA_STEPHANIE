using System.ComponentModel.DataAnnotations;

namespace ITQ2_BSIT32E1_MENDOZA_STEPHANIE.Models.Users;

public class CreateUsersRequest
{
    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
}