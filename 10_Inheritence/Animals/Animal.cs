namespace Animals;

public enum DietType {Herbivore, Omnivore, Carnivore}

public abstract class Animal
{
    public Animal()
    {
        Console.WriteLine("This is an Animal constructor");
    }

    public int NumberOfLegs { get; set; }
    public bool IsMammal { get; set; }
    public bool HasFur { get; set; }
    public DietType DietType { get; set; }

    public virtual void Move()
    {

    }
}