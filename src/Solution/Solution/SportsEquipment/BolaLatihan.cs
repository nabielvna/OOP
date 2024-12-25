using Solution.SportsEquipment;

public class BolaLatihan : Bola
{
    protected int _harga;

    public BolaLatihan(string jenis, string merek, string jenisOlahraga, string bahan, int harga)
        : base(jenis, merek, jenisOlahraga, bahan)
    {
        _harga = harga;
    }

    public int Harga { get { return _harga; } }
}