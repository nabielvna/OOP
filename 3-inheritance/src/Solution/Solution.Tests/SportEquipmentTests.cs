using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution.SportsEquipment;

namespace Solution.SportsEquipment.Tests;

[TestClass]
public class SportEquipmentTests
{
    private StringWriter stringWriter;
    private TextWriter originalOutput;

    [TestInitialize]
    public void TestInitialize()
    {
        originalOutput = Console.Out; // Simpan referensi output standar
        stringWriter = new StringWriter(); // Inisialisasi StringWriter untuk menangkap output
        Console.SetOut(stringWriter); // Set output konsol ke StringWriter
    }

    [TestCleanup]
    public void TestCleanup()
    {
        Console.SetOut(originalOutput); // Kembalikan output konsol ke standar
        stringWriter.Dispose(); // Bersihkan resources StringWriter
    }

    [TestMethod]
    public void PeralatanOlahraga_ConstructorAndProperties_WorkCorrectly()
    {
        var peralatan = new PeralatanOlahraga("Sepakbola", "Adidas");
        Assert.AreEqual("Sepakbola", peralatan.Jenis);
        Assert.AreEqual("Adidas", peralatan.Merek);
    }

    [TestMethod]
    public void Bola_ConstructorAndProperties_WorkCorrectly()
    {
        var bola = new Bola("Sepakbola", "Nike", "Sepakbola", "Kulit");
        Assert.AreEqual("Sepakbola", bola.JenisOlahraga);
        Assert.AreEqual("Kulit", bola.Bahan);
    }

    [TestMethod]
    public void BolaProfesional_ConstructorAndProperties_WorkCorrectly()
    {
        var bolaProf = new BolaProfesional("Sepakbola", "Nike", "Sepakbola", "Kulit", true);
        Assert.IsTrue(bolaProf.StandarInternasional);
    }

    [TestMethod]
    public void BolaLatihan_ConstructorAndProperties_WorkCorrectly()
    {
        var bolaLatihan = new BolaLatihan("Basket", "Adidas", "Basket", "Karet", 150);
        Assert.AreEqual(150, bolaLatihan.Harga);
    }

    [TestMethod]
    public void TampilkanInformasi_CorrectOutput()
    {
        var peralatan = new PeralatanOlahraga("Raket", "Yonex");
        peralatan.TampilkanInformasi();
        Assert.IsTrue(stringWriter.ToString().Contains("Peralatan Olahraga Jenis: Raket, Merek: Yonex"));
    }

    [TestMethod]
    public void TampilkanSpesifikasi_CorrectOutput()
    {
        var bola = new Bola("Bola", "Nike", "Sepakbola", "Kulit");
        bola.TampilkanSpesifikasi();
        Assert.IsTrue(stringWriter.ToString().Contains("Jenis Olahraga: Sepakbola, Bahan: Kulit"));
    }

    [TestMethod]
    public void TampilkanStandar_CorrectOutput()
    {
        var bolaProfesional = new BolaProfesional("Bola", "Adidas", "Basket", "Karet", true);
        bolaProfesional.TampilkanStandar();
        var output = stringWriter.ToString();
        Assert.IsTrue(output.Contains("Jenis Olahraga: Basket, Bahan: Karet") && output.Contains("Standar Internasional: Ya"));
    }
}
