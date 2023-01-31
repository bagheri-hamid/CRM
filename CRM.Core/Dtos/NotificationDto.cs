namespace CRM.Dtos
{
    public class NotificationDto
    {
        public int Type { get; set; }
        public string Message { get; set; }
        public int RecipientId { get; set; }
    }
}
