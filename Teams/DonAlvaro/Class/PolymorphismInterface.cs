using System.Collections.Generic;

namespace PolymorphismInterface
{
    public interface INotificationChannel
    {
        void Send(Message message);
    }

    public class Video
    {


    }

    class Program
    {
        static void main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel()); 

            //Polymorphic Behaviour occurs at Different Concrete Classes calling 
            //Send method with different implementations in each Different Concrete Class

            encoder.Encode(new Video());
        }
    }

    public class VideoEncoder
    {
        //private readonly MailService _mailService; //PROBLEM: Type Dependency of VideoEncoder class to MailService
        private readonly IList<INotificationChannel> _notificationChannels; //new implementations of of INotificationChannel sms/mail

        public VideoEncoder() //Better to have a constructor that accepts an interface than using concrete class
        {
            //_mailService = new MailService();
            _notificationChannels = new List<INotificationChannel>();  //OCP Principle
        }

        public void Encode(Video video)
        {
            //Video Encoding Logic
            //...

            //_mailService.Send(new Mail());

            foreach (var item in _notificationChannels)
            {
                item.Send(new Message());
            }
            
        }
        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }

    }

    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending SMS...");
        }
    }

    public class Message
    {
    }

    public class MailService
    {
     //   public void Send(Mail mail)
        //{
        //    Console.WriteLine("Sending email...");

        //}


    }

    public class MailNotificationChannel:INotificationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending Mail...");
        }
    }

    

}
