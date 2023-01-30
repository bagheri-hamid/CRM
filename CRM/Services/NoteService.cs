using CRM.Dtos;
using CRM.Interfaces;
using CRM.Model;
using System.Data;

namespace CRM.Services;


public class NoteService : INoteService
{
    private readonly IRepositoryWrapper _repo;

    public NoteService(IRepositoryWrapper repo)
    {
        _repo = repo;
    }

    public IEnumerable<Note> GetNotes()
    {
        return _repo.Note.GetAllNotes();
    }
    public int CreateNote(NoteDto noteDto)
    {
        var ticket = _repo.Ticket.GetTicketById(noteDto.TicketId);
        if (ticket is null)
        {
            return 1;
        }
        var note = new Note(noteDto.TicketId , noteDto.Content);
        _repo.Note.CreateNote(note);
        _repo.Save();
        return 0;
    }
    public IEnumerable<Note> GetTicketNotes(int ticketId)
    {
        return _repo.Note.GetTicketNotes(ticketId);
    }

    public int ChangeNote(int noteId, string content)
    {
        var note = _repo.Note.GetNoteById(noteId);
        if (note is null)
        {
            return 1;
        }
        note.Content = content;
        _repo.Note.UpdateNote(note);
        _repo.Save();
        return 0;
    }
}
