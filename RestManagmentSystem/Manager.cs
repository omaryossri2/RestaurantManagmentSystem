using System;
namespace RestManagmentSystem
{
	public class Manager
	{
		public Manager()
		{

		}

		public void addEmployee(Employee emp)
		{

		}

		public void modifyMenu()
		{

		}
		public void createTable(int branchId, int numOfSeats)
		{
			Table table = new Table(numOfSeats);
			Restaurant.branches[branchId].addTable(table);
		}
	}
}
