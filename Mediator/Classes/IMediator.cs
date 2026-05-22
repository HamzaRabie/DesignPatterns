using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Classes
{
    public interface IMediator
    {
        void SendMessage(string message, Participant participant);
    }

    public class ChatMediator : IMediator
    {
        List<Participant> participants;
        public ChatMediator()
        {
            participants = new List<Participant>();
        }

        public void AddParticipant(Participant participant)
        {
            participants.Add(participant);
        }
        public void SendMessage(string message, Participant participant)
        {
            foreach(var p in participants)
            {
                if (p != participant)
                {
                    p.Receive(message);
                }
            };
        }
    }
}
