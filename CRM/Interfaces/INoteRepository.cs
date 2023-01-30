using CRM.Model;


namespace CRM.Interfaces;

public interface INoteRepository : IRepositoryBase<Note>
{
    IEnumerable<Note> GetAllNotes();
    void CreateNote(Note note);
    IEnumerable<Note> GetTicketNotes(int ticketId);
    void UpdateNote(Note note);
    Note GetNoteById(int id);
}
