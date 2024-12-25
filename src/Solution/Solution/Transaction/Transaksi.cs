using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Transaction
{
    public class Transaksi
    {
        private static int _counter = 0;
        private int _transaksiID;
        private decimal _jumlah;

        public Transaksi(decimal jumlah)
        {
            _counter++;
            _transaksiID = _counter;
            _jumlah = jumlah;
        }

        public int GetTransaksiID()
        {
            return _transaksiID;
        }

        public static int GetTotalTransaksi()
        {
            return _counter;
        }

        public static void ResetCounter()
        {
            _counter = 0;
        }
    }
}