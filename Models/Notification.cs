public class Notification
{
    public string Recipient { get; set; }
    public string Message { get; set; }

    public Notification(string recipient, string message)
    {
        Recipient = recipient;
        Message = message;
    }
}
