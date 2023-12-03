using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_CH
{
    class Supp2
    {
        public static object Max<T>(LinkedList<T> list)
        {
            return list.Max();
        }
        public static void AddLast<T>(LinkedList<T> list, T elem)
        {
            list.AddLast(elem);
        }
        public static object Last<T>(LinkedList<T> list)
        {
            return list.Last();
        }
        private LinkedList<object> list;
        private Random rnd = new Random();
        //метод, который проходит по списку и находит максимальный и минимальный элемент и удаляет всё что между ними
        public void ClearSmth()
        {
            LinkedList<object> list1 = new LinkedList<object>();
            int gotter = 0;
            Console.Write("Found: ");
            foreach (object item in list)
            {
                if ((item == list.Max()) || (item == list.Min()))
                {
                    if (gotter == 0)
                    {
                        gotter = 1;
                        list1.AddLast(item);
                    }
                    else if (item != list1.Last())
                    {
                        gotter = 2;
                        list1.AddLast(item);
                    }
                }
                if (gotter != 1)
                {
                    list1.AddLast(item);
                }
                else
                {
                    Console.Write($"{item} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Left: ");
            foreach (object item in list1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
        }
        //конструктор, который создаёт 1й список и заполняет его рандомом
        public Supp2()
        {
            list = new LinkedList<object>();
            Console.Write("Linked list: ");
            for (int i = 0; i < 30; i++)
            {
                list.AddLast((char)rnd.Next(31, 126));
                Console.Write($"{list.Last()} ");
            }
            Console.WriteLine();
        }
    }
}
