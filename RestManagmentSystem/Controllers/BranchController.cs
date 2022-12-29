using System;
using System;
using Microsoft.AspNetCore.Mvc;

namespace RestManagmentSystem.Controllers;

[ApiController]
[Route("[controller]")]
public class BranchController : ControllerBase
{
    private readonly ILogger<BranchController> _logger;
    private readonly MyContext _context;

    public BranchController(ILogger<BranchController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }
    [HttpPost]
    [Route("PostNewBranch")]
    public ActionResult PostNewBranch(string BranchLoaction)
    {
        Branch branch = new Branch(BranchLoaction);
        Restaurant.branches.Add(branch);
        return StatusCode(201);
    }

}


