using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassAndObject.Kendaraan;
using System.IO;
using System;

namespace ClassAndObject.Tests.KendaraanTests;

[TestClass]
public class MobilTests
{
    [TestMethod]
    public void Mobil_ConstructorAndProperties_Test()
    {
        // Arrange
        var merk = "Toyota";
        var model = "Corolla";
        var tahunProduksi = 2020;

        // Act
        var mobil = new Mobil(merk, model, tahunProduksi);

        // Assert
        Assert.AreEqual(merk, mobil.Merk);
        Assert.AreEqual(model, mobil.Model);
        Assert.AreEqual(tahunProduksi, mobil.TahunProduksi);
    }

    [TestMethod]
    public void TampilkanSpesifikasi_Output_Test()
    {
        // Arrange
        var mobil = new Mobil("Toyota", "Corolla", 2020);
        var expectedOutput = $"Merk: Toyota, Model: Corolla, Tahun Produksi: 2020{Environment.NewLine}";
        using var sw = new StringWriter();
        Console.SetOut(sw);

        // Act
        mobil.TampilkanSpesifikasi();

        // Assert
        var result = sw.ToString();
        Assert.AreEqual(expectedOutput, result);
    }
}
