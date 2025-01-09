namespace file.classes;

public class Organizer
{
    public string Name { get; }
    
    public BigRaces Game { get; }

    public Organizer(string name, BigRaces game)
    {
        Name = name;
        Game = game;
    }
}