namespace Solution.Extra;

public abstract class Karyawan
{
    public string Nama { get; set; }
    private int usia;
    public int Usia
    {
        get => usia;
        set
        {
            if (value < 16 || value > 60)
                throw new ArgumentException("Usia harus antara 16 dan 60 tahun");
            usia = value;
        }
    }
    public string Jabatan { get; set; }
    public decimal Tunjangan { get; set; }

    protected Karyawan(string nama, int usia, string jabatan, decimal tunjangan)
    {
        Nama = nama;
        Usia = usia;
        Jabatan = jabatan;
        Tunjangan = tunjangan;
    }

    public abstract decimal HitungGaji();

    public virtual void TampilkanInfo()
    {
        Console.WriteLine($"Nama: {Nama}");
        Console.WriteLine($"Usia: {Usia}");
        Console.WriteLine($"Jabatan: {Jabatan}");
        Console.WriteLine($"Tunjangan: {Tunjangan:C}");
        Console.WriteLine($"Total Gaji: {HitungGaji():C}");
    }
}

public class KaryawanTetap : Karyawan
{
    public decimal GajiPokok { get; set; }

    public decimal Bonus => GajiPokok * 0.1m; // Bonus 10% dari gaji pokok

    public KaryawanTetap(string nama, int usia, string jabatan, decimal gajiPokok, decimal tunjangan)
        : base(nama, usia, jabatan, tunjangan)
    {
        if (gajiPokok <= 0)
            throw new ArgumentException("Gaji pokok harus positif");
        GajiPokok = gajiPokok;
    }

    public override decimal HitungGaji()
    {
        return GajiPokok + Tunjangan + Bonus;
    }

    public override void TampilkanInfo()
    {
        base.TampilkanInfo();
        Console.WriteLine($"Gaji Pokok: {GajiPokok:C}");
        Console.WriteLine($"Bonus (10% dari Gaji Pokok): {Bonus:C}");
    }
}

public class KaryawanKontrak : Karyawan
{
    public decimal GajiDasar { get; set; }
    public int DurasiKontrak { get; set; } // dalam bulan

    public KaryawanKontrak(string nama, int usia, string jabatan, decimal gajiDasar, int durasiKontrak, decimal tunjangan)
        : base(nama, usia, jabatan, tunjangan)
    {
        if (gajiDasar <= 0)
            throw new ArgumentException("Gaji dasar harus positif");
        if (durasiKontrak <= 0)
            throw new ArgumentException("Durasi kontrak harus positif");

        GajiDasar = gajiDasar;
        DurasiKontrak = durasiKontrak;
    }

    public override decimal HitungGaji()
    {
        return GajiDasar + Tunjangan;
    }

    public override void TampilkanInfo()
    {
        base.TampilkanInfo();
        Console.WriteLine($"Gaji Dasar: {GajiDasar:C}");
        Console.WriteLine($"Durasi Kontrak: {DurasiKontrak} bulan");
    }
}