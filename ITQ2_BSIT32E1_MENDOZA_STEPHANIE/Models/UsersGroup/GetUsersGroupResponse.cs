namespace ITQ2_BSIT32E1_MENDOZA_STEPHANIE.Models.UsersGroup;

public class GetUsersGroupResponse
{
    public List<GetByUserGroupIdResponse> UserGroups { get; set; } = new List<GetByUserGroupIdResponse>();
}