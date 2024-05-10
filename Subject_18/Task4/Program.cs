using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();


            catalog.AddAlbum("Album1", new List<string> { "Song1", "Song2" });

            catalog.AddAlbum("Album2", new List<string> { "Song5", "Song6" });

            catalog.AddSong("Album1", "Song3");

            catalog.PrintCatalog();

            catalog.RemoveSong("Album1", "Song2");

            catalog.PrintCatalog();

            catalog.RemoveAlbum("Album1");

            catalog.PrintCatalog();

            Console.ReadLine();
        }
    }
}
