using file.enums;

namespace file.classes;

public class Team
{
    public Countries Country { get; }
    public List<Player> Players { get; }

    public Team(Countries country, List<Player> players)
    {
        Country = country;
        Players = players;
    }
    
    public Team(Countries country)
    {
        Country = country;
    }

    public void AddPlayer(Player player)
    {
        if (Players.Count() < 15) Players.Add(player);
    }
}