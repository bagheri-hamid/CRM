using CRM.Core.Entities;


namespace CRM.Application.Repository.Abstracts;

public interface INoteRepository : IRepositoryBase<Note>
{
    IEnumerable<Note> GetAllNotes();
    void CreateNote(Note note);
    IEnumerable<Note> GetTicketNotes(int ticketId);
    void UpdateNote(Note note);
    Note GetNoteById(int id);
}
