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