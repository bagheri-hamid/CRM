using CRM.Interfaces;
using CRM.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CRM.Controllers;

[ApiController]
[Route("api/tickets")]
public class TicketController : ControllerBase
{
    private readonly ITicketService _ticketService;

    public TicketController(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllTickets()
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
    [HttpGet("getCustomerTickets")]
    public IActionResult GetCustomerTickets([FromQuery] int id)
    {
        try
        {
            var tickets = _ticketService.GetCustomerTickets(id);
            return Ok(tickets);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }    
    [HttpGet("getTicketsReport")]
    public IActionResult GetTicketsReport([FromQuery] DateTime startDate , DateTime endDate)
    {
        try
        {
            var tickets = _ticketService.GetTicketsReport(startDate, endDate);
            return Ok(tickets);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
    [HttpPost]
    public IActionResult CreateTicket([FromBody] TicketDto ticketDto)
    {
        try
        {
            var code = _ticketService.CreateTicket(ticketDto);
            if (code == 1)
                return BadRequest("UserId not found");
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    [HttpPut("assginTicket")]
    public IActionResult AssignTicket([FromQuery] int teamMemberId , int ticketId)
    {
        try
        {
            var code = _ticketService.AssignTicket(teamMemberId,ticketId);
            if (code == 1)
                return BadRequest("TeamMemberId not found");
            else if (code == 2)
                return BadRequest("TicketId not found");
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    [HttpPut("closeTicket")]
    public IActionResult CloseTicket([FromQuery]int ticketId)
    {
        try
        {
            var code = _ticketService.CloseTicket(ticketId);
            if (code == 1)
                return BadRequest("TicketId not found");
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    [HttpPut("reopenTicket")]
    public IActionResult ReopenTicket([FromQuery] int ticketId)
    {
        try
        {
            var code = _ticketService.ReopenTicket(ticketId);
            if (code == 1)
                return BadRequest("TicketId not found");
            else if (code == 2)
                return BadRequest("Ticket is not Closed !");
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }    
    [HttpPut("resolveTicket")]
    public IActionResult ResolveTicket([FromQuery] int ticketId)
    {
        try
        {
            var code = _ticketService.ResolveTicket(ticketId);
            if (code == 1)
                return BadRequest("TicketId not found");
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
}
