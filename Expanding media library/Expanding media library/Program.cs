using System;
using System.Collections.Generic;

namespace Expanding_media_library
{
    class Program
    {
        static void Main(string[] args)
        {
            Film film = new Film("James Cameron ", "Terminator", "Is an American sci - fi film from 1984 directed by James Cameron. In the center of the plot is the confrontation between a soldier and a terminator robot, who arrived in 1984 from the post-apocalyptic year 2029.");
            Photo photo = new Photo("Alps", "Alps in the snow", 2835, 3602);
            Song song = new Song("Esterday", "Yesterday it seemed that all the problems were far away, but now the girl left for some unknown reason and where, and everything became completely different. It came so suddenly yesterday.How I would like to return yesterday to change everything", "Beatels", 1962, "Help!");
            Book book = new Book("Post-apocalyptic novel by Dmitry Glukhovsky, describing the life of people in the Moscow metro after a nuclear war on Earth.", "Metro 2033", "Dmitry Glukhovsky", 605);
            //============================================================
            film.Actors = new List<string>();
            film.Actors.Add ("Michael Bean");
            film.Actors.Add("Kyle Reese");
            film.Actors.Add("Arnold Schwarzenegger");
            //============================================================
            Console.WriteLine("Медиа-библиотека. Содержимое:");
            Console.WriteLine("============================");
            film.PrintFullInfo();
            Console.WriteLine("============================");
            photo.PrintFullInfo();
            Console.WriteLine("============================");
            song.PrintFullInfo();
            Console.WriteLine("============================");
            book.PrintFullInfo();
        }
    }
}
