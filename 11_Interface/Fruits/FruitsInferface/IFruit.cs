namespace Fruits;

public interface IFruit
{
    string Name { get; }
    bool IsPeeled { get; }
    string Peel();
}