using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Piece
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public Piece(string name, string author, string genre, int year)
        {
            Name = name;
            Author = author;
            Genre = genre;
            Year = year;
        }
        ~Piece()
        {
            Console.WriteLine("Об'єкт {0} був знищений.", Name);
        }
        public override string ToString()
        {
            return string.Format("Назва: {0}, Автор: {1}, Жанр: {2}, Рік: {3}", Name, Author, Genre, Year);
        }
    }

    class Programx
    {
        static void Main(string[] args)
        {
            Piece piece = new Piece("П'єса 1", "Автор 1", "Жанр 1", 2021);

            Console.WriteLine(piece);

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}
