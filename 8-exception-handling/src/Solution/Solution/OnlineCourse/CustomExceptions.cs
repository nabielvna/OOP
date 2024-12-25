namespace Solution.OnlineCourse
{
    public class UsiaTidakMemenuhiSyaratException : ApplicationException
    {
        public UsiaTidakMemenuhiSyaratException() : base("Maaf, usia Anda tidak memenuhi syarat untuk mengikuti kursus ini.") { }
    }

    public class PendidikanTidakMemenuhiSyaratException : ApplicationException
    {
        public PendidikanTidakMemenuhiSyaratException() : base("Maaf, tingkat pendidikan Anda tidak memenuhi syarat untuk mengikuti kursus ini.") { }
    }
}
