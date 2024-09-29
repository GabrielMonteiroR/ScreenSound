using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScreenSound.Models
{
    internal class Musica
    {
        //qual campo da API externa será essa propriedade
        [JsonPropertyName("song")]
        public string Nome {  get; set; }

        [JsonPropertyName("artist")]
        public string? Artista { get; set; }

        [JsonPropertyName("duration_ms")]
        public double Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string Genero { get; set; }

        public void Details()
        {
            Console.WriteLine(Nome);
            Console.WriteLine(Artista);
            Console.WriteLine(Duracao);
            Console.WriteLine(Genero);
        }
    }
}
