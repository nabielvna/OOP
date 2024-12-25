namespace Solution.BankAccount
{
    public class Rekening
    {
        private string _nomor;
        private double _saldo;
        private static readonly double BatasPenarikanHarian = 100000;

        public Rekening(string nomor, double saldoAwal)
        {
            _nomor = nomor;
            _saldo = saldoAwal;
        }

        public void Penarikan(double jumlah)
        {
            if (jumlah > BatasPenarikanHarian)
            {
                throw new BatasPenarikanException();
            }
            if (jumlah > _saldo)
            {
                throw new SaldoTidakCukupException();
            }
            _saldo -= jumlah;
        }

        public double GetSaldo() => _saldo;

        public string GetNomorRekening() => _nomor;
    }
}
