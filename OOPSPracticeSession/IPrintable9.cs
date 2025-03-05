using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticeSession
{
    interface IPrintable9
    {
        void Print();
    }
    interface ISerializable
    {
        void Save(string filename); // Method for saving to a file
    }

    class Report : IPrintable9, ISerializable
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Report(string title, string content)
        {
            Title = title;
            Content = content;
        }

        // Implementing IPrintable
        public void Print()
        {
            Console.WriteLine($"Report Title: {Title}");
            Console.WriteLine($"Report Content: {Content}");
        }

        // Implementing ISerializable
        public void Save(string filename)
        {
            File.WriteAllText(filename, $"Title: {Title}\nContent: {Content}");
            Console.WriteLine($"Report saved to {filename}");
        }
    }
}
