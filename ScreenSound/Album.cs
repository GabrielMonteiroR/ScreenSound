using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Album
    {
        public string Name { get; set; }
        public new List<Music> musics { get; set; }

        public Album()
        {
            musics = new List<Music>();
        }


        public void AddMusic(Music music)
        {
            musics.Add(music);
        }

        public void ShowMusics(Album album)
        {
            foreach (var music in album.musics)
            {
                Console.WriteLine(music.Name);
            }
        }
    }
}
