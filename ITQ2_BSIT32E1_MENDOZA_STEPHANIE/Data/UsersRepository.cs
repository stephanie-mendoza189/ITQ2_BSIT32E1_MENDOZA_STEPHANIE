namespace ITQ2_BSIT32E1_MENDOZA_STEPHANIE.Data;

public static class UsersRepository
{
    public static List<Users> UsersList = new List<Users>
    {
        new Users { Id = 1, Name = "Steph", Email = "steph@gmail.com" },
        new Users { Id = 2, Name = "Ahnie", Email = "ahnie@gmail.com" }
    };

    public static List<UsersGroup> UserGroupsList = new List<UsersGroup>
    {
        new UsersGroup
        {
            Id = 1,
            Name = "Admin Group",
            Users = new List<Users>
            {
                new Users { Id = 1, Name = "Steph", Email = "steph@gmail.com" }
            }
        }
    };
}