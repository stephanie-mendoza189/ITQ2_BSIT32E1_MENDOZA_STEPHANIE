using System.ComponentModel.DataAnnotations;

namespace ITQ2_BSIT32E1_MENDOZA_STEPHANIE.Data;

public class Users
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
}