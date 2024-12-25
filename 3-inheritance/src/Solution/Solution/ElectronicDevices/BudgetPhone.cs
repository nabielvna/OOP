using Solution.ElectronicDevices;

public class BudgetPhone : Smartphone
{
    protected int _harga;

    public BudgetPhone(string brand, string model, string sistemOperasi, string fiturDasar, int harga)
        : base(brand, model, sistemOperasi, fiturDasar)
    {
        _harga = harga;
    }

    public int Harga { get { return _harga; } }
}