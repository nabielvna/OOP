namespace Solution.Vehicles;

public class Kendaraan
{
    protected string _merk;
    protected string _model;

    public Kendaraan(string merk, string model)
    {
        _merk = merk;
        _model = model;
    }

    public string Merk { get { return _merk; } }
    public string Model { get { return _model; } }
}