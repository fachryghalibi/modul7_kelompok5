using modul7_kelompok5;
using static modul7_kelompok5.teamMembers_1302223107;



class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa_1302223107 mhs = new DataMahasiswa_1302223107();
        mhs.ReadJSON();

        teamMembers_1302223107 teamMembers = new teamMembers_1302223107();
        teamMembers.ReadJson2();

    }
}