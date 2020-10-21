using System;
using System.Collections.Generic;
using System.Text;

namespace Expanding_media_library
{
    class Song : Content
    {
        public string _band;
        public int _year;
        public string _album;

        public Song(string title, string description, string band, int year, string album) : base(title, description)
        {
            Band = band;
            Year = year;
            Album = album;
        }
        public string Band
        {
            get
            {
                return _band;
            }
            set
            {
                if(value == null)
                {
                    _band = "-";
                }
            }
        }
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if(value>2035)
                {
                    _year = 2035;
                }
                else if(value<1900)
                {
                    _year = 1900;
                }
                else
                {
                    _year = value;
                }
            }
        }
        public string Album
        {
            get 
            {
                return _album;
            }
            set 
            {
                if(value==null)
                {
                    _album = "-";
                }
            }
        }
        public void PrintFullInfo()
        {
            PrintShortInfo();
            Console.WriteLine($"{Band}, {Album}, {Year}");

        }
    }
}
