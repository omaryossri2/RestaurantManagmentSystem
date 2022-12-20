using System;
namespace RestManagmentSystem
{
	public interface IPaymentMethod
	{ 
		public bool pay(double amount);
	}
}

