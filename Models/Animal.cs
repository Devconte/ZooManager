namespace ZooManager.Models;

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