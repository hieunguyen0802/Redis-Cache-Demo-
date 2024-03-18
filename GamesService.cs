using System.Text.Json;

public class GamesService
{
    public Game[] LoadGames()
    {
        using var streamReader = new StreamReader("GamesData.json");
        var gamesData = streamReader.ReadToEnd();

        var games = JsonSerializer.Deserialize<Game[]>(gamesData);

        return games;
    }
}