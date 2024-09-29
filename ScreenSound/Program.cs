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
        //LinqFilter.FiltrarMusicasPorArtista(musics,"Michel Teló");

        //var musicasPeferidasPessoa1 = new MusicasPreferidas("Pessoa1");
        //musicasPeferidasPessoa1.AdicionarMusicasFavoritas(musics[1]);
        //musicasPeferidasPessoa1.AdicionarMusicasFavoritas(musics[2]);
        //musicasPeferidasPessoa1.AdicionarMusicasFavoritas(musics[3]);
        //musicasPeferidasPessoa1.AdicionarMusicasFavoritas(musics[4]);
        //musicasPeferidasPessoa1.AdicionarMusicasFavoritas(musics[5]);

        //musicasPeferidasPessoa1.ExibirMusicasFavoritas();

        var musicasPreferidasPessoa2 = new MusicasPreferidas("pessoa2");
        musicasPreferidasPessoa2.AdicionarMusicasFavoritas(musics[6]);
        musicasPreferidasPessoa2.AdicionarMusicasFavoritas(musics[7]);
        musicasPreferidasPessoa2.AdicionarMusicasFavoritas(musics[8]);
        musicasPreferidasPessoa2.AdicionarMusicasFavoritas(musics[9]);
        musicasPreferidasPessoa2.AdicionarMusicasFavoritas(musics[10]);

        musicasPreferidasPessoa2.ExibirMusicasFavoritas();

        musicasPreferidasPessoa2.GerarArquivoJson();
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
