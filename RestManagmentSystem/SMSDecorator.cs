using System;
namespace RestManagmentSystem
{
	public class SMSDecorator : BaseDecorator
	{
		public SMSDecorator(Notification wrappee) : base(wrappee)
		{
		
		}
		
        public new void SendMessage(string msg) 
        {
			base.SendMessage(msg);
			sendSMS(msg);
		}
        private void sendSMS(String msg)
        {
            Console.WriteLine(msg + ", message sent in SMS");
        }
    }
}

