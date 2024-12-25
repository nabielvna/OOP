using Solution.StockManager;
using System;

namespace Solution.Tests;

[TestClass]
public class BarangTests
{
    [TestInitialize]
    public void Initialize()
    {
        // Reset stok sebelum setiap test untuk menghindari dependency antar test
        Barang.ResetStok();
    }

    [TestMethod]
    public void Barang_StokAwalBenar()
    {
        new Barang(100);
        Assert.AreEqual(100, Barang.TotalStok, "Stok awal harus sesuai dengan yang ditambahkan.");
    }

    [TestMethod]
    public void JualBarang_StokBerkurang()
    {
        new Barang(100);
        Barang.JualBarang(30);
        Assert.AreEqual(70, Barang.TotalStok, "Stok harus berkurang setelah penjualan.");
    }

    [TestMethod]
    public void JualBarang_GagalJikaStokTidakCukup()
    {
        new Barang(50);
        Barang.JualBarang(70);
        Assert.AreEqual(50, Barang.TotalStok, "Stok tidak boleh berkurang jika penjualan melebihi stok yang ada.");
    }

    [TestMethod]
    public void Restok_TambahStok()
    {
        new Barang(50);
        Barang.Restok(20);
        Assert.AreEqual(70, Barang.TotalStok, "Stok harus bertambah setelah restok.");
    }

    [TestMethod]
    public void ResetStok_StokKembaliKeNol()
    {
        new Barang(100);
        Barang.ResetStok();
        Assert.AreEqual(0, Barang.TotalStok, "Stok harus kembali ke 0 setelah reset.");
    }
}