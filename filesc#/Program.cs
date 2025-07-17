using System;
using System.IO;
using System.Reflection;
using DocumentFormat.OpenXml.Office2013.Excel;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace filesc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // // fayl yaratish
          //  string path = "text.txt";
      
            // File.Create(path).Close();
            //// Console.WriteLine(File.Create(path));

            // // faylga yozish
            // string matn = "Salom barchaga";
            // File.WriteAllText("text.txt", matn);


            //// fayldan o'qish
            //string malumot = File.ReadAllText("text.txt");
            //Console.Write(malumot);

            // faylga yana malumot qo'shish

            //  File.AppendAllText("text.txt", "\nboshqa yangi malumot");


            // fayl bor yo'qligini tekshirish

            //if (File.Exists("text.txt"))
            //{
            //    File.Delete("text.txt"); // faylni o'chirish

            //    Console.WriteLine("Fayl bor va o'chirildi");
            //}

            //else 
            //{
            //    Console.WriteLine("Fayl topilmadi");
            //}

            // nuscalash, shu nomli nusxa fayl bo'lsa ham ustiga yozish

            // Fayl mavjud bo‘lsa ham, ustidan yozib qo‘yadi
            //  File.Copy("text.txt", "nusxa.txt", true);


            // fayl nomi o'zgartirildi yoxud boshqa faylga nusxalanib asl fayl o'chirildi
            //  File.Move("text.txt", "arxiv.txt");

            //// misol
            //if (!File.Exists("arxiv1.txt"))
            //{
            //    File.Move("arxiv.txt", "arxiv1.txt");
            //    Console.WriteLine("Fayl nusxalandi");
            //    Console.WriteLine(File.ReadAllText("arxiv1.txt"));
            //}


            // Fayl haqida ma'lumotlar

            FileInfo fayl = new FileInfo("arxiv1.txt");

            Console.WriteLine("Fayl nomi: " + fayl.Name);
            Console.WriteLine("To‘liq yo‘l: " + fayl.FullName);
            Console.WriteLine("Hajmi: " + fayl.Length + " bayt");
            Console.WriteLine("Yaratilgan vaqti: " + fayl.CreationTime);
        

            // faylni qatorma qator o'qish


            using (StreamReader sr = new StreamReader(fayl.FullName))
            {
                string qator;
                while ((qator = sr.ReadLine()) != null) // agar qator bo'sh bo'lmasa keyingi  bo'sh qatorni qidiradi
                {
                    Console.WriteLine(qator);
                }
            }

            // yangi qator qo'shish

            //using(StreamWriter sw = new StreamWriter(fayl.FullName, true)) // true yozishga ruxsat beradi
            //{
            //    sw.WriteLine("\nYangi qator: Nima gapla...");
            //}


            File.SetAttributes("arxiv1.txt", FileAttributes.Normal);
        }
    }
}
