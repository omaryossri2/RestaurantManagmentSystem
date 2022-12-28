using System;
namespace RestManagmentSystem
{
	public class Cashier
	{
		Dictionary<int, Bill> Pendingbills = new Dictionary<int, Bill>();
		public Cashier()
		{
		}

        public void generateBill(Order order, IPaymentMethod PaymentMethod)
        {
			Bill bill = new Bill(order, PaymentMethod);
            Pendingbills.Add(order.GetHashCode(), bill);
        }
        public void PayBill(int OrderNumber)
        {
            Bill bill = Pendingbills[OrderNumber];
            bill.payOrder();
            Pendingbills.Remove(OrderNumber);
        }

    }
}

