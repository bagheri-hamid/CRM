using CRM.Interfaces;
using CRM.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CRM.Controllers;

[ApiController]
[Route("api/notes")]
public class NotesController : ControllerBase
{
    private readonly INoteService _noteService;

    public NotesController(INoteService noteService)
    {
        _noteService = noteService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllNotes()
    {
        try
        {
            var notes = _noteService.GetNotes();
            return Ok(notes);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getTicketNotes")]
    public IActionResult GetTicketNotes([FromQuery] int ticketId)
    {
        try
        {
            var notes = _noteService.GetTicketNotes(ticketId);
            return Ok(notes);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
    [HttpPost]
    public IActionResult CreateNote([FromBody] NoteDto noteDto)
    {
        try
        {
            var code = _noteService.CreateNote(noteDto);
            if (code == 1)
                return BadRequest("TicketId not found");
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    [HttpPut("ChangeNote")]
    public IActionResult ChangeNote([FromQuery] int noteId , string content)
    {
        try
        {
            var code = _noteService.ChangeNote(noteId,content);
            if (code == 1)
                return BadRequest("NoteId not found");
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
}
