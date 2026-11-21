using System.ComponentModel.DataAnnotations;

namespace ITQ2_BSIT32E1_MENDOZA_STEPHANIE.Models.UsersGroup;

public class CreateUsersGroupRequest
{
    [Required]
    public string Name { get; set; } = string.Empty;

    public List<int> UserIds { get; set; } = new List<int>();
}