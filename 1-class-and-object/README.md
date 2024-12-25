[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/XWKTmq8k)
# oop-class-and-object-csharp

## Sub Capaian Pembelajaran

1. Mahasiswa mampu mendeklarasikan kelas yang berisi atribut dan metode sesuai spesifikasi.
2. Mahasiswa mampu menginstansiasi kelas menjadi objek dan mengoperasikan metode-metode di objek tersebut.

## Lingkungan Pengembangan

1. Platform: .NET 6.0
2. Bahasa: C# 10
3. IDE: Visual Studio 2022

## Cara membuka project menggunakan Visual Studio

1. Clone repositori project `oop-class-and-object-csharp` ke direktori lokal git Anda.
2. Buka Visual Studio, pilih menu File > Open > Project/Solution > Pilih file *.sln.
3. Tekan tombol Open untuk  untuk membuka solusi.
4. Baca soal dengan seksama. Buat implementasi kode sesuai dengan petunjuk.
6. Jalankan unit test di project *.Tests

> PERINGATAN: Push kode program ke remote repository jika hanya seluruh test case sudah lolos/passed (bertanda hijau).

## Soal-soal

### Buku

Buat solusi dari soal ini di project `ClassAndObject` folder `Perpustakaan` dengan namespace `ClassAndObject.Perpustakaan`.

Buatlah sebuah kelas publik bernama `Buku` yang merepresentasikan informasi tentang buku. Kelas `Buku` harus memiliki tiga properti publik yaitu: `Judul` (tipe string), `Penulis` (tipe string), dan `TahunTerbit` (tipe int). Selain itu, kelas `Buku` harus memiliki sebuah konstruktor yang menginisialisasi ketiga atribut tersebut berdasarkan parameter yang diberikan saat objek dibuat.

Tambahkan sebuah metode publik dalam kelas `Buku` bernama `TampilkanInfo`, yang ketika dipanggil, akan mencetak informasi buku tersebut dalam format: "Judul: [Judul], Penulis: [Penulis], Tahun Terbit: [TahunTerbit]".

Buat kelas `Program` dan metode statik `Main`. Buatlah objek dari kelas `Buku` dengan memberikan judul, penulis, dan tahun terbit sebagai argumen konstruktor. Kemudian, panggil metode `TampilkanInfo` pada objek `Buku` tersebut untuk menampilkan informasi buku ke konsol.

### Mobil

Buat solusi dari soal ini di project `ClassAndObject` folder `Kendaraan` dengan namespace `ClassAndObject.Kendaraan`.

Buatlah sebuah kelas publik bernama `Mobil` yang merepresentasikan informasi tentang mobil. Kelas `Mobil` harus memiliki tiga properti publik, yaitu: `Merk` (tipe string), `Model` (tipe string), dan `TahunProduksi` (tipe int). Kelas ini juga harus memiliki sebuah konstruktor yang menginisialisasi ketiga atribut tersebut dengan nilai yang diberikan saat objek dibuat.

Tambahkan sebuah metode publik dalam kelas `Mobil` bernama `TampilkanSpesifikasi`, yang ketika dipanggil, akan mencetak spesifikasi mobil tersebut dalam format: "Merk: [Merk], Model: [Model], Tahun Produksi: [TahunProduksi]".

Buat kelas `Program` dan metode statik `Main`. Buatlah objek dari kelas `Mobil` dengan memberikan merk, model, dan tahun produksi sebagai argumen konstruktor. Setelah objek terbuat, panggil metode `TampilkanSpesifikasi` pada objek tersebut untuk menampilkan spesifikasi mobil ke konsol.

### Laptop

Buat solusi dari soal ini di project `ClassAndObject` folder `TokoLaptop` dengan namespace `ClassAndObject.TokoLaptop`.

Buatlah sebuah kelas publik bernama `Laptop` yang merepresentasikan spesifikasi dari sebuah laptop. Kelas `Laptop` harus memiliki empat properti publik, yaitu: `Merk` (tipe String), `Prosesor` (tipe String), `Ram` (tipe int), dan `Penyimpanan` kapasitas penyimpanan dalam GB (tipe int). Kelas ini juga harus memiliki sebuah konstruktor yang menginisialisasi keempat atribut tersebut berdasarkan parameter yang diberikan saat objek dibuat.

Tambahkan sebuah metode publik dalam kelas `Laptop` bernama `TampilkanSpesifikasi`, yang ketika dipanggil, akan mencetak spesifikasi laptop tersebut dalam format: "Merk: [Merk], Prosesor: [Prosesor], RAM: [Ram] GB, Penyimpanan: [Penyimpanan] GB".

Buat kelas `Program` dan metode statik `Main`. Buatlah objek dari kelas `Laptop` dengan memberikan merk, prosesor, ram, penyimpanan sebagai argumen konstruktor. Setelah objek terbuat, panggil metode `TampilkanSpesifikasi` pada objek tersebut untuk menampilkan spesifikasi laptop ke konsol.

### Sepeda

Buat solusi dari soal ini di project `ClassAndObject` folder `TokoSepeda` dengan namespace `ClassAndObject.TokoSepeda`.

Buatlah sebuah kelas publik bernama `Sepeda` yang merepresentasikan spesifikasi dan informasi sepeda. Kelas `Sepeda` harus memiliki tiga properti publik, yaitu: `Merk` (tipe String), `Tipe` (tipe String), dan `Berat` dalam kilogram (tipe double). Kelas ini juga harus memiliki sebuah konstruktor yang menginisialisasi ketiga atribut tersebut dengan nilai yang diberikan saat objek dibuat.

Tambahkan sebuah metode publik dalam kelas `Sepeda` bernama `TampilkanInformasi`, yang ketika dipanggil, akan mencetak informasi sepeda tersebut dalam format: "Merek: [Merk], Tipe: [Tipe], Berat: [Berat] kg".

Buat kelas `Program` dan metode statik `Main`. Buatlah objek dari kelas `Sepeda` dengan memberikan merek, tipe, dan berat sebagai argumen konstruktor. Setelah objek terbuat, panggil metode `TampilkanInformasi` pada objek tersebut untuk menampilkan informasi sepeda ke konsol.

### Kalkulator

Buat solusi dari soal ini di project `ClassAndObject` folder `OperasiMatematika` dengan namespace `ClassAndObject.OperasiMatematika`.

Buatlah sebuah kelas publik bernama `Kalkulator` yang dapat melakukan operasi dasar matematika seperti penjumlahan, pengurangan, perkalian, dan pembagian. Kelas `Kalkulator` tidak perlu memiliki atribut, tetapi harus memiliki empat metode publik: `Tambah`, `Kurang`, `Kali`, dan `Bagi`, masing-masing metode menerima dua parameter bertipe `double` dan mengembalikan hasil operasi tersebut sebagai `double`.

Buat kelas `Program` dan metode statik `Main`. Buatlah objek dari kelas `Kalkulator`. Kemudian, gunakan objek tersebut untuk melakukan beberapa operasi matematika dan mencetak hasilnya ke konsol. Misalnya, lakukan penjumlahan dua angka, pengurangan dua angka, perkalian dua angka, dan pembagian dua angka, kemudian tampilkan hasil dari masing-masing operasi tersebut.

=== Selesai ===


