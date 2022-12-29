using System;
using Microsoft.AspNetCore.Mvc;

namespace RestManagmentSystem.Controllers;

[ApiController]
[Route("[controller]")]
public class NotifierController : ControllerBase
{
    private readonly ILogger<NotifierController> _logger;
    private readonly MyContext _context;

    public NotifierController(ILogger<NotifierController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }
    [HttpGet]
    [Route("PostNotification")]
    public ActionResult PostNotification(string message)
    {
        Notification notification = new Notifier();
        notification.SendMessage(message);
        return StatusCode(201);
    }
}