namespace Solution.Shops
{
    public interface IElectrifiable
    {
        string PowerOn();
        string PowerOff();
    }

    public abstract class Barang
    {
        protected string _merk;
        public string Merk => _merk;

        protected Barang(string merk)
        {
            _merk = merk;
        }
    }

    public class Televisi : Barang, IElectrifiable
    {
        public Televisi(string merk) : base(merk) { }
        public string PowerOn() => "Televisi dinyalakan";
        public string PowerOff() => "Televisi dimatikan";
    }

    public class KipasAngin : Barang, IElectrifiable
    {
        public KipasAngin(string merk) : base(merk) { }
        public string PowerOn() => "Kipas Angin dinyalakan";
        public string PowerOff() => "Kipas Angin dimatikan";
    }

    public class MobilListrik : Barang, IElectrifiable
    {
        public MobilListrik(string merk) : base(merk) { }
        public string PowerOn() => "Mobil Listrik siap berjalan";
        public string PowerOff() => "Mobil Listrik berhenti";
    }

    public static class ElectricityProvider
    {
        public static void SupplyPower(IElectrifiable device)
        {
            Console.WriteLine(device.PowerOn());
        }
    }
}