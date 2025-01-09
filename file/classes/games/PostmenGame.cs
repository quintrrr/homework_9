using file.interfaces;

namespace file.classes.games;

public class PostmenGame : IGame
{
    public string Name => "Почтальоны";
    public void Play(Team team)
    {
        Console.WriteLine($"Команда: {team.Country}, Игра: {Name}");
    }
}