using CRM.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CRM.Controllers;

[ApiController]
[Route("[controller]")]
public class TicketController : ControllerBase
{
    private readonly ITicketService _ticketService;

    public TicketController(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            var tickets = _ticketService.GetTickets();
            return Ok(tickets);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    } 
}
