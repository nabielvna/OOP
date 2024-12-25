namespace Solution.OnlineCourse
{
    public record struct KursusOnline
    {
        private List<Peserta> daftarPeserta;

        public KursusOnline()
        {
            daftarPeserta = new List<Peserta>();
        }

        public void DaftarPeserta(Peserta peserta)
        {
            peserta.CekKelayakan();
            daftarPeserta.Add(peserta);
        }

        public List<Peserta> GetDaftarPeserta()
        {
            return daftarPeserta;
        }
    }
}
