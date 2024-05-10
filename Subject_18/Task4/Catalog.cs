using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Catalog
    {
        private Hashtable albums;

        public Catalog()
        {
            albums = new Hashtable();
        }

        public void AddAlbum(string albumName, List<string> songs)
        {
            albums[albumName] = songs;
        }

        public void RemoveAlbum(string albumName)
        {
            albums.Remove(albumName);
        }

        public void AddSong(string albumName, string song)
        {
            if (albums.ContainsKey(albumName))
            {
                ((List<string>)albums[albumName]).Add(song);
            }
        }

        public void RemoveSong(string albumName, string song)
        {
            if (albums.ContainsKey(albumName))
            {
                ((List<string>)albums[albumName]).Remove(song);
            }
        }

        public void PrintCatalog()
        {
            foreach (DictionaryEntry album in albums)
            {
                Console.WriteLine($"Album: {album.Key}");
                foreach (string song in (List<string>)album.Value)
                {
                    Console.WriteLine($"  Song: {song}");
                }
            }
        }
    }
}
