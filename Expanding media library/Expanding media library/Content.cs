using System;
using System.Collections.Generic;
using System.Text;

namespace Expanding_media_library
{
    class Content
    {
        public string _title;
        public string _description;       
        public Content(string title, string description)
        {
            Title = title;
            Description = description;
        }
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if(value == null)
                {
                    _title = "-";
                }
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if(value == null)
                {
                    _description = "-";
                }
            }
        }
        public void PrintShortInfo()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Description);
        }
    }
}
