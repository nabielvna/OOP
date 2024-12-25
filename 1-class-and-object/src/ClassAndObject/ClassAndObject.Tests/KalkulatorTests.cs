using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassAndObject.OperasiMatematika;

namespace ClassAndObject.Tests.OperasiMatematikaTests;

[TestClass]
public class KalkulatorTests
{
    private Kalkulator kalkulator;

    [TestInitialize]
    public void Setup()
    {
        // Initialize Kalkulator object before each test
        kalkulator = new Kalkulator();
    }

    [TestMethod]
    public void Tambah_ReturnsCorrectValue()
    {
        Assert.AreEqual(8, kalkulator.Tambah(5, 3));
    }

    [TestMethod]
    public void Kurang_ReturnsCorrectValue()
    {
        Assert.AreEqual(2, kalkulator.Kurang(5, 3));
    }

    [TestMethod]
    public void Kali_ReturnsCorrectValue()
    {
        Assert.AreEqual(15, kalkulator.Kali(5, 3));
    }

    [TestMethod]
    public void Bagi_ReturnsCorrectValue()
    {
        Assert.AreEqual(2, kalkulator.Bagi(6, 3));
    }

    [TestMethod]
    public void Bagi_ByZero()
    {
        // Test division by zero - should return Infinity or throw an exception based on implementation
        Assert.IsTrue(double.IsInfinity(kalkulator.Bagi(1, 0)));
    }
}
