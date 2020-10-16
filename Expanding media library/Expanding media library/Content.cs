using System;
using System.Collections.Generic;
using System.Text;

namespace Expanding_media_library
{
    class Content
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Content(string title, string description)
        {
            Title = title;
            Description = description;
        }
        public void PrintShortInfo()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Description);
        }
    }
}
