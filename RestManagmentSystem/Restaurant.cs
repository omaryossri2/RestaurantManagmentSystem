using System;
namespace RestManagmentSystem
{
	public class Restaurant
	{
		public String name {set; get;}
		public static List<Branch> branches = new List<Branch>();
		public Restaurant()
		{

		}
		public static void addBranch(Branch branch)
		{
			branches.Add(branch);
		}
		public static Branch GetBranch(int id)
		{
			return branches[id];
		}
	}
}

