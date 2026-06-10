public class EmailNotification : INotificationService
{
    public void SendNotification(Notification notification)
    {
        Console.WriteLine(
            $"Email sent to {notification.Recipient}");
        Console.WriteLine(
            $"Message: {notification.Message}");
    }
}
