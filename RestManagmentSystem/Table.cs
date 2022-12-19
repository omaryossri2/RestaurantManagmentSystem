using System;
namespace RestManagmentSystem
{
	public class Table
	{

        public int Id { get; set; }

        public int numOfSeats { get; set; }
        public bool isAvailable { get; set; }
        private Order _order;


        public Table()
		{
		}


        public void createNewOrder()
        {
            this._order = new Order(Guid.NewGuid().ToString());
        }

        public Order GetOrder()
        {
            return this._order;
        }


	}
}

