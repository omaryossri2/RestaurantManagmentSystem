using System;
namespace RestManagmentSystem
{
	public class Branch
	{
		public List<Table> tables = new List<Table>();
		public String branchLocation { set; get; }
		public List<Reservation> reservations = new List<Reservation>();
		int id;
		public Menu menu;
		public Branch(string branchLocation)
		{
			this.branchLocation = branchLocation;
		}
		public void addTable(Table table)
		{
			tables.Add(table);
		}
        public Table GetTable(int id)
        {
			return tables[id];
        }
		public void addReservation(DateTime dateTime, string name, string phoneNumber, string email)
		{
			Reservation reservation = new Reservation();
			reservation.reservationTime = dateTime;
			reservation.customer = new Customer(name,phoneNumber, email);
			reservation.Id = reservations.Count + 1;
			reservation.Status = 0;
			reservations.Add(reservation);
		}
		public List<Reservation> getAllReservations()
		{
			return reservations;
		}
		public Reservation GetReservation(int ReservationId)
		{
			return reservations[ReservationId];
		}
		
    }
}