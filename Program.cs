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

public delegate void AlertHandler(string message);

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

class Program
{
    public static void Main()
    {
        Zoo myZoo = new Zoo();
        
        var lion = new Lion("Simba", 180);
        var elephant = new Elephant("Dumbo", 180);
        var kangaroo = new Kangaroo("Roger", 180);
        
        Enclosure cSavannah = new Enclosure { Name = "cSavannah" };
        Enclosure oceania  = new Enclosure { Name = "Oceania" };
        Enclosure hSavannah = new Enclosure { Name = "hSavannah" };
        
        myZoo.Enclosures["cSavannah"] = cSavannah;
        myZoo.Enclosures["oceania"] = oceania;
        myZoo.Enclosures["hSavannah"] = hSavannah;
        
        cSavannah.AddAnimal(lion);
        oceania.AddAnimal(kangaroo);
        hSavannah.AddAnimal(elephant);
    }
}