using file.classes;

namespace file.interfaces;

public interface IGame
{
    string Name { get; }
    void Play(Team team);
}