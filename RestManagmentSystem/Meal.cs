using System;
using System.Text;

namespace RestManagmentSystem
{
	public class Meal
	{
		List<MenuItem> MealItems = new List<MenuItem>();
		StringBuilder description = new StringBuilder();
		public int seatNo { get; set; }

		public Meal()
		{
		}

		public void addItem(MenuItem item)
		{
			MealItems.Add(item);
			description.Append(item.ItemName + " ");

		}

		public double getTotalPrice()
		{
			return MealItems.Aggregate(0.0, (acc, mi) => acc += mi.Price);
		}
		public StringBuilder getMealDescription()
		{
			return description;
		}
	}
}