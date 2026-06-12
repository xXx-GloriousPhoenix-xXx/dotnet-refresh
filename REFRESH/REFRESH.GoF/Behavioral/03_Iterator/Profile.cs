namespace REFRESH.GoF.Behavioral._03_Iterator;

public class Profile(string email)
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Email { get; init; } = email;
}
