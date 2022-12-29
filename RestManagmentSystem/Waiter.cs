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
		public void AddMealToOrder(int branchId, int TableId, Meal meal)
		{
			Restaurant.branches[branchId].tables[TableId]._order.addMeal(meal);
		}
		public void addOrder(int branchId, int TableId, Order order)
		{
			Restaurant.branches[branchId].tables[TableId].addOrder(order);
        }
    }
}

