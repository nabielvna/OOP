using Solution.Vehicles;

public class Motor : Kendaraan
{
    protected string _tipeMesin;

    public Motor(string merk, string model, string tipeMesin)
        : base(merk, model)
    {
        _tipeMesin = tipeMesin;
    }

    public string TipeMesin { get { return _tipeMesin; } }
}