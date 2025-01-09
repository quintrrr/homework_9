using file.interfaces;

namespace file.classes.games;

public class MouseTrapGame : IGame
{
    public string Name => "Мышеловка";
    public void Play(Team team)
    {
        Console.WriteLine($"Команда: {team.Country}, Игра: {Name}");
    }
}