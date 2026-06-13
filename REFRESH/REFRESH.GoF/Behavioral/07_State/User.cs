namespace REFRESH.GoF.Behavioral._07_State;

public class User(string login)
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Login { get; init; } = login;
    public UserRole Role { get; private set; } = UserRole.Writer;
    public void SetRole(User granter, UserRole role)
    {
        if (granter.Role == UserRole.Admin)
        {
            Role = role;
        }
    }
}
