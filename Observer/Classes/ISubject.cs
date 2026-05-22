using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Classes
{
    public interface ISubject
    {
        void registerObserver(IObserver observer);
        void removeObserver(IObserver observer);
        void notifyObservers(string message);
    }

    public class YoutubeChannel : ISubject
    {
        List<IObserver> observers = new List<IObserver>();
        public string VideoUrl { get; set; }

        public void registerObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void UploadVideo(string title)
        {
            VideoUrl = title;

            notifyObservers($"New video uploaded: {title}");
        }

        public void notifyObservers(string message)
        {
            foreach(var observer in observers)
            {
                observer.update(message);
            }
        }
    }
}
