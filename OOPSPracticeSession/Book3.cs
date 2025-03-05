using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPSPracticeSession;

namespace OOPSPracticeSession
{
    public class Book3
    {
        private string Title;
        private string Author;
        private string ISBN;

        public Book3()
        {
            Title = "No Title";
            Author = "No Author";
            ISBN = "No ISBN";
        }
        public Book3(string title, string author)
        {
            Title = title;
            Author = author;
            ISBN = "No ISBN";
        }
        public Book3(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        }
    }
}
