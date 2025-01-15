using ZooManager.Interfaces;

namespace ZooManager.Models;

public class Lion : Animal, ICarnivore
{
    public Lion(string name, double weight):base(name, weight) {} // base is used to call the constructor of class parent.
    public override void MakeNoise()
    {
        Console.WriteLine("Roar");
    }

    public void Hunt()
    {
        Console.WriteLine($"{Name} is hunting");
    }
}