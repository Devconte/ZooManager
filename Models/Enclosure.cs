namespace ZooManager.Models;
public class Enclosure
{
    public string Name { get; set; }
    public List<Animal> Animals { get; set; } = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }
}
