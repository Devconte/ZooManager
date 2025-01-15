using ZooManager.Interfaces;

namespace ZooManager.Services;
using ZooManager.Models;


public class Zoo
{
    public List<Animal> Animals { get; set; } = new List<Animal>();
    public Dictionary<string, Enclosure> Enclosures { get; set; } = new Dictionary<string, Enclosure>();
    
    public Queue<string> VisitorsQueue { get; set; } = new Queue<string>();

    public void AddVisitor(string visitor)
    {
        VisitorsQueue.Enqueue(visitor);
    }

    public List<Animal> GetHeavyAnimals(double weight)
    {
        // needs to be a list to be usable; inumerable not working
        return Animals.Where(a => a.Weight > weight).ToList();
    }

    public int CountCarnivores()
    {
        return Animals.OfType<ICarnivore>().Count();
    }
}
