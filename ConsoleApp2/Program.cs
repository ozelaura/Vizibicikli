// See https://aka.ms/new-console-template for more information
using ConsoleApp2.DataSource;

static List<Kolcsonzes> kolcsonzesek = new List<Kolcsonzes>();
static void Main(string[] args)
{
    
    //LINQ
    List<Kolcsonzes> masikLista
        = File.ReadAllLines("DataSource\\kolcsonzesek.txt")
              .Skip(1)
              .Select(x => new Kolcsonzes(x))
              .ToList();

    Console.WriteLine(kolcsonzesek.Count);

    //6.
    Console.WriteLine($"6.feladat: Kérek egy nevet:");
    string nev = "Kata";
    Console.WriteLine(nev);
    Console.WriteLine($"\t(megadottNev) kölcsönzései:");

    if (kolcsonzesek.Where(x => x.Nev == "Kata").Count()==0)
    {
        Console.WriteLine("Nem volt ilyen nevű kölcsönző!");
    }
    else
    {
        foreach (var akt in kolcsonzesek.Where(x => x.Nev == "Kata");
        {

        }
        kolcsonzesek.Where(x => x.Nev == "Kata")
            .ToList()
            .ForEach(x => Console.WriteLine($"{x.EOra}:{x.EPerc}-{x.VOra}:{x.VPerc}"));

    }

    //8.
    Console.WriteLine($"8.feladat: A napi bevétel: {napiBevetel} Ft");


    //10.
    kolcsonzesek.GroupBy(x => x.Jazon).ToList().ForEach(x => Console.WriteLine($"{x.Key} - {x.Count()}"));
}
