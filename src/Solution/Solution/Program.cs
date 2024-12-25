using System;
using Solution.Transaction;
using Solution.Registration;
using Solution.StockManager;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        //Soal: Transaction
        Console.WriteLine("Demo Transaksi:");
        Transaksi t1 = new Transaksi(100);
        Transaksi t2 = new Transaksi(200);
        Transaksi t3 = new Transaksi(300);

        Console.WriteLine($"ID Transaksi 1: {t1.GetTransaksiID()}");
        Console.WriteLine($"ID Transaksi 2: {t2.GetTransaksiID()}");
        Console.WriteLine($"ID Transaksi 3: {t3.GetTransaksiID()}");
        Console.WriteLine($"Total Transaksi: {Transaksi.GetTotalTransaksi()}");

        Transaksi.ResetCounter();
        Console.WriteLine($"Setelah reset, Total Transaksi: {Transaksi.GetTotalTransaksi()}");
        Console.WriteLine();

        //Soal: Pendaftaran Mahasiswa
        Console.WriteLine("Demo Pendaftaran Mahasiswa:");
        Mahasiswa m1 = new Mahasiswa("Alice");
        Mahasiswa m2 = new Mahasiswa("Bob");
        Mahasiswa m3 = new Mahasiswa("Charlie");

        Console.WriteLine($"Nomor Pendaftaran Alice: {m1.GetNomorPendaftaran()}");
        Console.WriteLine($"Nomor Pendaftaran Bob: {m2.GetNomorPendaftaran()}");
        Console.WriteLine($"Nomor Pendaftaran Charlie: {m3.GetNomorPendaftaran()}");
        Console.WriteLine($"Total Mahasiswa Terdaftar: {Mahasiswa.GetTotalRegistrant()}");

        Mahasiswa.ResetRegistrantCounter();
        Console.WriteLine($"Setelah reset, Total Mahasiswa Terdaftar: {Mahasiswa.GetTotalRegistrant()}");
        Console.WriteLine();

        //Soal: Stock Manager
        Console.WriteLine("Demo Stock Manager:");
        new Barang(50);
        Console.WriteLine("Stok awal: 50");
        Barang.TampilkanStok();

        Console.WriteLine("Menjual 20 unit.");
        Barang.JualBarang(20);
        Barang.TampilkanStok();

        Console.WriteLine("Restok 30 unit.");
        Barang.Restok(30);
        Barang.TampilkanStok();

        Console.WriteLine("Percobaan menjual 70 unit:");
        Barang.JualBarang(70);
        Barang.TampilkanStok();

        Barang.ResetStok();
        Console.WriteLine("Setelah reset stok:");
        Barang.TampilkanStok();
    }
}