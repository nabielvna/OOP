namespace Solution.ElectronicDevices;

public class PerangkatElektronik
{
    protected string _brand;
    protected string _model;

    public PerangkatElektronik(string brand, string model)
    {
        _brand = brand;
        _model = model;
    }

    public string Brand { get { return _brand; } }
    public string Model { get { return _model; } }

    public void TampilkanIdentitas()
    {
        Console.WriteLine($"Perangkat Brand: {Brand}, Model: {Model}");
    }
}
