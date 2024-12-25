using Solution.BookStore;
using Solution.Computers;
using Solution.ElectronicStore;
using Solution.Extra;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Computer
        Console.WriteLine("==== Computer ====");
        Processor processor = new Processor("Intel", 3.5);
        Memory memory = new Memory(16, "DDR4");
        Computer computer = new Computer(processor, memory);

        Console.WriteLine(computer.GetInfo());

        // BookStore
        Console.WriteLine("\n==== BookStore ====");
        TokoBuku tokoBuku = new TokoBuku();

        tokoBuku.TambahBuku(new Buku("123", "Book 1", 10.99));
        tokoBuku.TambahBuku(new Buku("456", "Book 2", 15.99));
        tokoBuku.TambahBuku(new Buku("789", "Book 3", 20.99));

        Console.WriteLine("Daftar buku setelah penambahan:");
        tokoBuku.GetDaftarBuku().ForEach(Console.WriteLine);

        tokoBuku.HapusBuku("456");

        Console.WriteLine("\nDaftar buku setelah penghapusan:");
        tokoBuku.GetDaftarBuku().ForEach(Console.WriteLine);

        // ElectronicStore
        Console.WriteLine("\n==== ElectronicStore ====");
        KeranjangBelanja keranjang = new KeranjangBelanja();

        Produk produk1 = new Produk("Laptop", 1000);
        Produk produk2 = new Produk("Smartphone", 500);

        keranjang.TambahItemBelanja(produk1, 2);
        keranjang.TambahItemBelanja(produk2, 3);

        Console.WriteLine($"Total belanja: ${keranjang.HitungTotalBelanja()}");

        // Extra
        Console.WriteLine("\n==== Extra ====");
        TaskManager taskManager = new TaskManager();

        taskManager.AddTask("Belajar C#");
        taskManager.AddTask("Membuat project");
        taskManager.AddTask("Olahraga");

        Console.WriteLine("Daftar tugas:");
        taskManager.GetAllTasks().ForEach(Console.WriteLine);

        Console.WriteLine("\nMenyelesaikan tugas 'Belajar C#'");
        taskManager.CompleteTask(0);

        Console.WriteLine("\nDaftar tugas setelah update:");
        taskManager.GetAllTasks().ForEach(Console.WriteLine);
    }
}