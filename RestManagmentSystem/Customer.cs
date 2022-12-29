using System;
namespace RestManagmentSystem
{
	public class Customer
	{
		public string Name { set; get; }
		public string phoneNumber { set; get; }
        public string email { set; get; }
        public Customer()
		{
		}
        public Customer(string name, string phoneNumber, string email)
        {
            this.Name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

    }
}