public static class NotificationFactory
{
    public static INotificationService CreateNotification(string type)
    {
        switch (type.ToLower())
        {
            case "email":
                return new EmailNotification();

            case "sms":
                return new SMSNotification();

            case "push":
                return new PushNotification();

            default:
                throw new ArgumentException("Invalid notification type");
        }
    }
}
