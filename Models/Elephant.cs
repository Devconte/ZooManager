using ZooManager.Interfaces;
namespace ZooManager.Models;

public class Elephant : Animal, IHerbivore
{
    public Elephant(string name, double weight):base(name, weight) {}

    public override void MakeNoise()
    {
        Console.WriteLine("Trumpet");
    }

    public void Graze()
    {
        Console.WriteLine($"{Name} is grazing");
    }
}