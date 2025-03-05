using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticeSession
{
    public class Button
    {
        public delegate void ClickHandler();
        // Declare an event using the delegate
        public event ClickHandler OnClick;
        // Method to simulate button click
        public void Click()
        {
            Console.WriteLine("Button clicked!");
            // Trigger 
            OnClick?.Invoke();
        }
    }
    public class EventHandlerClass
    {
        // Remove the duplicate method
        public void ButtonClicked()
        {
            Console.WriteLine("EventHandler: Button was clicked!");
        }
    }
}
