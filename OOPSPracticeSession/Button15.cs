using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticeSession
{
    public class Button15
    {
        public delegate void ClickHandler();
        public event ClickHandler OnClick;
        public void Click()
        {
            Console.WriteLine("Button clicked!");

            // Trigger the event if there are subscribers
            OnClick?.Invoke();
        }

    }
}
