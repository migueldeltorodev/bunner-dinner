namespace BuberDinner.Domain.User
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; init; } = default!;
        public string LastName { get; init; } = default!;
        public string Email { get; init; } = default!;
        public string Password { get; init; } = default!;
    }
}