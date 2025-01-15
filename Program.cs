using ZooManager.Models;
using ZooManager.Services;
class Program
{
    public static void Main()
    {
        Zoo myZoo = new Zoo();
        
        var lion = new Lion("Simba", 360);
        var elephant = new Elephant("Dumbo", 1800);
        var kangaroo = new Kangaroo("Roger", 180);
        
        
        myZoo.Animals.Add(lion);
        myZoo.Animals.Add(elephant);
        myZoo.Animals.Add(kangaroo);
        
        
        Enclosure cSavannah = new Enclosure { Name = "cSavannah" };
        Enclosure oceania  = new Enclosure { Name = "Oceania" };
        Enclosure hSavannah = new Enclosure { Name = "hSavannah" };
        
        // adding enclosure name to the dictionnary "key" = value
        myZoo.Enclosures["cSavannah"] = cSavannah;
        myZoo.Enclosures["oceania"] = oceania;
        myZoo.Enclosures["hSavannah"] = hSavannah;
        
        // adding the max capacity alert to the savannah enclosure.
        cSavannah.Alert += message => Console.WriteLine(message);
        
        cSavannah.AddAnimal(lion);
        oceania.AddAnimal(kangaroo);
        hSavannah.AddAnimal(elephant);
        
        for (int i = 0; i < 10; i++)
        {
            myZoo.AddVisitor($"Visitor {i + 1}");
         
        }
        foreach (var animal in myZoo.Animals)
        {
            Console.WriteLine($"Nom: {animal.Name}, Poids: {animal.Weight}");
        }
        // LINQ

        var heavyAnimals = myZoo.GetHeavyAnimals(50);
        Console.WriteLine("Animals weighting more than 50 kg :");
        foreach (var animal in heavyAnimals)
        {
            Console.WriteLine($"- {animal.Name}, Weight: {animal.Weight} kg");
        }
        
        int carnivoreCount = myZoo.CountCarnivores();
        Console.WriteLine($"There is {carnivoreCount} carnivores in the zoo.");



    }
}