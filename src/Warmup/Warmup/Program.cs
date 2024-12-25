using System;

namespace Warmup.HelloCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            string input = "";
            
            while (input != "exit")
            {
                Console.WriteLine("Masukkan angka pertama:");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Masukkan angka kedua:");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Pilih operasi (Tambah, Kurang, Kali, Bagi):");
                string operasi = Console.ReadLine();

                switch (operasi.ToLower())
                {
                    case "tambah":
                        calculator.Tambah(a, b);
                        break;
                    case "kurang":
                        calculator.Kurang(a, b);
                        break;
                    case "kali":
                        calculator.Kali(a, b);
                        break;
                    case "bagi":
                        calculator.Bagi(a, b);
                        break;
                    default:
                        Console.WriteLine("Operasi tidak valid. Silakan pilih Tambah, Kurang, Kali, atau Bagi.");
                        break;
                }

                Console.WriteLine("Ketik 'exit' untuk keluar, atau tekan Enter untuk melanjutkan.");
                input = Console.ReadLine();
            }
        }
    }
}