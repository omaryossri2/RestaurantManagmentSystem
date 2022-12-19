using System;
namespace RestManagmentSystem
{
	public class Order
	{
		public readonly List<Meal> Meals = new List<Meal>();
		public string Id { get; set; }

		public Order()
		{
		}

        public Order(string orderNo)
        {
            Id = orderNo;
        }

		public double getTotalPrice()
		{
            return Meals.Aggregate(0.0, (acc, mi) => acc += mi.getTotalPrice());
        }
    }
}

