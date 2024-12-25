namespace Solution.OnlineCourse
{
    public class Peserta
    {
        private string _nama;
        private int _usia;
        private string _tingkatPendidikan;

        public Peserta(string nama, int usia, string tingkatPendidikan)
        {
            _nama = nama;
            _usia = usia;
            _tingkatPendidikan = tingkatPendidikan;
        }

        public string Nama => _nama;

        public void CekKelayakan()
        {
            if (_usia < 18)
                throw new UsiaTidakMemenuhiSyaratException();
            if (_tingkatPendidikan != "Sarjana" && _tingkatPendidikan != "Magister")
                throw new PendidikanTidakMemenuhiSyaratException();
        }
    }
}
