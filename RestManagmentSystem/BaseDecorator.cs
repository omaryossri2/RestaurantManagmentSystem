using System;
namespace RestManagmentSystem
{
	public class BaseDecorator : Notification
	{
        private Notification wrappee;
        public BaseDecorator(Notification wrappee)
		{
            this.wrappee = wrappee;
		}

        public void SendMessage(string msg)
        {
            wrappee.SendMessage(msg);
        }
    }
}

