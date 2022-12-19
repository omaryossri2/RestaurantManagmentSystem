using System;
namespace RestManagmentSystem
{
	public class Visa : IPaymentMethod
	{
		public Visa()
		{
		}

        public bool pay(double amount)
        {
            Console.WriteLine("Paid with visa");

            return true;
        }
    }
}

