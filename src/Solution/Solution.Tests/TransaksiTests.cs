using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution.Transaction;

namespace Solution.Tests;

[TestClass]
public class TransaksiTests
{
    [TestInitialize]
    public void Initialize()
    {
        // Reset the counter before each test to ensure a consistent start state
        Transaksi.ResetCounter();
    }

    [TestMethod]
    public void Transaksi_Constructor_ShouldIncrementId()
    {
        var transaksi1 = new Transaksi(100);
        Assert.AreEqual(1, transaksi1.GetTransaksiID(), "The ID of the first transaction should be 1.");

        var transaksi2 = new Transaksi(200);
        Assert.AreEqual(2, transaksi2.GetTransaksiID(), "The ID of the second transaction should be 2.");
    }

    [TestMethod]
    public void GetTotalTransaksi_ShouldReturnCorrectCount()
    {
        var t1 = new Transaksi(100);
        var t2 = new Transaksi(200);

        Assert.AreEqual(2, Transaksi.GetTotalTransaksi(), "Total transactions should be 2 after creating two transactions.");
    }

    [TestMethod]
    public void ResetCounter_ShouldResetTransactionCount()
    {
        var t1 = new Transaksi(100);
        var t2 = new Transaksi(200);

        Transaksi.ResetCounter(); // Resetting the counter

        var t3 = new Transaksi(300);
        Assert.AreEqual(1, t3.GetTransaksiID(), "After reset, the ID of the next transaction should be 1.");
        Assert.AreEqual(1, Transaksi.GetTotalTransaksi(), "Total transactions should be 1 after reset and creating one new transaction.");
    }
}
