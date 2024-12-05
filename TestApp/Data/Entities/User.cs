namespace TestApp.Data.Entities;

public class User
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; init; } = string.Empty;
}