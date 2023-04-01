using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace tpmodul7_kelompok_5
{
    internal class KuliahMahasiswa_1302213116
    {
        public void readJSON()
        {

            string jsonString = File.ReadAllText(@"C:\Users\Raychan\Documents\KuliAhhh\Kuliah\Semester 4\Kontruksi Perangkat Lunak\Tugas Pendahuluan\Tugas Pendahuluan 7\Zaky-Git-TP_KPL_MOD7_KELOMPOK_5\tpmodul7_kelompok_5\tp7_2_1302213116.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int iter = 1;
            foreach(var course in jsonObject.courses)
            {
                Console.WriteLine($"MK {iter} {course.code}-{course.name}");
                iter++;
            }

        }
    } 

}
