using Solution.Vehicles;

public class Mobil : Kendaraan
{
    protected string _tipeBodi;

    public Mobil(string merk, string model, string tipeBodi)
        : base(merk, model)
    {
        _tipeBodi = tipeBodi;
    }

    public string TipeBodi { get { return _tipeBodi; } }
}