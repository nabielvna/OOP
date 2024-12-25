namespace Solution.MedicalRecord
{
    public class Pasien
    {
        private string _nama;
        private int _umur;
        private string _alamat;

        public Pasien(string nama, int umur, string alamat)
        {
            _nama = nama;
            _umur = umur;
            _alamat = alamat;
        }

        public void ValidasiData()
        {
            if (string.IsNullOrWhiteSpace(_nama) || string.IsNullOrWhiteSpace(_alamat))
                throw new DataTidakLengkapException();
            if (_umur < 0 || _umur > 120)
                throw new DataTidakValidException();
        }
    }
}
