namespace ClassAndObject.TokoSepeda
{
    public class Sepeda
    {
        public string Merk { get; set; }
        public string Tipe { get; set; }
        public double Berat { get; set; }

        public Sepeda(string merk, string tipe, double berat)
        {
            Merk = merk;
            Tipe = tipe;
            Berat = berat;
        }

        public void TampilkanInformasi()
        {
            Console.WriteLine($"Merek: {Merk}, Tipe: {Tipe}, Berat: {Berat.ToString(System.Globalization.CultureInfo.InvariantCulture)} kg");
        }
    }
}