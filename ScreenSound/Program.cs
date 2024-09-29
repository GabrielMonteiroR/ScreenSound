using ScreenSound.Models;
using ScreenSound.Filters;
using System.Text.Json;

// Fazendo requisição na api
try
{
    using HttpClient client = new HttpClient();
    string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

    // Configurando o JsonSerializer para ignorar diferenciação de maiúsculas/minúsculas
    var options = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    };

    // Desserializar e transformar em objeto
    var musics = JsonSerializer.Deserialize<List<Musica>>(response, options);

    if (musics != null)
    {
        //LinqFilter.FiltrarTodosGenerosMusicais(musics);
        //LinqOrder.ExibirListaDeArtistasOrdenado(musics);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musics, "rock");
        LinqFilter.FiltrarMusicasPorArtista(musics,"Michel Teló");
    }
    else
    {
        Console.WriteLine("Nenhuma música foi encontrada.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
