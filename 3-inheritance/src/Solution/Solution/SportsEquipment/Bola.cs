using Solution.SportsEquipment;

public class Bola : PeralatanOlahraga
{
    protected string _jenisOlahraga;
    protected string _bahan;

    public Bola(string jenis, string merek, string jenisOlahraga, string bahan)
        : base(jenis, merek)
    {
        _jenisOlahraga = jenisOlahraga;
        _bahan = bahan;
    }

    public string JenisOlahraga { get { return _jenisOlahraga; } }
    public string Bahan { get { return _bahan; } }

    public void TampilkanSpesifikasi()
    {
        Console.WriteLine($"Jenis Olahraga: {JenisOlahraga}, Bahan: {Bahan}");
    }
}
