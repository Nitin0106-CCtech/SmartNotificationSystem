public class SMSNotification : INotificationService
{
    public void SendNotification(Notification notification)
    {
        Console.WriteLine(
            $"SMS sent to {notification.Recipient}");
        Console.WriteLine(
            $"Message: {notification.Message}");
    }
}
