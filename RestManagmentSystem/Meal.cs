using System;
using System.Text;

namespace RestManagmentSystem
{
	public class Meal
	{
		List<MenuItem> MenuItems = new List<MenuItem>();
		StringBuilder description = new StringBuilder();
		public int seatNo { get; set; }

		public Meal()
		{
		}

		public void addItem(MenuItem item)
		{
			MenuItems.Add(item);
			description.Append(item.ItemName + " ");

		}

		public double getTotalPrice()
		{
			return MenuItems.Aggregate(0.0, (acc, mi) => acc += mi.Price);
		}
		public StringBuilder getMealDescription()
		{
			return description;
		}
	}
}