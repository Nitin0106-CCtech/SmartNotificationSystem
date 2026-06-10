public class PushNotification : INotificationService
{
    public void SendNotification(Notification notification)
    {
        Console.WriteLine(
            $"Push Notification sent to {notification.Recipient}");
        Console.WriteLine(
            $"Message: {notification.Message}");
    }
}
