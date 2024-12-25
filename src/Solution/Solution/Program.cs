using Solution.Bookstore;
using Solution.Extra;
using Solution.ObjectSorter;
using Solution.Shops;
using Solution.Zoo;
using Buku = Solution.ObjectSorter.Buku;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Zoo
        Console.WriteLine("==== Zoo ====");
        var kebunBinatang = new KebunBinatang();
        kebunBinatang.TambahHewan(new Singa("Simba"));
        kebunBinatang.TambahHewan(new Kuda("Woody"));
        kebunBinatang.TambahHewan(new Ular("Kaa"));
        kebunBinatang.DengarkanHewanBersuara();

        // Shops
        Console.WriteLine("\n==== Shops ====");
        var tv = new Televisi("Sony");
        var kipas = new KipasAngin("Miyako");
        var mobil = new MobilListrik("Tesla");

        ElectricityProvider.SupplyPower(tv);
        ElectricityProvider.SupplyPower(kipas);
        ElectricityProvider.SupplyPower(mobil);

        // ObjectSorter
        Console.WriteLine("\n==== ObjectSorter ====");
        var items = new ISortable[]
        {
            new Buku("Harry Potter", 500),
            new Buku("The Hobbit", 300),
            new Sepatu("Nike Air", 42),
            new Sepatu("Adidas Superstar", 40),
            new Buku("1984", 400)
        };

        var sortedItems = Sorter.SortItems(items);
        foreach (var item in sortedItems)
        {
            if (item is Item i)
            {
                Console.WriteLine($"{i.GetType().Name}: {i.Nama}");
            }
        }

        // Bookstore
        Console.WriteLine("\n==== Bookstore ====");
        var bukuFisik = new BukuFisik("The Great Gatsby", "F. Scott Fitzgerald");
        var bukuDigital = new BukuDigital("1984", "George Orwell");

        Console.WriteLine(bukuFisik.PrintInfo());
        Console.WriteLine(bukuDigital.PrintInfo());
        DigitalLibrary.ProvideAccess(bukuDigital);

        // Extra
        Console.WriteLine("==== Extra ====");

        var circle = new Circle("Circle", 5);
        var rectangle = new Rectangle("Rectangle", 4, 6);

        ShapeCalculator.PrintArea(circle);
        ShapeCalculator.PrintArea(rectangle);
    }
}
