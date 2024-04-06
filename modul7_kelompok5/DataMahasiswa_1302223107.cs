using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok5
{
    internal class DataMahasiswa_1302223107
    {
        public class Nama
        {
            public String firstName { get; set; }
            public String lastName { get; set; }
        }
        public Nama nama { get; set; }
        public String address { get; set; }
        public String courses { get; set; }

        public void ReadJSON()
        {
            string filePath = "D:\\FACHRY\\Kuliah\\Praktikum KPL\\modul7_kelompok5\\modul7_kelompok5\\jurnal7_1_1302223107.json";

            string jsonText = File.ReadAllText(filePath);

            DataMahasiswa_1302223107 dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa_1302223107>(jsonText);

            Console.WriteLine($"Nama {dataMahasiswa.nama.firstName} {dataMahasiswa.nama.lastName} dengan Alamat {dataMahasiswa.address} dan courses {dataMahasiswa.courses}");
        }

    }
}

