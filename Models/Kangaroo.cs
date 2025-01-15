namespace ZooManager.Models;
using ZooManager.Interfaces;

public class Kangaroo : Animal, IHerbivore
{
    public Kangaroo(string name, double weight):base(name, weight) {}
    
    public override void MakeNoise()
    {
        Console.WriteLine("Kangaroo");
    }

    public void Graze()
    {
        Console.WriteLine($"{Name} is grazing");
    }
}