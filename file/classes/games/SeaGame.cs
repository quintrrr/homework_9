using file.interfaces;

namespace file.classes.games;

public class SeaGame : IGame
{
    public string Name => "Море";
    public void Play(Team team)
    {
        Console.WriteLine($"Команда: {team.Country}, Игра: {Name}");
    }
}