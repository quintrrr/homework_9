using file.interfaces;

namespace file.classes;

public class BigRaces
{
    public List<Team> Teams { get; }
    public List<IGame> Games { get; }

    public BigRaces(List<Team> teams, List<IGame> games)
    {
        Teams = teams;
        Games = games;
    }

    public void AddGame(IGame game)
    {
        if (Games.Count() < 6) Games.Add(game);
        else Console.WriteLine("Максимальное количество игр");
    }

    public void AddTeam(Team team)
    {
        if (Teams.Count() < 4) Teams.Add(team);
        else Console.WriteLine("Максимальное количество команд");
    }
    
    public void Start()
    {
        Console.WriteLine("Начало соревнований!");
        foreach (var team in Teams)
        {
            foreach (var game in Games)
            {
                game.Play(team); 
            }
        }
    }
}