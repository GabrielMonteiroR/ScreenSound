using ScreenSound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Filters
{
    internal class LinqFilter
    {
        public static void FiltrarTodosGenerosMusicais(List<Musica> musicas)
        {
            var todosGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
            foreach (var genero in todosGenerosMusicais)
            {
                Console.WriteLine(genero);
            }
        }

        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistasPorGeneroMusical = musicas.Where(musica
                 => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
            foreach (var artista in artistasPorGeneroMusical)
            {
                Console.WriteLine(artista);
            }
        }

        public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
        {
            var musicasPorArtista = musicas.Where(musica => musica.Artista.Contains(artista)).Select(musica => musica.Nome).Distinct().ToList();

            foreach (var musica in musicasPorArtista)
            {
                Console.WriteLine(musica);
            }
        }
    }
}
