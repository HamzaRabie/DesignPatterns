using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Mediator.Classes
{
    public abstract class Participant
    {
        private readonly IMediator _mediator;
        public string Name { get; }
        public Participant(string name, IMediator mediator)
        {
            Name = name;
            _mediator = mediator;
        }

        public abstract void Receive(string message);

        public void Send(string message)
        {
            Console.WriteLine($"{Name} sends: {message}");

            _mediator.SendMessage(message, this);
        }
    }

    public class User : Participant
    {
        public User(string name, IMediator mediator) : base(name, mediator)
        {
        }
        public override void Receive(string message)
        {
            Console.WriteLine($"User : {Name} receives: {message}");
        }
    }

    public class Admin : Participant
    {
        public Admin(string name, IMediator mediator) : base(name, mediator)
        {
        }
        public override void Receive(string message)
        {
            Console.WriteLine($"Admin :{Name} receives: {message}");
        }
    }
}
