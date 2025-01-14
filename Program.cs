public abstract class Animal
{
    public string Name { get; set; }
    public double Weight { get; set; }

    public Animal(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }
    
    public abstract void MakeNoise();
}


public class Lion : Animal
{
    public Lion(string name, double weight):base(name, weight) {} // base is used to call the constructor of class parent.
    public override void MakeNoise()
    {
        Console.WriteLine("Roar");
    }
}

public class Elephant : Animal
{
    public Elephant(string name, double weight):base(name, weight) {}

    public override void MakeNoise()
    {
        Console.WriteLine("Trumpet");
    }
}

public class Kangaroo : Animal
{
    public Kangaroo(string name, double weight):base(name, weight) {}
    public override void MakeNoise()
    {
        Console.WriteLine("Kangaroo");
    }
}

public class Enclosure
{
    public string Name { get; set; }
    public List<Animal> Animals { get; set; } = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }
}

public class Zoo
{
    public List<Animal> Animals { get; set; } = new List<Animal>();
    public Dictionary<string, Enclosure> Enclosures { get; set; } = new Dictionary<string, Enclosure>();>
}

public interface ICarnivore
{
    void Hunt();
}

public interface IHerbivore
{
    void Graze();
}