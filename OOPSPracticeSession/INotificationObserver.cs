using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticeSession
{
    public interface INotificationObserver
    {
        void Update(string message);
    }
    public class EmailNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Email Notification: {message}");
        }
    }

    public class SMSNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"SMS Notification: {message}");
        }
    }

    // Step 3: Define the Subject Interface
    public interface INotificationSubject
    {
        void Attach(INotificationObserver observer);
        void Detach(INotificationObserver observer);
        void Notify(string message);
    }

    // Step 4: Implement Concrete Subject (Notification Service)
    public class NotificationService : INotificationSubject
    {
        private List<INotificationObserver> observers = new List<INotificationObserver>();

        public void Attach(INotificationObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(INotificationObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }
    }
}
