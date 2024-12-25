namespace ClassAndObject.TokoLaptop
{
    public class Laptop
    {
        public string Merk { get; set; }
        public string Prosesor { get; set; }
        public int Ram { get; set; }
        public int Penyimpanan { get; set; }

        public Laptop(string merk, string prosesor, int ram, int penyimpanan)
        {
            Merk = merk;
            Prosesor = prosesor;
            Ram = ram;
            Penyimpanan = penyimpanan;
        }

        public void TampilkanSpesifikasi()
        {
            Console.WriteLine($"Merk: {Merk}, Prosesor: {Prosesor}, RAM: {Ram} GB, Penyimpanan: {Penyimpanan} GB");
        }
    }
}