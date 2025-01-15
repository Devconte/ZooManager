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
        
        // LINQ
        
        

        
    }
}