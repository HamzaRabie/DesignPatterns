using Builder.Classes;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new UserBuilder("Hamza").SetEmail("Hamza@gmail.com")
                                                .SetTwoFactorAuth(true)
                                                .SetAdmin(false)
                                                .Build();

            Console.WriteLine($"User With Name {user.Name} , Email : {user.Email}");
        }
    }
}
