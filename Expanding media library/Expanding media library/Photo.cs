using System;
using System.Collections.Generic;
using System.Text;

namespace Expanding_media_library
{
    class Photo : Content
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Photo(string title, string description, int height, int width) : base(title, description)
        {
            Height = height;
            Width = width;
        }
        public void PrintFullInfo()
        {
            PrintShortInfo();
            Console.WriteLine($"{Height} x {Width}");
        }
    }
}
