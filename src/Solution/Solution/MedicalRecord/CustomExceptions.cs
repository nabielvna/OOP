namespace Solution.MedicalRecord
{
    public class DataTidakLengkapException : ApplicationException
    {
        public DataTidakLengkapException() : base("Data pasien tidak lengkap.") { }
    }

    public class DataTidakValidException : ApplicationException
    {
        public DataTidakValidException() : base("Data yang dimasukkan tidak valid.") { }
    }
}
