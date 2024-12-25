using Solution.Books;

namespace Solution.Tests;

[TestClass]
public class BukuTests
{
    [TestMethod]
    public void Buku_Constructor_AssignsValuesCorrectly()
    {
        var buku = new Buku("Judul Buku", "Pengarang Buku");

        Assert.AreEqual("Judul Buku", buku.Judul);
        Assert.AreEqual("Pengarang Buku", buku.Pengarang);
    }

    [TestClass]
    public class BukuFiksiTests
    {
        [TestMethod]
        public void BukuFiksi_Constructor_AssignsValuesCorrectly()
        {
            var bukuFiksi = new BukuFiksi("Judul Buku Fiksi", "Pengarang Buku Fiksi", "Fantasi");

            Assert.AreEqual("Judul Buku Fiksi", bukuFiksi.Judul);
            Assert.AreEqual("Pengarang Buku Fiksi", bukuFiksi.Pengarang);
            Assert.AreEqual("Fantasi", bukuFiksi.Genre);
        }
    }

    [TestClass]
    public class BukuPelajaranTests
    {
        [TestMethod]
        public void BukuPelajaran_Constructor_AssignsValuesCorrectly()
        {
            var bukuPelajaran = new BukuPelajaran("Judul Buku Pelajaran", "Pengarang Buku Pelajaran", "Matematika");

            Assert.AreEqual("Judul Buku Pelajaran", bukuPelajaran.Judul);
            Assert.AreEqual("Pengarang Buku Pelajaran", bukuPelajaran.Pengarang);
            Assert.AreEqual("Matematika", bukuPelajaran.Subjek);
        }
    }
}
