using System;
namespace RestManagmentSystem
{
	public class Waiter : Employee
	{
		public Waiter()
		{
		}
		public void CreateOrder(int branchId, int TableId)
		{
			Restaurant.branches[branchId].tables[TableId].createNewOrder();
		}
		public Order MakeOrderOutOfMeals(List<Meal>meals)
		{
			Order order= new Order();
			order.Meals = meals;
			return order;
		}
		public void addToOrder(int branchId, int TableId, Order order)
		{
			Restaurant.branches[branchId].tables[TableId].addOrder(order);
        }
    }
}

