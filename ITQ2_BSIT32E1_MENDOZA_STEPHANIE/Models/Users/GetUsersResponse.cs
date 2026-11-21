namespace ITQ2_BSIT32E1_MENDOZA_STEPHANIE.Models.Users;

public class GetUsersResponse
{
    public List<GetByUserIdResponse> Users { get; set; } = new List<GetByUserIdResponse>();
    public List<GetUserDto> UserDtos { get; set; } = new List<GetUserDto>();
}