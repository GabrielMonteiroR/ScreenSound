using ScreenSound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Filters
{
    internal class LinqOrder
    {
        public static void ExibirListaDeArtistasOrdenado(List<Musica> musicas)
        {
            var artistasOrdenados = musicas.OrderBy(musicas => musicas.Artista).Select(musica => musica.Artista).Distinct().ToList();
            foreach (var music in artistasOrdenados)
            {
                Console.WriteLine(music);
            }
        }
    }
}
