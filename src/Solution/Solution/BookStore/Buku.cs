namespace Solution.BookStore
{
    public class Buku
    {
        private string _isbn;
        private string _judul;
        private double _harga;

        public Buku(string isbn, string judul, double harga)
        {
            _isbn = isbn;
            _judul = judul;
            _harga = harga;
        }

        public string Isbn { get { return _isbn; } }
        public string Judul { get { return _judul; } }
        public double Harga { get { return _harga; } }

        public bool IsIsbnMatch(string isbn)
        {
            return _isbn == isbn;
        }

        public string GetInfo()
        {
            return $"ISBN: {Isbn}, Judul: {Judul}, Harga: {Harga}";
        }
    }

    public class TokoBuku
    {
        private List<Buku> _daftarBuku = new List<Buku>();

        public TokoBuku()
        {
            _daftarBuku = new List<Buku>();
        }

        public List<Buku> DaftarBuku
        {
            get { return _daftarBuku; }
            set { _daftarBuku = value; }
        }

        public void TambahBuku(Buku buku)
        {
            _daftarBuku.Add(buku);
        }
        public bool HapusBuku(string isbn)
        {
            int count = _daftarBuku.RemoveAll(b => b.Isbn == isbn);
            return count > 0;
        }

        public Buku? CariBuku(string isbn)
        {
            return _daftarBuku.FirstOrDefault(b => b.Isbn == isbn);
        }

        public List<string> GetDaftarBuku()
        {
            return _daftarBuku.ConvertAll(b => b.GetInfo());
        }
    }
}