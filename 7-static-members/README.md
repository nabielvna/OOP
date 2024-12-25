[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/Ok3kZUOs)
# oop-static-members-csharp

## Sub Capaian Pembelajaran

1. Mahasiswa mampu menggunakan static members seperti static fields/properties maupun static methods sesuai dengan kebutuhan

## Lingkungan Pengembangan

1. Platform: .NET 6.0
2. Bahasa: C# 10
3. IDE: Visual Studio 2022

## Cara membuka project menggunakan Visual Studio

1. Clone repositori project `oop-static-members-csharp` ke direktori lokal git Anda.
2. Buka Visual Studio, pilih menu File > Open > Project/Solution > Pilih file *.sln.
3. Tekan tombol Open untuk  untuk membuka solusi.
4. Baca soal dengan seksama. Buat implementasi kode sesuai dengan petunjuk.
6. Jalankan unit test di project *.Tests

> PERINGATAN: Push kode program ke remote repository jika hanya seluruh test case sudah lolos/passed (bertanda hijau).

## Soal-soal

### Soal: Penghitung Transaksi

Buat solusi dari soal ini di project `Solution` folder `Transaction` dengan namespace `Solution.Transaction`.

Sebuah aplikasi perbankan memerlukan sistem untuk menghitung jumlah transaksi yang dilakukan. Setiap transaksi yang dilakukan memiliki ID unik yang bersifat berurutan.

Buatlah sebuah kelas bernama `Transaksi` dengan spesifikasi sebagai berikut:

- Memiliki variabel private `static` bernama `_counter` yang digunakan untuk menghitung jumlah transaksi yang telah dilakukan.
- Memiliki variabel instance private `_transaksiID` yang digunakan untuk menyimpan ID dari transaksi tersebut.
- Memiliki variabel instance private `_jumlah` yang digunakan untuk menyimpan jumlah transaksi.
- Memiliki konstruktor yang menerima parameter `jumlah` dan menginisialisasi variabel instance `jumlah`. Setiap kali objek `Transaksi` dibuat, `counter` akan bertambah dan `transaksiID` akan di-set sesuai dengan nilai `counter` saat itu.
- Memiliki metode public `GetTransaksiID` yang mengembalikan ID dari transaksi tersebut.
- Memiliki metode public `static` `GetTotalTransaksi` yang mengembalikan total transaksi yang telah dilakukan.
- Memiliki metode public `static` `ResetCounter` yang mengatur ulang `counter` menjadi 0.

Buatlah sebuah kelas bernama `Program` yang didalamnya terdapat metode static `Main`. Dalam metode `Main`, instansiasi beberapa objek dari kelas `Transaksi`, tampilkan ID transaksi dan total transaksi ke layar. Setelah itu, gunakan metode `resetCounter` untuk mengatur ulang penghitung transaksi dan tampilkan kembali total transaksi ke layar.

**Perhatikan:**
1. Pastikan setiap objek `Transaksi` yang dibuat memiliki ID yang unik dan berurutan.
2. Pastikan metode `GetTotalTransaksi` mengembalikan jumlah total transaksi yang telah dibuat.

### Soal: Pendaftaran Mahasiswa

Buat solusi dari soal ini di project `Solution` folder `Registration` dengan namespace `Solution.Registration`.

Sebuah universitas memerlukan sistem untuk menghitung jumlah mahasiswa yang telah mendaftar. Setiap mahasiswa yang mendaftar akan mendapatkan nomor pendaftaran unik yang bersifat berurutan.

Buatlah sebuah kelas bernama `Mahasiswa` dengan spesifikasi sebagai berikut:

- Memiliki variabel private `static` bernama `_registrantCounter` yang digunakan untuk menghitung jumlah mahasiswa yang telah mendaftar.
- Memiliki variabel instance private `_nomorPendaftaran` yang digunakan untuk menyimpan nomor pendaftaran mahasiswa tersebut.
- Memiliki variabel instance private `_nama` yang digunakan untuk menyimpan nama mahasiswa.
- Memiliki konstruktor yang menerima parameter `nama` dan menginisialisasi variabel instance `_nama`. Setiap kali objek `Mahasiswa` dibuat, `RegistrantCounter` akan bertambah dan `_nomorPendaftaran` akan di-set sesuai dengan nilai `RegistrantCounter` saat itu.
- Memiliki metode public `GetNomorPendaftaran` yang mengembalikan nomor pendaftaran mahasiswa tersebut.
- Memiliki metode public `static` `GetTotalRegistrant` yang mengembalikan total mahasiswa yang telah mendaftar.
- Memiliki metode public `static` `ResetRegistrantCounter` yang mengatur ulang `_registrantCounter` menjadi 0.

Buatlah sebuah kelas bernama `Program` yang didalamnya terdapat metode static `Main`. Dalam metode `Main`, instansiasi beberapa objek dari kelas `Mahasiswa`, tampilkan nomor pendaftaran dan total mahasiswa yang telah mendaftar ke layar. Setelah itu, gunakan metode `ResetRegistrantCounter` untuk mengatur ulang penghitung pendaftaran dan tampilkan kembali total mahasiswa yang telah mendaftar ke layar.

### Soal: Pengelolaan Stok Toko

Buat solusi dari soal ini di project `Solution` folder `StockManager` dengan namespace `Solution.StockManager`.

Sebuah toko perlu mengelola stok barang mereka secara efisien. Setiap kali barang masuk atau keluar, jumlah total barang di gudang harus diperbarui. Tujuan dari sistem ini adalah untuk melacak total stok barang yang tersedia di toko menggunakan anggota kelas statis.

Buatlah sebuah kelas bernama `Barang` dengan spesifikasi sebagai berikut:

1. **Kelas Barang**: Buat kelas publik `Barang` dengan properti statis publik `TotalStok` yang digunakan untuk menghitung jumlah total stok barang yang tersedia di toko.
   
2. **Konstruktor**: Kelas `Barang` memiliki konstruktor yang menerima parameter `jumlahBarang`, yang menandakan jumlah barang yang masuk ke toko. Konstruktor ini akan menambahkan `jumlahBarang` ke `TotalStok`.

3. **Metode Penjualan**: Tambahkan metode statis `JualBarang` yang menerima parameter `jumlahTerjual`. Metode ini akan mengurangi `jumlahTerjual` dari `TotalStok`. Jika `jumlahTerjual` lebih besar dari `TotalStok`, metode akan mencetak pesan bahwa stok tidak mencukupi dan tidak akan mengurangi `TotalStok`.

4. **Metode Restok**: Tambahkan metode statis `Restok` yang menerima parameter `jumlahBarang` untuk menambahkan barang ke `TotalStok`.

5. **Metode ResetStok**: Tambahkan metode statis `ResetStok` yang mengembalikan nilai `TotalStok` menjadi 0.

6. **Metode Penampilan Stok**: Buat metode statis `TampilkanStok` yang mencetak jumlah `TotalStok` saat ini.

7. **Demo Program**: Buat kelas `Program` dengan metode `Main` untuk mendemonstrasikan penggunaan kelas `Barang`. Dalam metode `Main`, instansiasi beberapa objek `Barang`, gunakan `JualBarang`, dan `Restok` untuk mengelola stok, kemudian tampilkan stok terkini.

#### Contoh Implementasi:

Misalnya, sebuah toko memiliki stok awal 50 unit. Penjualan 20 unit dilakukan, kemudian restok 30 unit, dan kemudian penjualan 70 unit yang tidak dapat dilakukan karena melebihi stok.

#### Contoh Output:

```
Stok awal: 50
Menjual 20 unit.
Stok saat ini: 30
Restok 30 unit.
Stok saat ini: 60
Percobaan menjual 70 unit: Gagal, stok tidak mencukupi.
Stok saat ini: 60
```

=== Selesai ===


