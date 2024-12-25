using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution.ElectronicDevices;
using System;
using System.IO;

namespace Solution.ElectronicDevices.Tests;

[TestClass]
public class FlagshipPhoneTests
{
    [TestMethod]
    public void TampilkanIdentitas_CorrectOutput()
    {
        var perangkat = new PerangkatElektronik("BrandTest", "ModelTest");
        Assert.AreEqual("BrandTest", perangkat.Brand);
        Assert.AreEqual("ModelTest", perangkat.Model);
    }

    [TestMethod]
    public void TampilkanIdentitas_CorrectlyDisplaysBrandAndModel()
    {
        // Buat instance PerangkatElektronik
        var perangkat = new PerangkatElektronik("BrandTest", "ModelTest");

        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);

            // Panggil TampilkanIdentitas
            perangkat.TampilkanIdentitas();

            // Dapatkan output yang telah dicetak ke konsol
            var result = sw.ToString().Trim();

            // Verifikasi output
            Assert.IsTrue(result.Contains("Perangkat Brand: BrandTest, Model: ModelTest"));
        }
    }

    [TestMethod]
    public void TampilkanFiturDasar_CorrectOutput()
    {
        var smartphone = new Smartphone("BrandTest", "ModelTest", "Android", "LCD, RAM");
        Assert.AreEqual("Android", smartphone.SistemOperasi);
        Assert.AreEqual("LCD, RAM", smartphone.FiturDasar);
    }

    [TestMethod]
    public void TampilkanFiturDasar_CorrectlyDisplaysBasicFeatures()
    {
        // Buat instance Smartphone dengan fitur dasar
        var smartphone = new Smartphone("BrandTest", "ModelTest", "OS Test", "LCD, RAM");

        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);

            // Panggil TampilkanFiturDasar
            smartphone.TampilkanFiturDasar();

            // Dapatkan output yang telah dicetak ke konsol
            var result = sw.ToString().Trim();

            // Verifikasi bahwa output mencakup fitur dasar
            Assert.IsTrue(result.Contains("Fitur Dasar: LCD, RAM"));
        }
    }

    [TestMethod]
    public void TampilkanFiturPremium_CorrectOutput()
    {
        var flagship = new FlagshipPhone("BrandTest", "ModelTest", "Android", "LCD, RAM", "Camera Telephoto");
        Assert.AreEqual("Camera Telephoto", flagship.FiturPremium);
    }

    [TestMethod]
    public void TampilkanFiturPremium_IncludesBothBasicAndPremiumFeatures()
    {
        // Buat instance FlagshipPhone dengan fitur dasar dan premium
        var flagship = new FlagshipPhone("BrandX", "ModelY", "Android", "LCD, RAM", "Camera Telephoto");

        // Siapkan StringWriter untuk menangkap output
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);

            // Panggil TampilkanFiturPremium yang seharusnya menampilkan fitur dasar dan premium
            flagship.TampilkanFiturPremium();

            // Dapatkan output yang telah dicetak ke konsol
            var result = sw.ToString().Trim();

            // Verifikasi bahwa output mencakup fitur dasar dan premium
            Assert.IsTrue(result.Contains("Fitur Dasar: LCD, RAM"));
            Assert.IsTrue(result.Contains("Fitur Premium: Camera Telephoto"));
        }
    }

    [TestClass]
    public class BudgetPhoneTests
    {
        [TestMethod]
        public void Constructor_AssignsHargaCorrectly()
        {
            var budget = new BudgetPhone("BrandTest", "ModelTest", "Android", "LCD, Basic RAM", 299);
            Assert.AreEqual(299, budget.Harga);
        }
    }
}
