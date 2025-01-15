using ZooManager.Models;
using ZooManager.Services;
class Program
{
    public static void Main()
    {
        Zoo myZoo = new Zoo();
        
        var lion = new Lion("Simba", 180);
        var elephant = new Elephant("Dumbo", 180);
        var kangaroo = new Kangaroo("Roger", 180);
        
        Enclosure cSavannah = new Enclosure { Name = "cSavannah" };
        Enclosure oceania  = new Enclosure { Name = "Oceania" };
        Enclosure hSavannah = new Enclosure { Name = "hSavannah" };
        
        myZoo.Enclosures["cSavannah"] = cSavannah;
        myZoo.Enclosures["oceania"] = oceania;
        myZoo.Enclosures["hSavannah"] = hSavannah;
        
        cSavannah.AddAnimal(lion);
        oceania.AddAnimal(kangaroo);
        hSavannah.AddAnimal(elephant);
    }
}