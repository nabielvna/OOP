using Solution.BankAccount;
using Solution.MedicalRecord;
using Solution.OnlineCourse;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Soal: Bank Account
        Console.WriteLine("=== Soal: Bank Account ===");
        var bank = new Bank();

        var rekening1 = new Rekening("123", 100000);
        var rekening2 = new Rekening("456", 50000);

        bank.TambahRekening(rekening1);
        bank.TambahRekening(rekening2);

        try
        {
            var rekening = bank.CariRekening("123");
            rekening.Penarikan(120000);
        }
        catch (SaldoTidakCukupException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (BatasPenarikanException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (RekeningTidakDitemukanException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Soal: Online Course
        Console.WriteLine("\n=== Soal: Online Course ===");
        var kursus = new KursusOnline();

        var peserta1 = new Peserta("John Doe", 20, "Sarjana");
        var peserta2 = new Peserta("Jane Smith", 17, "Sarjana");

        try
        {
            kursus.DaftarPeserta(peserta1);
            kursus.DaftarPeserta(peserta2);
        }
        catch (UsiaTidakMemenuhiSyaratException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (PendidikanTidakMemenuhiSyaratException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Proses pendaftaran selesai.");
        }

        // Soal: Pemeriksaan Data Pasien
        Console.WriteLine("\n=== Soal: Pemeriksaan Data Pasien ===");
        var pemeriksaan = new Pemeriksaan();
        var pasien1 = new Pasien("John Doe", 25, "123 Main St");
        var pasien2 = new Pasien("", 25, "123 Main St");

        try
        {
            pemeriksaan.PeriksaData(pasien1);
            pemeriksaan.PeriksaData(pasien2);
        }
        catch (ApplicationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
