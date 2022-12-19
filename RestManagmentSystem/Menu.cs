using System;
namespace RestManagmentSystem
{
	public class Menu : MenuComponent
	{
        private readonly List<MenuComponent> _menuComponents = new List<MenuComponent>();
		public Menu()
		{
		}

        public Menu(string itemName, double price, int id, string description) : base(itemName, price, id, description)
        {

        }


        public void add(MenuComponent menuComponent) {
            _menuComponents.Add(menuComponent);
        }

        public void remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public MenuComponent? getChild(int Id)
        {
            return _menuComponents.Find(m => m.Id == Id);
        }

        public override string getSummary()
        {
            return _menuComponents.Aggregate("", (acc, menuComponent) => acc += menuComponent.getSummary() + "\n");
        }
    }
}

