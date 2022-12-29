using System;
using Microsoft.AspNetCore.Mvc;

namespace RestManagmentSystem.Controllers;

[ApiController]
[Route("[controller]")]
public class ReservationController : ControllerBase
{
    private readonly ILogger<ReservationController> _logger;
    private readonly MyContext _context;

    public ReservationController(ILogger<ReservationController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }
    [HttpPost]
    [Route("PostNewReservation")]
    public ActionResult PostNewReservation(int branchID, DateTime dateTime, string name, string phoneNumber, string email)
    {
        Restaurant.branches[branchID].addReservation(dateTime, name, phoneNumber, email);
        return StatusCode(201);
    }
    [HttpGet]
    [Route("GetAllReservation")]
    public List<Reservation> GetAllReservation(int branchId)
    {
        return Restaurant.branches[branchId].getAllReservations();
    }

    [HttpGet]
    [Route("GetReservationWithId")]
    public Reservation GetReservationWithId(int branchId, int ReservationId)
    {
        return Restaurant.branches[branchId].GetReservation(ReservationId);
    }

    [HttpGet]
    [Route("GetAllAvaialbleTables")]
    public List<Table> GetAllAvaialbleTables(int branchId)
    {
        List<Table> AvialableTables = new List<Table>();
        for(int i = 0; i < Restaurant.branches[branchId].tables.Count; i++)
        {
            if (DateTime.Now < Restaurant.branches[branchId].tables[i].reservation.reservationTime)
            {
                Restaurant.branches[branchId].tables[i].isAvailable = true;
                AvialableTables.Add(Restaurant.branches[branchId].tables[i]);
            }
        }
        return Restaurant.branches[branchId].tables;
    }


}