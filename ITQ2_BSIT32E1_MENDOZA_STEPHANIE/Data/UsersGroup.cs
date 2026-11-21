using System.ComponentModel.DataAnnotations;

namespace ITQ2_BSIT32E1_MENDOZA_STEPHANIE.Data;

public class UsersGroup
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public List<Users> Users { get; set; } = new List<Users>();
}