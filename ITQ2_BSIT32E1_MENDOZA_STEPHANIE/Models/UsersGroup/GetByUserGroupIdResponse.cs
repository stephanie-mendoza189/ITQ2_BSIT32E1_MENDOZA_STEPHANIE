using ITQ2_BSIT32E1_MENDOZA_STEPHANIE.Models.Users;

namespace ITQ2_BSIT32E1_MENDOZA_STEPHANIE.Models.UsersGroup;

public class GetByUserGroupIdResponse
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<GetByUserIdResponse> Users { get; set; } = new List<GetByUserIdResponse>();
    public List<GetUserDto> UserDtos { get; set; } = new List<GetUserDto>();
}