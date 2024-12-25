using Solution.Arts;
using Solution.Extra;
using Solution.MusicStudio;
using Solution.PetParade;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // PetParade
        Console.WriteLine("=== Pet Parade ===");
        ParadeHewan parade = new ParadeHewan();

        Kucing kucing1 = new Kucing("Ucok");
        Anjing anjing1 = new Anjing("Anton");
        Kucing kucing2 = new Kucing("Asep");

        parade.TambahHewan(kucing1);
        parade.TambahHewan(anjing1);
        parade.TambahHewan(kucing2);

        parade.MulaiParade(2);

        // MusicStudio
        Console.WriteLine("\n=== Music Studio ===");
        StudioMusik studioMusik = new StudioMusik();

        studioMusik.TambahInstrumen(new Gitar("Gitar Akustik"));
        studioMusik.TambahInstrumen(new Piano("Grand Piano"));
        studioMusik.TambahInstrumen(new Gitar("Gitar Elektrik"));

        Console.Write(studioMusik.MainkanInstrumen());

        // Arts
        Console.WriteLine("\n=== Art Studio ===");
        StudioSeni studioSeni = new StudioSeni();

        studioSeni.TambahKaryaSeni(new Lukisan("Mona Lisa"));
        studioSeni.TambahKaryaSeni(new Patung("David"));
        studioSeni.TambahKaryaSeni(new Lukisan("Starry Night"));

        studioSeni.TampilkanSemuaKarya();

        // Extra
        Console.WriteLine("\n=== Extra: Sistem Perpustakaan ===");
        Perpustakaan perpustakaan = new Perpustakaan();

        perpustakaan.TambahMedia(new Buku("Matematika", "Fulan IPA", 500));
        perpustakaan.TambahMedia(new Majalah("Pencari Bakat", "Fulan Bakat", "3"));
        perpustakaan.TambahMedia(new Buku("Fisika", "Fulan IPA", 400));

        Console.WriteLine("Koleksi Perpustakaan:");
        perpustakaan.TampilkanKoleksi();

        Console.WriteLine("\nMeminjam media:");
        perpustakaan.PinjamMedia("Matematika");
        perpustakaan.PinjamMedia("Pencari Bakat");
        perpustakaan.PinjamMedia("Kimia");
    }
}