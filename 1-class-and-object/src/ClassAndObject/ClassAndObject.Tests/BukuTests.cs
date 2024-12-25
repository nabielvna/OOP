using ClassAndObject.Perpustakaan;

namespace ClassAndObject.Tests.BukuPerpustakaanTests;

[TestClass]
public class BukuTests
{
    [TestMethod]
    public void Buku_Constructor_PropertiesSetCorrectly()
    {
        // Arrange
        string expectedJudul = "Nama Buku";
        string expectedPenulis = "Penulis Buku";
        int expectedTahunTerbit = 2021;

        // Act
        Buku buku = new Buku(expectedJudul, expectedPenulis, expectedTahunTerbit);

        // Assert
        Assert.AreEqual(expectedJudul, buku.Judul, "Judul buku tidak sesuai dengan yang diharapkan.");
        Assert.AreEqual(expectedPenulis, buku.Penulis, "Penulis buku tidak sesuai dengan yang diharapkan.");
        Assert.AreEqual(expectedTahunTerbit, buku.TahunTerbit, "Tahun terbit buku tidak sesuai dengan yang diharapkan.");
    }

    [TestMethod]
    public void TampilkanInfoTest()
    {
        // Arrange
        var buku = new Buku("Nama Buku", "Penulis Buku", 2021);
        string expected = $"Judul: Nama Buku, Penulis: Penulis Buku, Tahun Terbit: 2021{Environment.NewLine}";
        using var sw = new StringWriter();
        Console.SetOut(sw);

        // Act
        buku.TampilkanInfo();
        var result = sw.ToString();

        // Assert
        Assert.AreEqual(expected, result);
    }
}
