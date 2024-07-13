using ScreenSoundAPI.Modelos;
using System.Linq;

namespace ScreenSoundAPI.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderByDescending(musicas => musicas.Artista).Select(musicas => musicas.Artista).Distinct().ToList();
        Console.WriteLine("Lista de Artistas Ordenados");
        foreach(var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
