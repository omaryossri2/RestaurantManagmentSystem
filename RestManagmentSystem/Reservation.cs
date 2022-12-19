using System;
namespace RestManagmentSystem
{
    public class Reservation
    {

        public int Id { get; set; }
        public int Status { get; set; }
        public DateTime reservationTime { get; set; }

        public Reservation()
        {
        }

        public void generateBill()
        {

        }
    }
}

