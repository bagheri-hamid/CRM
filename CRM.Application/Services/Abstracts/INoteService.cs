using CRM.Dtos;
using CRM.Core.Entities;

namespace CRM.Application.Services.Abstracts;

public interface INoteService
{
    IEnumerable<Note> GetNotes();
    int CreateNote(NoteDto noteDto);
    IEnumerable<Note> GetTicketNotes(int ticketId);
    int ChangeNote(int noteId, string content);
}
