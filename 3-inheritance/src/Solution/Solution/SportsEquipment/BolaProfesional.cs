using Solution.SportsEquipment;

public class BolaProfesional : Bola
{
    protected bool _standarInternasional;

    public BolaProfesional(string jenis, string merek, string jenisOlahraga, string bahan, bool standarInternasional)
        : base(jenis, merek, jenisOlahraga, bahan)
    {
        _standarInternasional = standarInternasional;
    }

    public bool StandarInternasional { get { return _standarInternasional; } }

    public void TampilkanStandar()
    {
        TampilkanSpesifikasi();
        Console.WriteLine($"Standar Internasional: {(StandarInternasional ? "Ya" : "Tidak")}");
    }
}