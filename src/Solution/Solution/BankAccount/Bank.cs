namespace Solution.BankAccount
{
    public class Bank
    {
        private List<Rekening> daftarRekening = new List<Rekening>();

        public void TambahRekening(Rekening rekening)
        {
            daftarRekening.Add(rekening);
        }

        public Rekening CariRekening(string nomor)
        {
            foreach (var rekening in daftarRekening)
            {
                if (rekening.GetNomorRekening() == nomor)
                    return rekening;
            }
            throw new RekeningTidakDitemukanException();
        }
    }
}
