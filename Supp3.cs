using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_CH
{
    class Supp3
    {
        private HashSet<string> TVShows;
        //метод, который проходит и выводит количество зрителей для каждого шоу (генерируется рандомно)
        public void ShowRandomData(int n)
        {
            Random rnd = new Random();
            foreach(string item in TVShows)
            {
                Console.WriteLine($"{item} has {rnd.Next(0, n)} viewers");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
        }
        //конструктор, который заполняет hashset названиями тв шоу
        public Supp3()
        {
            TVShows = new HashSet<string>();
            TVShows.Add("Орел и решка");
            TVShows.Add("Лучше всех!");
            TVShows.Add("Голос. Дети");
            TVShows.Add("Голос");
            TVShows.Add("Импровизация");
            TVShows.Add("Танцы");
            TVShows.Add("Мир наизнанку");
            TVShows.Add("Ревизорро");
        }
    }
}
