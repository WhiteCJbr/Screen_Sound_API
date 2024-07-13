using ScreenSoundAPI.Modelos;
using System.Linq;
namespace ScreenSoundAPI.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach(var genero in todosOsGenerosMusicais) {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero) 
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas do genero musical >>> {genero}");
        foreach(var artista in  artistasPorGeneroMusical)
        {
            Console.WriteLine($" - {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoartista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoartista)).ToList();
        Console.WriteLine(nomeDoartista);
        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, string tonalidade)
    {
        var musicasPorTonalidade = musicas.Where(musica => musica.Tonalidade.Equals(tonalidade)).Select(musica => musica.Nome).ToList();
        Console.WriteLine($"Filtrando as musicas na tonalidade {tonalidade}");
        foreach(var musica in musicasPorTonalidade)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
