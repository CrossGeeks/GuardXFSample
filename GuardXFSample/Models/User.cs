using Dawn;

namespace GuardXFSample.Models
{
    public sealed class User
    {
        public User(string firstName, string lastName, string email, int age)
        {
            FirstName = Guard.Argument(firstName, nameof(firstName))
                              .IsAValidString();

            LastName = Guard.Argument(lastName, nameof(lastName))
                            .IsAValidString();

            Email = Guard.Argument(email, nameof(email))
                          .IsAValidEmail();

            Age = Guard.Argument(age, nameof(age))
                       .Min(18);
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public int Age { get; }
    }
}
