using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassAndObject.TokoLaptop;
using System.IO;
using System;

namespace ClassAndObject.Tests.TokoLaptop
{
    [TestClass]
    public class LaptopTests
    {
        [TestMethod]
        public void Laptop_Constructor_PropertiesSetCorrectly()
        {
            // Arrange
            string expectedMerk = "Dell";
            string expectedProsesor = "Intel Core i7";
            int expectedRam = 16;
            int expectedPenyimpanan = 512;

            // Act
            Laptop laptop = new Laptop(expectedMerk, expectedProsesor, expectedRam, expectedPenyimpanan);

            // Assert
            Assert.AreEqual(expectedMerk, laptop.Merk, "Merk laptop tidak sesuai dengan yang diharapkan.");
            Assert.AreEqual(expectedProsesor, laptop.Prosesor, "Prosesor laptop tidak sesuai dengan yang diharapkan.");
            Assert.AreEqual(expectedRam, laptop.Ram, "RAM laptop tidak sesuai dengan yang diharapkan.");
            Assert.AreEqual(expectedPenyimpanan, laptop.Penyimpanan, "Penyimpanan laptop tidak sesuai dengan yang diharapkan.");
        }

        [TestMethod]
        public void TampilkanSpesifikasi_Output_Test()
        {
            // Arrange
            var laptop = new Laptop("Dell", "Intel Core i7", 16, 512);
            var expectedOutput = $"Merk: Dell, Prosesor: Intel Core i7, RAM: 16 GB, Penyimpanan: 512 GB{Environment.NewLine}";
            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            laptop.TampilkanSpesifikasi();
            var result = sw.ToString();

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }
    }
}
