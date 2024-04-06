using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok5
{
    internal class DataMahasiswa_1302223139
    {
        public class Nama
        {
            public String firstName { get; set; }
            public String lastName { get; set; }
        }
        public Nama nama { get; set; }
        public String gender { get; set; }
        public String age { get; set; }
        public String address { get; set; }
        public String courses { get; set; }

        public void ReadJSON()
        {
            string filePath = "D:\\modul7_kelompok5\\modul7_kelompok5\\jurnal7_1_1302223139.json";

            string jsonText = File.ReadAllText(filePath);

            DataMahasiswa_1302223139 dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa_1302223139>(jsonText);

            Console.WriteLine($"Nama : {dataMahasiswa.nama.firstName} {dataMahasiswa.nama.lastName}");
            Console.WriteLine($"Jenis Kelamin : {dataMahasiswa.gender}");
            Console.WriteLine($"Umur : {dataMahasiswa.age}");
            Console.WriteLine($"Alamat : {dataMahasiswa.address}");
            Console.WriteLine($"Mata Kuliah : {dataMahasiswa.courses}");
        }

    }
}
