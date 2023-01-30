using CRM.Application.Repository.Abstracts;
using CRM.Core.Entities;

namespace CRM.Application.Repository.Concretes
{
    public class NoteRepository : RepositoryBase<Note>, INoteRepository
    {
        public NoteRepository(CrmContext crmContext)
            : base(crmContext)
        {
        }

        public IEnumerable<Note> GetAllNotes()
        {
            return FindAll().ToList();
        }

        public Note GetNoteById(int id)
        {
            return FindByCondition(n => n.Id.Equals(id)).FirstOrDefault();
        }

        public void CreateNote(Note note)
        {
            Create(note);
        }

        public IEnumerable<Note> GetTicketNotes(int ticketId)
        {
            return FindAll().Where(n => n.TicketId == ticketId);
        }

        public void UpdateNote(Note note)
        {
            Update(note);
        }
    }
}