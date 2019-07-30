using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RiderIssue.Api.Data;

namespace RiderIssue.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ILogger<TicketsController> _log;
        private readonly ApplicationContext _db;
        private readonly Random _random;
        
        public TicketsController(ILogger<TicketsController> logger, ApplicationContext db)
        {
            _log = logger;
            _db = db;
            _random = new Random();
        }

        [HttpGet]
        public IActionResult Get()
        {
            _log.LogInformation("Get all tickets from database");
            var tickets = _db.Tickets.ToList();
            return new OkObjectResult(tickets);
        }
    }
}