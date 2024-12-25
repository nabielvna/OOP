namespace Solution.BankAccount
{
    public class SaldoTidakCukupException : ApplicationException
    {
        public SaldoTidakCukupException() : base("Saldo tidak mencukupi!") { }
    }

    public class RekeningTidakDitemukanException : ApplicationException
    {
        public RekeningTidakDitemukanException() : base("Rekening tidak ditemukan!") { }
    }

    public class BatasPenarikanException : ApplicationException
    {
        public BatasPenarikanException() : base("Melebihi batas penarikan harian.") { }
    }
}
