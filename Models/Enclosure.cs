using ZooManager.Delegates;

namespace ZooManager.Models;
public class Enclosure
{
    public string Name { get; set; }
    public List<Animal> Animals { get; set; } = new List<Animal>();
    private const int MaxCapacity = 3;

    public event AlertHandler Alert;

    public void AddAnimal(Animal animal)
    {
        if (Animals.Count >= MaxCapacity)
        {
            Alert?.Invoke($"Enclosure {Name} has reached the maximum number of animals. !");
        }
        else
        {
            Animals.Add(animal);
        }
    }
}
