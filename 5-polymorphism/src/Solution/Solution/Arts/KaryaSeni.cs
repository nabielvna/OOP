namespace Solution.Arts
{
    public abstract class KaryaSeni
    {
        private string _judul;

        public KaryaSeni(string judul)
        {
            _judul = judul;
        }

        public string Judul
        {
            get { return _judul; }
        }

        public abstract string Deskripsi();
        public abstract string Tampilkan();
    }

    public class Lukisan : KaryaSeni
    {
        public Lukisan(string judul) : base(judul) { }

        public override string Deskripsi()
        {
            return "Sebuah gambar yang dilukis di atas kanvas";
        }

        public override string Tampilkan()
        {
            return "Digantung di dinding";
        }
    }

    public class Patung : KaryaSeni
    {
        public Patung(string judul) : base(judul) { }

        public override string Deskripsi()
        {
            return "Sebuah objek tiga dimensi yang dibentuk";
        }

        public override string Tampilkan()
        {
            return "Diletakkan di atas meja atau lantai";
        }
    }

    public class StudioSeni
    {
        private List<KaryaSeni> _listKarya = new List<KaryaSeni>();

        public List<KaryaSeni> ListKarya
        {
            get { return _listKarya; }
        }

        public void TambahKaryaSeni(KaryaSeni karya)
        {
            _listKarya.Add(karya);
        }

        public void TampilkanSemuaKarya()
        {
            foreach (var karya in _listKarya)
            {
                Console.WriteLine($"{karya.Judul}: {karya.Tampilkan()}");
            }
        }
    }
}