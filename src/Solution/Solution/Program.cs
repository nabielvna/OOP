using Solution.Extra;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Books
        BukuFiksi bukuFiksi = new BukuFiksi("Harry Potter", "J.K. Rowling", "Fantasi");
        BukuPelajaran bukuPelajaran = new BukuPelajaran("Kalkulus Dasar", "James Stewart", "Matematika");

        Console.WriteLine($"Buku Fiksi: {bukuFiksi.Judul} oleh {bukuFiksi.Pengarang}, Genre: {bukuFiksi.Genre}");
        Console.WriteLine($"Buku Pelajaran: {bukuPelajaran.Judul} oleh {bukuPelajaran.Pengarang}, Subjek: {bukuPelajaran.Subjek}");
        Console.WriteLine("\n");

        // Vehicles
        Mobil mobil = new Mobil("Toyota", "Camry", "Sedan");
        Motor motor = new Motor("Honda", "CBR", "4 Stroke");

        Console.WriteLine($"Mobil: {mobil.Merk} {mobil.Model}, Tipe Bodi: {mobil.TipeBodi}");
        Console.WriteLine($"Motor: {motor.Merk} {motor.Model}, Tipe Mesin: {motor.TipeMesin}");
        Console.WriteLine("\n");

        // Electronic Devices
        FlagshipPhone flagshipPhone = new FlagshipPhone("Samsung", "Galaxy S21", "Android", "LCD, RAM", "Camera Telephoto");
        BudgetPhone budgetPhone = new BudgetPhone("Xiaomi", "Redmi Note 10", "Android", "LCD, RAM", 2000000);

        Console.WriteLine("Flagship Phone:");
        flagshipPhone.TampilkanIdentitas();
        flagshipPhone.TampilkanFiturPremium();

        Console.WriteLine("\nBudget Phone:");
        budgetPhone.TampilkanIdentitas();
        budgetPhone.TampilkanFiturDasar();
        Console.WriteLine($"Harga: Rp {budgetPhone.Harga}");
        Console.WriteLine("\n");

        // SportsEquipment
        BolaProfesional bolaProfesional = new BolaProfesional("Bola", "Adidas", "Sepakbola", "Kulit", true);
        BolaLatihan bolaLatihan = new BolaLatihan("Bola", "Nike", "Basket", "Karet", 250000);

        Console.WriteLine("Bola Profesional:");
        bolaProfesional.TampilkanInformasi();
        bolaProfesional.TampilkanStandar();

        Console.WriteLine("\nBola Latihan:");
        bolaLatihan.TampilkanInformasi();
        bolaLatihan.TampilkanSpesifikasi();
        Console.WriteLine($"Harga: Rp {bolaLatihan.Harga}");
        Console.WriteLine("\n");

        // Extras
        KaryawanTetap karyawanTetap = new KaryawanTetap("Budi Santoso", 30, "Manager", 8000000, 2000000);
        KaryawanKontrak karyawanKontrak = new KaryawanKontrak("Ani Putri", 25, "Programmer", 3000000, 6, 1000000);

        Console.WriteLine("=== Informasi Karyawan Tetap ===");
        karyawanTetap.TampilkanInfo();

        Console.WriteLine("\n=== Informasi Karyawan Kontrak ===");
        karyawanKontrak.TampilkanInfo();
    }
}
