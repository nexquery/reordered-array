using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Reorder_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Args kontrol et
            if(args.Length == 0)
            {
                Console.WriteLine("Convert edilecek metin dosyasını sürükleyin.");
                Console.ReadLine();
                return;
            }

            string dosyaAdi = Path.GetFileNameWithoutExtension(args[0]);
            string yeniDosyaAdi = dosyaAdi + "_reordered" + Path.GetExtension(args[0]);
            string yeniDosyaYolu = Path.Combine(Path.GetDirectoryName(args[0]), yeniDosyaAdi);

            // İndex başlangıcını belirle
            int baslangic_indexi;
            Console.Write("Başlangıç indexini belirleyin: ");
            baslangic_indexi = int.Parse(Console.ReadLine());

            // Dosyayı oku
            using (StreamReader sr = new StreamReader(args[0]))
            using (StreamWriter writer = new StreamWriter(yeniDosyaYolu))
            {
                string satir;
                int gecerli_index = -1, index = baslangic_indexi - 1;
                while ((satir = sr.ReadLine()) != null)
                {
                    string pattern = @"\[(\d+)\]";
                    Match match = Regex.Match(satir, pattern);

                    if (match.Success)
                    {
                        string extractedValue = match.Groups[1].Value;
                        
                        if(gecerli_index != int.Parse(extractedValue))
                        {
                            gecerli_index = int.Parse(extractedValue);
                            index++;
                        }

                        satir = satir.Replace($"[{extractedValue}]", $"[{index}]");

                        writer.WriteLine( satir );
                    }
                    else
                    {
                        writer.WriteLine("");
                    }
                }
            }
        }
    }
}
