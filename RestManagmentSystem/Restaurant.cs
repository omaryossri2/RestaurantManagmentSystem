using System;
namespace RestManagmentSystem
{
	public class Restaurant
	{
		public String name {set; get;}
		List<Branch> branches = new List<Branch>();
		public Restaurant()
		{

		}
		public void addBranch(Branch branch)
		{
			branches.Add(branch);
		}
	}
}

