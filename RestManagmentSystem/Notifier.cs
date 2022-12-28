using System;
namespace RestManagmentSystem
{
    public class Notifier : Notification
    {
        public Notifier()
        {
        }

        void Notification.SendMessage(string msg)
        {
            Console.WriteLine(msg + ", message sent in email");
        }
    }
}

