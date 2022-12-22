using System;
using Microsoft.EntityFrameworkCore;

namespace RestManagmentSystem
{
    public class Waiter : Employee
    {
        private readonly MyContext _context;

        public Waiter(MyContext context)
        {
            _context = context;
        }

        public void createOrder()
        {

        }

        public void updateOrder()
        {

        }

        public List<Reservation> Get()
        {
            return _context.Reservations.ToList();
        }
    }
}

