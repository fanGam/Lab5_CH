using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab5_CH
{
    class Supp4
    {
        HashSet<int> Setter;
        public Supp4()
        {
            using (var stream = File.Open("TextFile.txt", FileMode.Open))
            {
                Setter = new HashSet<int>();
                using (var reader = new StreamReader(stream))
                {
                    int item, one = 0;
                    char lett;
                    string numbers = "0123456789";
                    bool numb = false;
                    while ((item = reader.Read()) != -1)
                    {
                        lett = (char)item;
                        //Console.WriteLine(lett);
                        if (numbers.Contains(lett))
                        {
                            one = one * 10 + (lett - '0');
                            numb = true;
                        }
                        if (!numbers.Contains(lett) && one != 0)
                        {
                            Setter.Add(one);
                            one = 0;
                        }
                    }
                    if (one != 0)
                    {
                        Setter.Add(one);
                    }
                    Console.Write("HashSat has: ");
                    foreach(int af in Setter)
                    {
                        Console.Write(af + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------------");
                }
            }
        }
    }
}
