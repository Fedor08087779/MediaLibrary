using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Expanding_media_library
{
    class Book : Content
    {
        public string Author { get; set; }
        public int NumberPages { get; set; }
        public Book(string title, string description, string author, int numberPages) :base(title, description)
        {
            Author = author;
            NumberPages = numberPages;
        }
        public void PrintFullInfo()
        {
            PrintShortInfo();
            Console.WriteLine($"Author: {Author}, Number of pages: {NumberPages}");
        }
    }
}
