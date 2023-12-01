using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_CH
{
    class Supp5
    {
        Dictionary<string, string> table, newtable;
        //конструктор, который читает из файла информацию, разделяет её и находит подходящую
        public Supp5()
        {
            table = new Dictionary<string, string>();
            using (var stream = File.Open("TextFile.txt", FileMode.Open))
            {
                using (var reader = new StreamReader(stream))
                {
                    int item;
                    string words, family, name, date;
                    while ((words = reader.ReadLine()) != null)
                    {
                        item = 0;
                        name = "";
                        family = "";
                        date = "";
                        while (words[item] != ' ')
                        {
                            name += words[item];
                        }
                        while (words[item] != ' ')
                        {
                            family += words[item];
                        }
                        while (words[item] != ' ')
                        {
                            date += words[item];
                        }
                        table.Add(name + ' ' + family, date);
                    }
                    newtable = new Dictionary<string, string>();
                    Console.WriteLine("Write date DD.MM.YY");
                    date = Console.ReadLine();
                    foreach (string items in table.Keys)
                    {
                        if (table[items] == date)
                        {
                            newtable.Add(items, date);
                        }
                    }
                    if (newtable.Count()  > 1)
                    {
                        foreach (string items in newtable.Keys)
                        {
                            Console.WriteLine(items);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"There are {newtable.Count()} with that date");
                    }
                }
            }
        }
    }
}
