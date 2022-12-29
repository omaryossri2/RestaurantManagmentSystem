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
}