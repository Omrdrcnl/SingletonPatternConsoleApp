using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglonPatternConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Tekil örneğe erişim:
            DosyaIsleyici dosyaIsleyici = DosyaIsleyici.Ornek;

            // Dosya işlemlerini kullanma:
            dosyaIsleyici.DosyaOku("ornek.txt");
            dosyaIsleyici.DosyaYaz("ornek.txt", "Merhaba, Singleton!");

            Console.ReadLine();
        }
    }
}
