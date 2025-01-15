namespace ZooManager.Services;
using ZooManager.Models;


public class Zoo
{
    public List<Animal> Animals { get; set; } = new List<Animal>();
    public Dictionary<string, Enclosure> Enclosures { get; set; } = new Dictionary<string, Enclosure>();
}
