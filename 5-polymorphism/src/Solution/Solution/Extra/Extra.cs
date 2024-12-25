using System;
using System.Collections.Generic;

namespace Solution.Extra
{
    public abstract class Media
    {
        public string Judul { get; protected set; }
        public string Penulis { get; protected set; }

        public Media(string judul, string penulis)
        {
            Judul = judul;
            Penulis = penulis;
        }

        public abstract string GetInfo();
        public abstract void Pinjam();
    }

    public class Buku : Media
    {
        public int JumlahHalaman { get; private set; }

        public Buku(string judul, string penulis, int jumlahHalaman) : base(judul, penulis)
        {
            JumlahHalaman = jumlahHalaman;
        }

        public override string GetInfo()
        {
            return $"Buku: {Judul} oleh {Penulis}, {JumlahHalaman} halaman";
        }

        public override void Pinjam()
        {
            Console.WriteLine($"Buku '{Judul}' dipinjam untuk 14 hari.");
        }
    }

    public class Majalah : Media
    {
        public string Edisi { get; private set; }

        public Majalah(string judul, string penulis, string edisi) : base(judul, penulis)
        {
            Edisi = edisi;
        }

        public override string GetInfo()
        {
            return $"Majalah: {Judul}, Edisi {Edisi}, oleh {Penulis}";
        }

        public override void Pinjam()
        {
            Console.WriteLine($"Majalah '{Judul}' dipinjam untuk 7 hari.");
        }
    }

    public class Perpustakaan
    {
        private List<Media> koleksi = new List<Media>();

        public void TambahMedia(Media media)
        {
            koleksi.Add(media);
        }

        public void TampilkanKoleksi()
        {
            foreach (var media in koleksi)
            {
                Console.WriteLine(media.GetInfo());
            }
        }

        public void PinjamMedia(string judul)
        {
            var media = koleksi.Find(m => m.Judul.Equals(judul, StringComparison.OrdinalIgnoreCase));
            if (media != null)
            {
                media.Pinjam();
            }
            else
            {
                Console.WriteLine($"Media dengan judul '{judul}' tidak ditemukan.");
            }
        }
    }
}