using System;
using System;
using Microsoft.AspNetCore.Mvc;

namespace RestManagmentSystem.Controllers;

[ApiController]
[Route("[controller]")]
public class WaiterController : ControllerBase
{
    private readonly ILogger<WaiterController> _logger;
    private readonly MyContext _context;

    public WaiterController(ILogger<WaiterController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }
    Waiter waiter = new Waiter();
    [HttpPost]
    [Route("CreateOrder")]
    public ActionResult TakeOrder(int branchId, int tableNo)
    {
        waiter.CreateOrder(branchId, tableNo);
        return StatusCode(201);
    }
    [HttpPost]
    [Route("PostMealToOrder")]
    public ActionResult PostMealToOrder(int branchId, int tableNo, int MenuItemId)
    {
        MenuComponent? item = Restaurant.branches[branchId].menu.getChild(MenuItemId);
        Meal meal = new Meal();
        meal.addItem((MenuItem)item);
        waiter.AddMealToOrder(branchId, tableNo, meal);
        return StatusCode(201);
    }

}
