using Mediator.Classes;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChatMediator mediator = new ChatMediator();

            Participant user1 = new User("Hamza",mediator);
            Participant user2 = new User("Ahemed",mediator);

            Participant admin = new Admin("Admin", mediator);

            mediator.AddParticipant(user1);
            mediator.AddParticipant(user2);
            mediator.AddParticipant(admin);

            user1.Send("Hello, I am Hamza!");


        }
    }
}
