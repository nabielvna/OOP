using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution.Registration;

namespace Solution.Tests;

[TestClass]
public class MahasiswaTests
{
    [TestMethod]
    public void TestKonstruktorDanPendaftaran()
    {
        // Reset registrant counter sebelum pengujian
        Mahasiswa.ResetRegistrantCounter();

        // Instansiasi objek Mahasiswa
        Mahasiswa mahasiswa1 = new Mahasiswa("Alice");
        Assert.AreEqual(1, mahasiswa1.GetNomorPendaftaran());
        Assert.AreEqual(1, Mahasiswa.GetTotalRegistrant());

        Mahasiswa mahasiswa2 = new Mahasiswa("Bob");
        Assert.AreEqual(2, mahasiswa2.GetNomorPendaftaran());
        Assert.AreEqual(2, Mahasiswa.GetTotalRegistrant());
    }

    [TestMethod]
    public void TestResetRegistrantCounter()
    {
        // Pastikan penghitung di-reset dengan benar
        Mahasiswa.ResetRegistrantCounter(); // Reset counter
        Assert.AreEqual(0, Mahasiswa.GetTotalRegistrant());

        // Tambahkan mahasiswa setelah reset
        Mahasiswa mahasiswa3 = new Mahasiswa("Charlie");
        Assert.AreEqual(1, mahasiswa3.GetNomorPendaftaran());
        Assert.AreEqual(1, Mahasiswa.GetTotalRegistrant());
    }

    [TestMethod]
    public void MultipleResetsAndRegistrations()
    {
        // Reset dan tambahkan beberapa mahasiswa
        Mahasiswa.ResetRegistrantCounter();
        new Mahasiswa("Dave");
        new Mahasiswa("Eve");
        Assert.AreEqual(2, Mahasiswa.GetTotalRegistrant());

        Mahasiswa.ResetRegistrantCounter();
        new Mahasiswa("Faythe");
        Assert.AreEqual(1, Mahasiswa.GetTotalRegistrant());
    }
}
