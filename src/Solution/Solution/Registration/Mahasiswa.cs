using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Registration
{
    public class Mahasiswa
    {
        private static int _registrantCounter = 0;
        private int _nomorPendaftaran;
        private string _nama;

        public Mahasiswa(string nama)
        {
            _registrantCounter++;
            _nomorPendaftaran = _registrantCounter;
            _nama = nama;
        }

        public int GetNomorPendaftaran()
        {
            return _nomorPendaftaran;
        }

        public static int GetTotalRegistrant()
        {
            return _registrantCounter;
        }

        public static void ResetRegistrantCounter()
        {
            _registrantCounter = 0;
        }
    }
}