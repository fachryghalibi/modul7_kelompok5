using System;
using System.IO;
using System.Text.Json;

namespace modul7_kelompok5
{
    internal class Datamahasiswa_1302223095
    {
      

        // Inisialisasi properti nama saat objek dibuat

        public String firstName { get; set; }
        public String lastName { get; set; }

        public string gender { get; set; }
        public int age { get; set; }
        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }
        public Address address { get; set; }
        public class Courses
        {
            public string code { get; set; }
            public string name { get; set; }
        }
        public Courses[] courses { get; set; }

        public void ReadJSON()
        {
            string filePath = "C:\\Users\\fadla\\codingan\\SEM 4\\KPL\\modul7_kelompok5\\modul7_kelompok5\\jurnal7_1_1302223095.json";

            // Membaca isi file JSON
            string jsonText = File.ReadAllText(filePath);

            // Mengurai string JSON menjadi objek
            Datamahasiswa_1302223095 dataMahasiswa = JsonSerializer.Deserialize<Datamahasiswa_1302223095>(jsonText);

            // Menampilkan informasi mahasiswa
            Console.WriteLine("Informasi Mahasiswa:");
            Console.WriteLine($"Nama: {dataMahasiswa.firstName} {dataMahasiswa.lastName}");
            Console.WriteLine($"Gender: {dataMahasiswa.gender}");
            Console.WriteLine($"Age: {dataMahasiswa.age}");
            Console.WriteLine($"Address: {dataMahasiswa.address.streetAddress}, {dataMahasiswa.address.city}, {dataMahasiswa.address.state}");

            // Menampilkan informasi kursus yang diambil
            Console.WriteLine("Kursus yang Diambil:");
            foreach (var course in dataMahasiswa.courses)
            {
                Console.WriteLine($"Code: {course.code}, Name: {course.name}");
            }
        }
    }
}
