using System;
namespace RestManagmentSystem
{
	public class Table
	{

        public int Id { get; set; }
        public int numOfSeats { get; set; }
        public bool isAvailable{ get; set; }
        public Order _order { get; set; }
        public Reservation reservation;

        public Table()
		{

		}
        public Table(int numOfSeats)
        {
            this.numOfSeats = numOfSeats;
        }

        public void createNewOrder()
        {
            this._order = new Order(Guid.NewGuid().ToString());
        }

        public Order GetOrder()
        {
            return this._order;
        }
        public void addOrder(Order order)
        {
            this._order = order;
        }
	}
}