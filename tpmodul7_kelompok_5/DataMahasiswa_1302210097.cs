using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace tpmodul7_kelompok_5
{
	internal class DataMahasiswa_1302210097
	{
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"E:\Tugas Kuliah\Semester 4\KPL\Praktikum\tpmodul7_1302210097\Zaky-Git-TP_KPL_MOD7_KELOMPOK_5\tpmodul7_kelompok_5\tp7_1_1302210097.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine($"Nama {jsonObject.nama.depan} {jsonObject.nama.belakang} dengan nim {jsonObject.nim} dari fakultas {jsonObject.fakultas}");
        }
    }
}
