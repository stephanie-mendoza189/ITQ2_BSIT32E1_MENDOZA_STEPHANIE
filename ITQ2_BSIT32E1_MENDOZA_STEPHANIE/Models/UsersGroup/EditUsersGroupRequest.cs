using System.ComponentModel.DataAnnotations;

namespace ITQ2_BSIT32E1_MENDOZA_STEPHANIE.Models.UsersGroup;

public class EditUsersGroupRequest
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public List<int> UserIds { get; set; } = new List<int>();
}