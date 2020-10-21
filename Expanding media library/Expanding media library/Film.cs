using System;
using System.Collections.Generic;
using System.Text;

namespace Expanding_media_library
{
    class Film : Content
    {
        public string _directors;
        
        public Film(string title, string description, string director) : base(title, description)

        {
            Director = director;
            Actors = new List<string>();
        }
        public string Director
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
        public List<string> Actors { get; set; }
        
        public void PrintFullInfo()
        {
            PrintShortInfo();
            Console.WriteLine($"Director: {Director}");

            Console.WriteLine("Actors:");
            foreach (string actor in Actors)
            {
                Console.WriteLine(actor);
            }
        }
    }
}
