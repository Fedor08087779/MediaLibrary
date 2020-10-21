using System;
using System.Collections.Generic;
using System.Text;

namespace Expanding_media_library
{
    class Photo : Content
    {
        public int _height;
        public int _width;
        public Photo(string title, string description, int height, int width) : base(title, description)
        {
            Height = height;
            Width = width;
        }
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value > 5000)
                {
                    _height = 5000;
                }
                else if (value < 1)
                {
                    _height = 1;
                }
                else 
                {
                    _height = value;
                }

            }
        }
        public int Width
        {
            get 
            {
                return _width;
            }
            set 
            {
                if (value > 5000)
                {
                    _width = 5000;
                }
                else if (value < 1)
                {
                    _width = 1;
                }
                else
                {
                    _width = value;
                }
            }


        }
        public void PrintFullInfo()
        {
            PrintShortInfo();
            Console.WriteLine($"{Height} x {Width}");
        }
    }
}
