using ClassAndObject.Perpustakaan;
using ClassAndObject.Kendaraan;
using ClassAndObject.TokoLaptop;
using ClassAndObject.TokoSepeda;
using ClassAndObject.OperasiMatematika;

namespace ClassAndObject
{
    class Program
    {
        static void Main()
        {
            // Buku
            Buku buku = new Buku("Buku A", "Penulis Buku A", 2024);
            Console.WriteLine("Informasi Buku:");
            buku.TampilkanInfo();
            Console.WriteLine();

            // Mobil
            Mobil mobil = new Mobil("Merk Mobil A", "Model Mobil A", 2024);
            Console.WriteLine("Spesifikasi Mobil:");
            mobil.TampilkanSpesifikasi();
            Console.WriteLine();

            // Laptop
            Laptop laptop = new Laptop("Laptop A", "Prosesor A", 16, 1024);
            Console.WriteLine("Spesifikasi Laptop:");
            laptop.TampilkanSpesifikasi();
            Console.WriteLine();

            // Sepeda
            Sepeda sepeda = new Sepeda("Merk Sepeda A", "Tipe Sepeda A", 20.5);
            Console.WriteLine("Informasi Sepeda:");
            sepeda.TampilkanInformasi();
            Console.WriteLine();

            // Kalkulator
            Kalkulator kalkulator = new Kalkulator();
            Console.WriteLine("Operasi Kalkulator:");
            Console.WriteLine($"Tambah: {kalkulator.Tambah(321.32, 53.64)}");
            Console.WriteLine($"Kurang: {kalkulator.Kurang(10.11, 4.98)}");
            Console.WriteLine($"Kali: {kalkulator.Kali(6.65, 2.21)}");
            Console.WriteLine($"Bagi: {kalkulator.Bagi(15.4, 1.494)}");
        }
    }
}