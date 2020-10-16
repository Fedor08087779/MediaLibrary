using System;
using System.Collections.Generic;
using System.Text;

namespace Expanding_media_library
{
    class Song : Content
    {
        public string Band { get; set; }
        public int Year { get; set; }
        public string Album { get; set; }
        public Song(string title, string description, string band, int year, string album) : base(title, description)
        {
            Band = band;
            Year = year;
            Album = album;
        }
        public void PrintFullInfo()
        {
            PrintShortInfo();
            Console.WriteLine($"{Band}, {Album}, {Year}");

        }
    }
}
