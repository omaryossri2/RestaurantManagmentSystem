using System;
namespace RestManagmentSystem
{
	public abstract class MenuComponent
	{
		public string ItemName { get; set; }
		public double Price { get; set; }
		public int Id { get; set; }
		public string Description;

		public MenuComponent()
		{

		}

        public MenuComponent(string itemName, double price, string description)
        {
            ItemName = itemName;
            Price = price;
            Description = description;
        }

        public abstract string getSummary();
    }
}

