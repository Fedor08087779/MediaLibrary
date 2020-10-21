using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Expanding_media_library
{
    class Book : Content
    {
        public string _author;
        public int _numberPages;
        
        public Book(string title, string description, string author, int numberPages) :base(title, description)
        {
            Author = author;
            NumberPages = numberPages;
        }
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                if(value == null)
                {
                    _author = "-";
                }
            }
        }
        public int NumberPages
        {
            get
            {
                return _numberPages;
            }
            set
            {
                if(value>9000)
                {
                    _numberPages = 9000;
                }
                else if(value<5)
                {
                    _numberPages = 5;
                }
                else
                {
                    _numberPages = value;
                }
            }
        }
        public void PrintFullInfo()
        {
            PrintShortInfo();
            Console.WriteLine($"Author: {Author}, Number of pages: {NumberPages}");
        }
    }
}
