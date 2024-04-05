using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium.NET_cwiczenie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string lokalizacja = "C:\\aaMag\\test.txt";

                if (File.Exists(lokalizacja))
                {
                using (FileStream fs = new FileStream(lokalizacja, FileMode.Open))
                    {
                        using (StreamReader reader = new StreamReader(fs))
                        {
                            Console.WriteLine("Zawartość pliku:");
                            Console.WriteLine("*****");
                            Console.WriteLine(reader.ReadToEnd());
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Podany plik nie istnieje.");
                }

            Console.ReadKey();
        }
    }
}
