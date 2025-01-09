using file.interfaces;

namespace file.classes.games;

public class FishingGame : IGame
{
    public string Name => "Рыбалка";
    public void Play(Team team)
    {
        Console.WriteLine($"Команда: {team.Country}, Игра: {Name}");
    }
}