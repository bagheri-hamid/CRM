namespace CRM.Core.Entities;

public partial class Note
{
    public int Id { get; set; }
    public int TicketId { get; set; }
    public string Content { get; set; } = null!;

    public Note(int ticketId, string content)
    {
        TicketId = ticketId;
        Content = content;
    }
}
