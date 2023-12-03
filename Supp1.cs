using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_CH
{
    class Supp1
    {
        public static void Add<T>(List<T> list, T element)
        {
            list.Add(element);
        }
        public static bool Contains<T>(List<T> list, T element)
        {
            return list.Contains(element);
        }

        //создаём 3 списка типа private в один из которых будем добавлять другие
        private List<object> list;
        private List<object> list2;
        private List<object> list3;
        Random rnd = new Random();
        //метод, который добаляет в 1й список элементы из 2 и 3 при этом проверяя их уникальность
        public void Combain()
        {
            Console.WriteLine("Added:");
            Console.Write("From List2: ");
            foreach (object elem in list2)
            {
                if (!list3.Contains(elem) && !list.Contains(elem))
                {
                    Console.Write(elem + " ");
                    list.Add(elem);
                }
            }
            Console.WriteLine();
            Console.Write("From List3: ");
            foreach (object elem in list3)
            {
                if (!list2.Contains(elem) && !list.Contains(elem))
                {
                    Console.Write(elem + " ");
                    list.Add(elem);
                }
            }
            Console.WriteLine();
            Console.Write("We got: ");
            foreach (object elem in list)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
        }
        //Конструктор, который создаёт и заполняет списки базовыми значениями
        public Supp1()
        {
            list = new List<object>();
            list2 = new List<object>();
            list3 = new List<object>();
            Console.Write("List1: ");
            for (int i = 0; i <= 5; i++)
            {
                list.Add((char)rnd.Next(33, 126));
                Console.Write($"{list.Last()} ");
            }
            Console.WriteLine();
            Console.Write("List2: ");
            for (int i = 0; i <= 5; i++)
            {
                list2.Add((char)rnd.Next(33, 126));
                Console.Write($"{list2.Last()} ");
            }
            Console.WriteLine();
            Console.Write("List3: ");
            for (int i = 0; i <= 5; i++)
            {
                list3.Add((char)rnd.Next(33, 126));
                Console.Write($"{list3.Last()} ");
            }
            Console.WriteLine();
        }
    }
}
