namespace Animals;

public class Cat : Animal
{
    public Cat()
    {
        IsMammal = true;
        DietType = DietType.Carnivore;
        Console.WriteLine("This is a Cat constructor");
    }

    public double ClawLength { get; set; }

    public virtual void MakeSound()
    {
        Console.WriteLine("Meow");
    }

    public override void Move()
    {
        Console.WriteLine($"The {GetType().Name} moves quickly!");
    }
}

public class Liger : Cat
{
    public Liger()
    {
        Console.WriteLine("This is a Liger constructor");
    }

    public override void Move()
    {
        Console.WriteLine($"The {GetType().Name} stalks its prey.");
        base.Move();
    }

    public override void MakeSound()
    {
        Console.WriteLine("Roar!");
    }
}

public class TabbyCat : Cat
{
    public TabbyCat()
    {
        Console.WriteLine("This is a Tabby Cat constructor");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Purr");
    }
}