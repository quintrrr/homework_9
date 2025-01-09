using file.interfaces;

namespace file.classes.games;

public class BeachGame : IGame
{
    public string Name => "Пляж";
    public void Play(Team team)
    {
        Console.WriteLine($"Команда: {team.Country}, Игра: {Name}");
    }
    
}