using System;
namespace RestManagmentSystem
{
	public class Bill
	{
		public Order Order { get; set; }
		public IPaymentMethod PaymentMethod;

		public Bill(Order order, IPaymentMethod paymentMethod)
		{
			Order = order;
			PaymentMethod = paymentMethod;
        }

		public void payOrder()
		{
            PaymentMethod.pay(Order.getTotalPrice());
		}

	}
}

