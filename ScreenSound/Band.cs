using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Band
    {
        public string Name;
        private List<Album> albums;

        public Band()
        {
            albums = new List<Album>();
        }

        public void AddAlbum(Album album)
        {
            albums.Add(album);
        }

        public void ShowAllBandDisks()
        {
            foreach (var music in albums)
            {
                Console.WriteLine($"BANDA: {Name}");
                Console.WriteLine($"MUSICAS: {music.Name}");
            }
        }
    }
}
