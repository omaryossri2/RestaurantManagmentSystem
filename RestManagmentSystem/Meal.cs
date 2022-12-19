using System;
namespace RestManagmentSystem
{
	public class Meal
	{
		List<MenuItem> MealItems = new List<MenuItem>();
		public int seatNo { get; set; }

		public Meal()
		{
		}

		public void addItem(MenuItem item)
		{
			MealItems.Add(item);
		}

		public double getTotalPrice()
		{
			return MealItems.Aggregate(0.0, (acc, mi) => acc += mi.Price);
		}
	}
}

