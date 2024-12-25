namespace Solution.Bookstore
{
    public interface IDigitalAccessible
    {
        string AccessDigitalCopy();
    }

    public abstract class Buku
    {
        protected string _judul;
        protected string _penulis;

        public string Judul => _judul;
        public string Penulis => _penulis;

        protected Buku(string judul, string penulis)
        {
            _judul = judul;
            _penulis = penulis;
        }
    }

    public class BukuFisik : Buku
    {
        public BukuFisik(string judul, string penulis) : base(judul, penulis) { }

        public string PrintInfo() => $"Buku fisik: {_judul} oleh {_penulis}";
    }

    public class BukuDigital : Buku, IDigitalAccessible
    {
        public BukuDigital(string judul, string penulis) : base(judul, penulis) { }

        public string PrintInfo() => $"Buku digital: {_judul} oleh {_penulis}";

        public string AccessDigitalCopy() => $"Mengakses salinan digital buku {_judul}";
    }

    public static class DigitalLibrary
    {
        public static void ProvideAccess(IDigitalAccessible book)
        {
            Console.WriteLine(book.AccessDigitalCopy());
        }
    }
}