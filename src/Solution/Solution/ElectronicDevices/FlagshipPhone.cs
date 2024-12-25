using Solution.ElectronicDevices;

public class FlagshipPhone : Smartphone
{
    protected string _fiturPremium;

    public FlagshipPhone(string brand, string model, string sistemOperasi, string fiturDasar, string fiturPremium)
        : base(brand, model, sistemOperasi, fiturDasar)
    {
        _fiturPremium = fiturPremium;
    }

    public string FiturPremium { get { return _fiturPremium; } }

    public void TampilkanFiturPremium()
    {
        TampilkanFiturDasar();
        Console.WriteLine($"Fitur Premium: {FiturPremium}");
    }
}