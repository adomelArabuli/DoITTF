using System.Security;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //YoutubeChannel youtuber = new YoutubeChannel();
            //Subscriber subscriber = new Subscriber();

            //subscriber.Subscribe(youtuber);

            //youtuber.UploadVideo();

            ////subscriber.UnSubscribe(youtuber);

            //// dagvrcha(using event for multicast delegate)
            //youtuber.UploadVideo();

            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber = new EventSubscriber();

            subscriber.Subscribe(publisher);

            publisher.TriggerEvent();
        }
    }

    class EventSubscriber
    {
        private void MyEventHandler1(string message)
        {
            Console.WriteLine($"Handler 1 {message}");
        }

        private void MyEventHandler2(string message)
        {
            Console.WriteLine($"Handler 2 {message}");
        }

        public void Subscribe(EventPublisher publisher)
        {
            publisher.MyEvent += MyEventHandler1;
            publisher.MyEvent += MyEventHandler2;
        }

        public void UnSubscribe(EventPublisher publisher)
        {
            publisher.MyEvent -= MyEventHandler1;
            publisher.MyEvent -= MyEventHandler2;
        }
    }

    public class EventPublisher
    {
        public event Action<string> MyEvent;

        protected virtual void OnMyEvent(string message)
        {
            MyEvent(message); // Invoke ? (is better? why?)
        } 

        public void TriggerEvent()
        {
            OnMyEvent("Event triggered");
        }
    }


    //Publisher

    //public class MyEventArgs : EventArgs 
    //{
    //    public string Message { get;}
    //    public MyEventArgs(string message)
    //    {
    //        Message = message;
    //    }
    //}

    //public class YoutubeChannel
    //{
    //    public event EventHandler<MyEventArgs> VideoUploadEvent;

    //    protected virtual void OnVideoUpload(string message)
    //    {
    //        MyEventArgs args = new MyEventArgs(message);
    //        VideoUploadEvent?.Invoke(this, args);
    //    }

    //    public void UploadVideo()
    //    {
    //        string path = "https://Youtube.com/channel1/newVideo";
    //        OnVideoUpload($"Check video here: {path}");
    //    }
    //}

    ////Subscriber
    //public class Subscriber
    //{
    //    private void VideoUploadEventHandler(object sender, MyEventArgs e)
    //    {
    //        Console.WriteLine($"Alert! new video was uploaded {e.Message}");
    //    }

    //    public void Subscribe(YoutubeChannel channel)
    //    {
    //        channel.VideoUploadEvent += VideoUploadEventHandler;
    //    }

    //    public void UnSubscribe(YoutubeChannel channel)
    //    {
    //        channel.VideoUploadEvent -= VideoUploadEventHandler;
    //    }
    //}
}