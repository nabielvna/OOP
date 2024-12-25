namespace Solution.SportsEquipment;

public class PeralatanOlahraga
{
    protected string _jenis;
    protected string _merek;

    public PeralatanOlahraga(string jenis, string merek)
    {
        _jenis = jenis;
        _merek = merek;
    }

    public string Jenis { get { return _jenis; } }
    public string Merek { get { return _merek; } }

    public void TampilkanInformasi()
    {
        Console.WriteLine($"Peralatan Olahraga Jenis: {Jenis}, Merek: {Merek}");
    }
}