using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScreenSound.Models
{
    internal class MusicasPreferidas
    {
        public string? Nome { get; set; }
        public List<Musica> ListaDeMusicasFavoritas { get; }

        public MusicasPreferidas(string nome)
        {
            Nome = nome;
            ListaDeMusicasFavoritas = new List<Musica>();
        }

        public void AdicionarMusicasFavoritas(Musica musica)
        {
            ListaDeMusicasFavoritas.Add(musica);
        }

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine("LISTA DE MUSICAS FAVORITAS: ");
            foreach (var musica in ListaDeMusicasFavoritas)
            {
                Console.WriteLine(musica.Nome);
            }
        }

        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = ListaDeMusicasFavoritas
            });
            string nomeDoArquivo = $"musicas-favoritas-{Nome}.Json";
            File.WriteAllText(nomeDoArquivo, json);
            Console.WriteLine("Arquivo JSON CRIADO COM SUCESSO");
            Console.WriteLine(Path.GetFullPath(nomeDoArquivo));

        }
    }
}
