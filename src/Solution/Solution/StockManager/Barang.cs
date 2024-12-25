using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.StockManager
{
    public class Barang
    {
        public static int TotalStok { get; private set; }

        public Barang(int jumlahBarang)
        {
            TotalStok += jumlahBarang;
        }

        public static void JualBarang(int jumlahTerjual)
        {
            if (jumlahTerjual <= TotalStok)
            {
                TotalStok -= jumlahTerjual;
            }
            else
            {
                Console.WriteLine("Gagal, stok tidak mencukupi.");
            }
        }

        public static void Restok(int jumlahBarang)
        {
            TotalStok += jumlahBarang;
        }

        public static void ResetStok()
        {
            TotalStok = 0;
        }

        public static void TampilkanStok()
        {
            Console.WriteLine($"Stok saat ini: {TotalStok}");
        }
    }
}