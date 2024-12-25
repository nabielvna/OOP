using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution.Vehicles;

namespace Solution.Vehicles.Tests;

[TestClass]
public class VehicleTests
{
    [TestMethod]
    public void Kendaraan_Constructor_AssignsValuesCorrectly()
    {
        var kendaraan = new Kendaraan("Toyota", "Camry");

        Assert.AreEqual("Toyota", kendaraan.Merk);
        Assert.AreEqual("Camry", kendaraan.Model);
    }

    [TestMethod]
    public void Mobil_Constructor_AssignsValuesCorrectly()
    {
        var mobil = new Mobil("Toyota", "Camry", "Sedan");

        Assert.AreEqual("Toyota", mobil.Merk);
        Assert.AreEqual("Camry", mobil.Model);
        Assert.AreEqual("Sedan", mobil.TipeBodi);
    }

    [TestMethod]
    public void Motor_Constructor_AssignsValuesCorrectly()
    {
        var motor = new Motor("Yamaha", "YZF-R1", "4 Stroke");

        Assert.AreEqual("Yamaha", motor.Merk);
        Assert.AreEqual("YZF-R1", motor.Model);
        Assert.AreEqual("4 Stroke", motor.TipeMesin);
    }
}
