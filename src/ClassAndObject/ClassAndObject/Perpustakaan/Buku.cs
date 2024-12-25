namespace ClassAndObject.Perpustakaan
{
    public class Buku
    {
        public string Judul { get; set; }
        public string Penulis { get; set; }
        public int TahunTerbit { get; set; }

        public Buku(string judul, string penulis, int tahunTerbit)
        {
            Judul = judul;
            Penulis = penulis;
            TahunTerbit = tahunTerbit;
        }

        public void TampilkanInfo()
        {
            Console.WriteLine($"Judul: {Judul}, Penulis: {Penulis}, Tahun Terbit: {TahunTerbit}");
        }
    }
}