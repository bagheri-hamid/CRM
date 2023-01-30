using CRM.Model;
using CRM.Dtos;

namespace CRM.Interfaces;

public interface INoteService
{
    IEnumerable<Note> GetNotes();
    int CreateNote(NoteDto noteDto);
    IEnumerable<Note> GetTicketNotes(int ticketId);
    int ChangeNote(int noteId, string content);
}
