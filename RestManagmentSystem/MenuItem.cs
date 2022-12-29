using System;
namespace RestManagmentSystem
{
	public class MenuItem : MenuComponent
	{
		public string type { set; get; }
        public int id { set; get; }
        public MenuItem()
		{
		}

        public MenuItem(string itemName, double price, string description) : base(itemName, price, description)
        {

        }

        public override string getSummary()
        {
			return ItemName + " " + Description + " " + Price ;
        }
    }
}