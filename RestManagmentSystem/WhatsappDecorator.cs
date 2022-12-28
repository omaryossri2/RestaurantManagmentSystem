using System;
namespace RestManagmentSystem
{
	public class WhatsappDecorator : BaseDecorator
	{
		
        public WhatsappDecorator(Notification wrappee) : base(wrappee)
        {

        }

        public new void SendMessage(string msg)
        {
            base.SendMessage(msg);
            sendWhatsapp(msg);
        }
        private void sendWhatsapp(String msg)
        {
            Console.WriteLine(msg + ", message sent in Whatsapp");
        }
    }
}

