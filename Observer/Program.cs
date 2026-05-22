using Observer.Classes;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IObserver subs1 = new Subscriber1();
            IObserver subs2 = new Subscriber2();

            YoutubeChannel Channel = new YoutubeChannel();
            Channel.registerObserver(subs1);
            Channel.registerObserver(subs2);

            Channel.UploadVideo("Observer Design Pattern in C#");
        }
    }
}
