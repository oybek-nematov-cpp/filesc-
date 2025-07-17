# Fayllar bilan ishlash (C#)

Ushbu loyiha C# dasturlash tilida fayllar bilan ishlashning asosiy usullarini o‘z ichiga oladi. Quyida quyidagi operatsiyalar ko‘rsatilgan:
- Fayl yaratish
- Faylga yozish
- Fayldan o‘qish
- Faylga ma’lumot qo‘shish
- Faylni nusxalash
- Faylni ko‘chirish
- Fayl atributlarini o‘zgartirish
- StreamReader va FileStream bilan ishlash

## Asosiy kod

```csharp
using System;
using System.IO;

namespace FaylBilanIshlash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "text.txt";
            string nusxa = "nusxa.txt";
            string yangi = "yangi_joyga.txt";
            string matn = "Salom barchaga";

            // 1. Fayl yaratish
            File.Create(path).Close();

            // 2. Faylga yozish
            File.WriteAllText(path, matn);

            // 3. Fayldan o‘qish
            string oqilgan = File.ReadAllText(path);
            Console.WriteLine("Fayldan o‘qildi: " + oqilgan);

            // 4. Faylga qo‘shimcha yozish
            File.AppendAllText(path, "\nYangi qo‘shimcha matn");

            // 5. Fayl mavjudligini tekshirish
            if (File.Exists(path))
            {
                Console.WriteLine("Fayl mavjud.");
            }

            // 6. Fayl nusxalash (ustidan yozish uchun true)
            File.Copy(path, nusxa, true);

            // 7. Faylni boshqa nom bilan ko‘chirish
            File.Move(nusxa, yangi);

            // 8. Faylga faqat o‘qish huquqi berish
            File.SetAttributes(path, FileAttributes.ReadOnly);

            // 9. StreamReader yordamida o‘qish
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine("StreamReader bilan: " + line);
                }
            }

            // 10. FileStream yordamida bayt bilan ishlash
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                string text = System.Text.Encoding.UTF8.GetString(buffer);
                Console.WriteLine("FileStream bilan: " + text);
            }
        }
    }
}
```
# filesc# faylida tajuniy rasm bor 
uni readmega qo'yolmadim
