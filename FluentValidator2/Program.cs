using FluentValidation.Results;

namespace FluentValidator2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var user = new User { Name = "Clement", Age = 15 };

            var validator = new UserValidator();
            ValidationResult results = validator.Validate(user);

            if (!results.IsValid)
            {
                foreach (var error in results.Errors)
                {
                    Console.WriteLine($"Property: {error.PropertyName}, Error: {error.ErrorMessage}");
                }
            }
            else
            {
                Console.WriteLine("User is valid.");
            }
        }
    }
}
