using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DosyaIslemOrnek7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizilerin Dosyaya Yazılması / Okunması

            String[] veriler = { "Ahmet", "Hasan", "Ayşe", "Deniz", "Merve" };
            File.WriteAllLines("kayitlar.txt", veriler); //Dizinin elemanlarını dosyaya yaz

            String[] d;
            d = File.ReadAllLines("kayitlar.txt");//dosyadaki satırları oku d dizisine aktar
            for (int i = 0; i < d.Length; i++)
            {
                Console.WriteLine(d[i]);
            }
        }
    }
}
