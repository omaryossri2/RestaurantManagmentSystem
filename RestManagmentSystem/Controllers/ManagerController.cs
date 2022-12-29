using System;
using System;
using Microsoft.AspNetCore.Mvc;

namespace RestManagmentSystem.Controllers;

[ApiController]
[Route("[controller]")]
public class ManagerController : ControllerBase
{
    Manager manager = new Manager();
    private readonly ILogger<ManagerController> _logger;
    private readonly MyContext _context;

    public ManagerController(ILogger<ManagerController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }
    [HttpPost]
    [Route("CreateTable")]
    public ActionResult CreateTable(int branchId, int numOfSeats)
    {
        manager.createTable(branchId, numOfSeats);
        return StatusCode(201);
    }
    [HttpGet]
    [Route("GetReservationWithId")]
    public Reservation GetReservationWithId(int branchId, int ReservationId)
    {
        return Restaurant.branches[branchId].GetReservation(ReservationId);
    }
    [HttpGet]
    [Route("GetMenuItems")]
    public Menu GetMenu(int branchID)
    {
        return Restaurant.branches[branchID].menu;
    }

    [HttpPost]
    [Route("PostMenuItems")]
    public ActionResult PostMenuItems(int branchId, string name,double price, string description)
    {
        MenuItem menuItem = new MenuItem (name,price,description);
        Restaurant.branches[branchId].menu.add(menuItem);
        return StatusCode(201);
    }

}
