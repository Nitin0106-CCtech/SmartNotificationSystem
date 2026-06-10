class Program
{
    static void Main()
    {
        Console.WriteLine("===== Smart Notification System =====");

        Console.Write("Enter Notification Type (Email/SMS/Push): ");
        string? type = Console.ReadLine();

        Console.Write("Enter Recipient: ");
        string? recipient = Console.ReadLine();

        Console.Write("Enter Message: ");
        string? message = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(type) ||
            string.IsNullOrWhiteSpace(recipient) ||
            string.IsNullOrWhiteSpace(message))
        {
            Console.WriteLine("All fields are required. Please restart the application and try again.");
            return;
        }

        Notification notification =
            new Notification(recipient, message);

        INotificationService service =
            NotificationFactory.CreateNotification(type.Trim());

        service.SendNotification(notification);

        Console.ReadLine();
    }
}
