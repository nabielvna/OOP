using ClassAndObject.TokoSepeda;

namespace ClassAndObject.Tests.TokoSepedaTests;

[TestClass]
public class SepedaTests
{
    [TestMethod]
    public void Sepeda_Constructor_PropertiesSetCorrectly()
    {
        // Arrange
        string expectedMerk = "Polygon";
        string expectedTipe = "Mountain Bike";
        double expectedBerat = 14.5;

        // Act
        Sepeda sepeda = new Sepeda(expectedMerk, expectedTipe, expectedBerat);

        // Assert
        Assert.AreEqual(expectedMerk, sepeda.Merk);
        Assert.AreEqual(expectedTipe, sepeda.Tipe);
        Assert.AreEqual(expectedBerat, sepeda.Berat);
    }

    [TestMethod]
    public void TampilkanInformasi_Output_Test()
    {
        // Arrange
        var sepeda = new Sepeda("Polygon", "Mountain Bike", 14.5);
        var expectedOutput = $"Merek: Polygon, Tipe: Mountain Bike, Berat: 14.5 kg{Environment.NewLine}";
        using var sw = new StringWriter();
        Console.SetOut(sw);

        // Act
        sepeda.TampilkanInformasi();

        // Assert
        var result = sw.ToString();
        Assert.AreEqual(expectedOutput, result);
    }
}
