using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglonPatternConsoleApp
{
    public class DosyaIsleyici
    {
        private static DosyaIsleyici ornek;
        private static readonly object kilitlemeNesnesi = new object();

        private DosyaIsleyici()
        {
            // Dışarıdan doğrudan erişim engellenir.
        }

        public static DosyaIsleyici Ornek
        {
            get
            {
                // İlk erişimde örnek oluşturulur, sonraki erişimlerde oluşturulan örnek döndürülür.
                if (ornek == null)
                {
                    lock (kilitlemeNesnesi)
                    {
                        if (ornek == null)
                        {
                            ornek = new DosyaIsleyici();
                        }
                    }
                }
                return ornek;
            }
        }

        // Diğer sınıf işlevleri burada tanımlanabilir.
        // Örneğin:
        public void DosyaOku(string dosyaYolu)
        {
            // Dosya okuma işlemleri burada gerçekleştirilir.
            Console.WriteLine("Dosya okunuyor: " + dosyaYolu);
        }

        public void DosyaYaz(string dosyaYolu, string icerik)
        {
            // Dosya yazma işlemleri burada gerçekleştirilir.
            Console.WriteLine("Dosyaya yazılıyor: " + dosyaYolu);
            Console.WriteLine("İçerik: " + icerik);
        }
    }
}
