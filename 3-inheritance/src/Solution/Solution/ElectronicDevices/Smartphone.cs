using Solution.ElectronicDevices;

public class Smartphone : PerangkatElektronik
{
    protected string _sistemOperasi;
    protected string _fiturDasar;

    public Smartphone(string brand, string model, string sistemOperasi, string fiturDasar)
        : base(brand, model)
    {
        _sistemOperasi = sistemOperasi;
        _fiturDasar = fiturDasar;
    }

    public string SistemOperasi { get { return _sistemOperasi; } }
    public string FiturDasar { get { return _fiturDasar; } }

    public void TampilkanFiturDasar()
    {
        Console.WriteLine($"Fitur Dasar: {FiturDasar}");
    }
}