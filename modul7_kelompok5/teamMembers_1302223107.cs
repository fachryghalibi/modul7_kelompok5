using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok5
{
    internal class teamMembers_1302223107
    {
        internal void ReadJson2()
        {
            throw new NotImplementedException();
        }

        internal class membersAing
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public string age { get; set; }
            public string nim { get; set; }
        }

        internal class Member_1302223107
        {
            public List<membersAing> Members { get; set; }

            public void ReadJson2()
            {
                string filePath = "D:\\FACHRY\\Kuliah\\Praktikum KPL\\modul7_kelompok5\\modul7_kelompok5\\jurnal7_2_1302223107.json";
                string jsonContent = File.ReadAllText(filePath);
                var memberku = JsonSerializer.Deserialize<Member_1302223107>(jsonContent);


                Console.WriteLine("Daftar mata kuliah yang diambil:");
                foreach (var Member in memberku.Members)
                {
                    Console.WriteLine($" {Member.firstName} - {Member.lastName} {Member.gender} {Member.age} {Member.nim}");
                }
            }
        }
    }
}
