using System;
namespace RestManagmentSystem
{
	public class MenuItem : MenuComponent
	{
		public string type { set; get; }

		public MenuItem()
		{
		}

        public MenuItem(string itemName, double price, int id, string description) : base(itemName, price, id, description)
        {

        }

        public override string getSummary()
        {
			return ItemName + " " + Description + " " + Price ;
        }
    }
}