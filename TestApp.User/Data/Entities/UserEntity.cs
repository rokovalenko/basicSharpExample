namespace TestApp.User.Data.Entities;

public class UserEntity
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; init; } = string.Empty;
}