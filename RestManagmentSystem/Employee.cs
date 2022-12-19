using System;
namespace RestManagmentSystem
{
	public abstract class Employee
	{
		private String Name { get; set; }
        private String Email { get; set; }
        private String Password { get; set; }
        public Employee()
        {
            
        }
    }
}