using System;
namespace RestManagmentSystem
{
	public class Cash : IPaymentMethod
	{
		public Cash()
		{
		}

        public bool pay(double amount)
        {
            Console.WriteLine("Paid with Cash");

            return true;
        }
    }
}

