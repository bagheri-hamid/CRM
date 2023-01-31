namespace CRM.Core.Entities
{
    public class Notification
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Message { get; set; }
        public int RecipientId { get; set; }

        public Notification(int type, string message, int recipientId)
        {
            Type= type;
            Message= message;
            RecipientId= recipientId;
        }
    }
}
