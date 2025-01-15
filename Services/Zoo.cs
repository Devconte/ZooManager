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

    public IEnumerable<Animal> GetHeavyAnimals(double weight)
    {
        return Animals.Where(a => a.Weight > weight);
    }

    public int CountCarnivores()
    {
        return Animals.OfType<IHerbivore>().Count();
    }
}
