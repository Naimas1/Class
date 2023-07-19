using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Film
    {
        public string Title { get; set; }
        public string Studio { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public int Year { get; set; }

        public Film(string title, string studio, string genre, int duration, int year)
        {
            Title = title;
            Studio = studio;
            Genre = genre;
            Duration = duration;
            Year = year;
        }

        public void Play()
        {
            Console.WriteLine("Фільм {0} почав програватись.", Title);
        }

        public void Stop()
        {
            Console.WriteLine("Фільм {0} зупинився.", Title);
        }

        ~Film()
        {
            Console.WriteLine("Об'єкт {0} був знищений.", Title);
        }
    }

    class Programe
    {
        static void Main(string[] args)
        {
            Film film = new Film("Фільм 1", "Кіностудія 1", "Жанр 1", 120, 2021);

            film.Play();
            film.Stop();

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}
