using System;

namespace Warmup.HelloCalculator
{
    public class Calculator
    {
        public double Tambah(double a, double b)
        {
            double hasil = a + b;
            TampilkanHasil("Penjumlahan", hasil);
            return hasil;
        }

        public double Kurang(double a, double b)
        {
            double hasil = a - b;
            TampilkanHasil("Pengurangan", hasil);
            return hasil;
        }

        public double Kali(double a, double b)
        {
            double hasil = a * b;
            TampilkanHasil("Perkalian", hasil);
            return hasil;
        }

        public double Bagi(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Kesalahan: Pembagian dengan nol tidak diperbolehkan.");
                return double.NaN;
            }
            else
            {
                double hasil = a / b;
                TampilkanHasil("Pembagian", hasil);
                return hasil;
            }
        }

        private void TampilkanHasil(string operasi, double hasil)
        {
            Console.WriteLine($"Hasil operasi {operasi}: {hasil}");
        }
    }
}