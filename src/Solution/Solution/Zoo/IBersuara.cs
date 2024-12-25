namespace Solution.Zoo
{
    public interface IBersuara
    {
        string Suara();
    }

    public abstract class Hewan
    {
        protected string _nama;
        public string Nama => _nama;

        protected Hewan(string nama)
        {
            _nama = nama;
        }
    }

    public class Singa : Hewan, IBersuara
    {
        public Singa(string nama) : base(nama) { }
        public string Suara() => "Roar";
    }

    public class Kuda : Hewan, IBersuara
    {
        public Kuda(string nama) : base(nama) { }
        public string Suara() => "Neigh";
    }

    public class Ular : Hewan
    {
        public Ular(string nama) : base(nama) { }
    }

    public class KebunBinatang
    {
        private List<Hewan> daftarHewan = new List<Hewan>();

        public void TambahHewan(Hewan hewan)
        {
            daftarHewan.Add(hewan);
        }

        public void DengarkanHewanBersuara()
        {
            foreach (var hewan in daftarHewan)
            {
                if (hewan is IBersuara bersuara)
                {
                    Console.WriteLine($"{hewan.GetType().Name} bernama {hewan.Nama} bersuara {bersuara.Suara()}");
                }
            }
        }
    }
}