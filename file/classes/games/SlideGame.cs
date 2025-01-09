using file.interfaces;

namespace file.classes.games;

public class SlideGame : IGame
{
    public string Name => "Горки";
    public void Play(Team team)
    {
        Console.WriteLine($"Команда: {team.Country}, Игра: {Name}");
    }
}