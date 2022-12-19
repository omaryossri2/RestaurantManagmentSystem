using System;
namespace RestManagmentSystem
{
	public class Restaurant
	{
		public String name {set; get;}
		List<Branch> branches;
		public Restaurant()
		{

		}
		public void addBranch(Branch branch)
		{
			branches.Add(branch);
		}
	}
}

