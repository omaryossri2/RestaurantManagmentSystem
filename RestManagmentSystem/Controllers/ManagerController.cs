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

}
