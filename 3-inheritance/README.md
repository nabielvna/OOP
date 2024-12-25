[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/YUIK3yeM)
# oop-inheritance-csharp

## Sub Capaian Pembelajaran

1. Mahasiswa mampu mendeklarasikan relasi pewarisan
2. Mahasiswa mampu menggunakan kata kunci protected pada relasi pewarisan
3. Mahasiswa mampu menggunakan kembali metode dan atribut yang didefinisikan oleh kelas induk di kelas turunan

## Lingkungan Pengembangan

1. Platform: .NET 6.0
2. Bahasa: C# 10
3. IDE: Visual Studio 2022

## Cara membuka project menggunakan Visual Studio

1. Clone repositori project `oop-inheritance-csharp` ke direktori lokal git Anda.
2. Buka Visual Studio, pilih menu File > Open > Project/Solution > Pilih file *.sln.
3. Tekan tombol Open untuk  untuk membuka solusi.
4. Baca soal dengan seksama. Buat implementasi kode sesuai dengan petunjuk.
6. Jalankan unit test di project *.Tests

> PERINGATAN: Push kode program ke remote repository jika hanya seluruh test case sudah lolos/passed (bertanda hijau).

## Soal-soal

### Books

Buat solusi dari soal ini di project `Solution` folder `Books` dengan namespace `Solution.Books`.

Buatlah sebuah kelas publik bernama `Buku` yang digunakan oleh sebuah perpustakaan untuk merepresentasikan sebuah buku yang tersedia di perpustakaan tersebut. Sebuah `Buku` memiliki dua informasi sebagai atribut privat yaitu: `_judul` (tipe String) dan `_pengarang` (tipe String). Kelas `Buku` harus memiliki sebuah konstruktor yang menginisialisasi kedua variabel instance tersebut. Sediakan properti public untuk masing-masing variabel instance yaitu `Judul` dan `Pengarang`.

Dari kelas `Buku`, turunkan dua kelas publik yaitu `BukuFiksi` dan `BukuPelajaran`. Kelas `BukuFiksi` memiliki tambahan informasi sebagai atribut privat yaitu: `_genre` (tipe String, seperti "Fantasi", "Horor", dll.). Sedangkan kelas `BukuPelajaran` memiliki tambahan informasi sebagai atribut private yaitu: `_subjek` (tipe String, seperti "Matematika", "Biologi", dll.). Masing-masing kelas turunan harus memiliki konstruktor yang menginisialisasi semua atribut, termasuk yang diwariskan dari kelas `Buku`. Sediakan properti publik untuk masing-masing atribut tambahan yaitu `Genre` untuk `BukuFiksi` dan `Subjek` untuk `BukuPelajaran`.

Buatlah sebuah kelas bernama `Program` yang didalamnya terdapat metode statik `Main`. Instansiasi 1 objek dari kelas `BukuFiksi` dan 1 objek dari kelas `BukuPelajaran` menggunakan keyword new, set propertinya, dan tampilkan informasi dari kedua buku tersebut ke layar.

### Vehicles

Buat solusi dari soal ini di project `Solution` folder `Vehicles` dengan namespace `Solution.Vehicles`.

Buatlah sebuah kelas publik bernama `Kendaraan` yang digunakan oleh sebuah dealer untuk merepresentasikan sebuah kendaraan yang tersedia di dealer tersebut. Sebuah `Kendaraan` memiliki dua informasi sebagai atribut `protected` yaitu: `_merk` (tipe String) dan `_model` (tipe String). Kelas `Kendaraan` harus memiliki sebuah konstruktor yang menginisialisasi kedua variabel instance tersebut. Sediakan properti publik yang hanya memiliki metode get untuk masing-masing atribut yaitu `Merk` dan `Model`.

Dari kelas `Kendaraan`, turunkan dua kelas publik yaitu `Mobil` dan `Motor`. Kelas `Mobil` memiliki tambahan informasi sebagai atribut `protected` yaitu: `_tipeBodi` (tipe String, seperti "Sedan", "SUV", dll.). Sedangkan kelas `Motor` memiliki tambahan informasi sebagai atribut `protected` yaitu: `_tipeMesin` (tipe String, seperti "2 Stroke", "4 Stroke", dll.). Masing-masing kelas turunan harus memiliki konstruktor yang menginisialisasi semua atribut, termasuk yang diwariskan dari kelas `Kendaraan`. Sediakan properti publik yang hanya memiliki metode get untuk masing-masing atribut tambahan yaitu `TipeBodi` untuk `Mobil` dan `TipeMesin` untuk `Motor`.

Buatlah sebuah kelas bernama `Program` yang didalamnya terdapat metode static `Main`. Instansiasi 1 objek dari kelas `Mobil` dan 1 objek dari kelas `Motor` menggunakan keyword new, set variabel instancenya, dan tampilkan informasi dari kedua kendaraan tersebut ke layar.

### ElectronicDevices

Buat solusi dari soal ini di project `Solution` folder `ElectronicDevices` dengan namespace `Solution.ElectronicDevices`.

Buatlah sebuah kelas publik bernama `PerangkatElektronik` yang digunakan oleh sebuah toko elektronik untuk merepresentasikan sebuah perangkat elektronik yang tersedia di toko tersebut. Sebuah `PerangkatElektronik` memiliki dua informasi sebagai atribut `protected` yaitu: `_brand` (tipe String) dan `_model` (tipe String). Kelas `PerangkatElektronik` harus memiliki sebuah konstruktor yang menginisialisasi kedua variabel instance tersebut. Sediakan properti publik yang hanya memiliki metode get untuk masing-masing atribut yaitu `Brand` dan `Model`. Buat metode publik `TampilkanIdentitas` yang mencetak string "Perangkat Brand: {Brand}, Model: {Model}" ke layar.

Dari kelas `PerangkatElektronik`, turunkan sebuah kelas publik yaitu `Smartphone`. Kelas `Smartphone` memiliki tambahan informasi sebagai atribut `protected` yaitu: `_sistemOperasi` (tipe String, seperti "Android", "iOS", dll.) dan `_fiturDasar` (tipe string). Kelas `Smartphone` harus memiliki konstruktor yang menginisialisasi semua atribut, termasuk yang diwariskan dari kelas `PerangkatElektronik`. Sediakan properti publik yang hanya memiliki metode get untuk atribut tambahan yaitu `SistemOperasi`, dan `FiturDasar`. Buat metode `TampilkanFiturDasar` yang mencetak string berikut ke layar dengan format "Fitur Dasar: {FiturDasar}".

Dari kelas `Smartphone`, turunkan sebuah kelas publik yaitu `FlagshipPhone`. Kelas `FlagshipPhone` memiliki tambahan informasi sebagai atribut `protected` yaitu: `_fiturPremium` (tipe string). Buat konstruktor yang menginisialisasi semua atribut, termasuk yang diwariskan dari kelas `Smartphone`. Sediakan properti publik yang hanya memiliki metode get untuk atribut tambahan yaitu `FiturPremium`. Buat metode `TampilkanFiturPremium` yang mencetak string yang berisi fitur dasar yang merupakan output dari pemanggilan metode `TampilkanFiturDasar` yang diturunkan dari kelas `Samrtphone` dan fitur premium ke layar dengan format berikut: 

"Fitur Dasar: LCD, RAM, dll."

"Fitur Premium: Camera Telephoto"

Dari kelas `Smartphone`, turunkan sebuah kelas publik yaitu `BudgetPhone`. Kelas `BudgetPhone` memiliki tambahan informasi sebagai atribut `protected` yaitu: `_harga` (tipe int). Buat metode konstruktor yang menginisialisasi semua atribut, termasuk yang diwariskan dari kelas `Smartphone`. Sediakan properti publik yang hanya memiliki metode get untuk atribut tambahan yaitu `Harga`.

Buatlah sebuah kelas bernama `Program` yang didalamnya terdapat metode static `Main`. Instansiasi 1 objek dari kelas `FlagshipPhone` dan 1 objek dari kelas `BudgetPhone` menggunakan keyword new, set atributnya, dan tampilkan informasi dari kedua smartphone tersebut ke layar.

### SportsEquipment

Buat solusi dari soal ini di project `Solution` folder `SportsEquipment` dengan namespace `Solution.SportsEquipment`.

Buatlah sebuah kelas publik bernama `PeralatanOlahraga` yang digunakan oleh sebuah toko olahraga untuk merepresentasikan sebuah peralatan olahraga yang tersedia di toko tersebut. Sebuah `PeralatanOlahraga` memiliki dua informasi sebagai atribut `protected` yaitu: `_jenis` (tipe String) dan `_merek` (tipe String). Kelas `PeralatanOlahraga` harus memiliki sebuah konstruktor yang menginisialisasi kedua variabel instance tersebut. Sediakan properti publik yang hanya memiliki metode get untuk masing-masing atribut yaitu `Jenis` dan `Merek`. Buat metode publik `TampilkanInformasi` yang mencetak string "Peralatan Olahraga Jenis: {Jenis}, Merek: {Merek}" ke layar.

Dari kelas `PeralatanOlahraga`, turunkan sebuah kelas publik yaitu `Bola`. Kelas `Bola` memiliki tambahan informasi sebagai atribut `protected` yaitu: `_jenisOlahraga` (tipe String, seperti "Sepakbola", "Basket", dll.) dan `_bahan` (tipe string). Kelas `Bola` harus memiliki konstruktor yang menginisialisasi semua atribut, termasuk yang diwariskan dari kelas `PeralatanOlahraga`. Sediakan properti publik yang hanya memiliki metode get untuk atribut tambahan yaitu `JenisOlahraga`, dan `Bahan`. Buat metode `TampilkanSpesifikasi` yang mencetak string berikut ke layar dengan format "Jenis Olahraga: {JenisOlahraga}, Bahan: {Bahan}".

Dari kelas `Bola`, turunkan sebuah kelas publik yaitu `BolaProfesional`. Kelas `BolaProfesional` memiliki tambahan informasi sebagai atribut `protected` yaitu: `_standarInternasional` (tipe bool). Buat konstruktor yang menginisialisasi semua atribut, termasuk yang diwariskan dari kelas `Bola`. Sediakan properti publik yang hanya memiliki metode get untuk atribut tambahan yaitu `StandarInternasional`. Buat metode `TampilkanStandar` yang mencetak string yang berisi spesifikasi yang merupakan output dari pemanggilan metode `TampilkanSpesifikasi` yang diturunkan dari kelas `Bola` dan informasi standar internasional ke layar dengan format: 

"Jenis Olahraga: {JenisOlahraga}, Bahan: {Bahan}, Standar Internasional: {Ya/Tidak}"

Dari kelas `Bola`, turunkan sebuah kelas publik yaitu `BolaLatihan`. Kelas `BolaLatihan` memiliki tambahan informasi sebagai atribut `protected` yaitu: `_harga` (tipe int). Buat metode konstruktor yang menginisialisasi semua atribut, termasuk yang diwariskan dari kelas `Bola`. Sediakan properti publik yang hanya memiliki metode get untuk atribut tambahan yaitu `Harga`.

Buatlah sebuah kelas bernama `Program` yang didalamnya terdapat metode static `Main`. Instansiasi 1 objek dari kelas `BolaProfesional` dan 1 objek dari kelas `BolaLatihan` menggunakan keyword new, set atributnya, dan tampilkan informasi dari kedua bola tersebut ke layar.

### Extra

> Saatnya Kreatif!

Buat soal Anda sendiri dan solusinya di project `Solution` folder `Extra` dengan namespace `Solution.Extra` di file `Extra.cs`.

Buat spesifikasi soal Anda sendiri yang memuat hal-hal sebagai berikut:

- Nama kelas yang dibuat, kegunaannya, dan hirarki turunannya.
- Atribut dan properti apa saja yang harus ada di kelas.
- Metode apa saja yang dibutuhkan.
- Validasi atau aturan apa yang harus dilakukan.

Kemudian, implementasikan solusi kelas dari soal Anda di file `Extra.cs` dan eksekusi implementasinya di `Program.cs`.

=== Selesai ===


