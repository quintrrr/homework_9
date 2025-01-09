using file.interfaces;

namespace file.classes.games;

public class MyGame : IGame
{
    public string Name => "Моя игра";
    public void Play(Team team)
    {
        Console.WriteLine($"Команда: {team.Country}, Игра: {Name}");
    }
}