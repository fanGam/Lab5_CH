using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_CH
{
    class Supp1
    {
        //создаём 3 списка типа private в один из которых будем добавлять другие
        private List<int> list;
        private List<int> list2;
        private List<int> list3;
        Random rnd = new Random();
        //метод, который добаляет в 1й список элементы из 2 и 3 при этом проверяя их уникальность
        public void Combain()
        {
            Console.WriteLine("Added:");
            Console.Write("From List2: ");
            foreach (int elem in list2)
            {
                if (!list3.Contains(elem) && !list.Contains(elem))
                {
                    Console.Write(elem + " ");
                    list.Add(elem);
                }
            }
            Console.WriteLine();
            Console.Write("From List3: ");
            foreach (int elem in list3)
            {
                if (!list2.Contains(elem) && !list.Contains(elem))
                {
                    Console.Write(elem + " ");
                    list.Add(elem);
                }
            }
            Console.WriteLine();
            Console.Write("We got: ");
            foreach (int elem in list)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
        }
        //Конструктор, который создаёт и заполняет списки базовыми значениями
        public Supp1()
        {
            list = new List<int>();
            list2 = new List<int>();
            list3 = new List<int>();
            Console.Write("List1: ");
            for (int i = 0; i <= 5; i++)
            {
                list.Add(rnd.Next(0, 10));
                Console.Write($"{list.Last()} ");
            }
            Console.WriteLine();
            Console.Write("List2: ");
            for (int i = 0; i <= 5; i++)
            {
                list2.Add(rnd.Next(0, 10));
                Console.Write($"{list2.Last()} ");
            }
            Console.WriteLine();
            Console.Write("List3: ");
            for (int i = 0; i <= 5; i++)
            {
                list3.Add(rnd.Next(0, 10));
                Console.Write($"{list3.Last()} ");
            }
            Console.WriteLine();
        }
    }
}
