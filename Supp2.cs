using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_CH
{
    class Supp2
    {
        private LinkedList<int> list;
        private Random rnd = new Random();
        public void ClearSmth()
        {
            LinkedList<int> list1 = new LinkedList<int>();
            int gotter = 0;
            Console.Write("Found: ");
            foreach (int item in list)
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
            foreach (int item in list1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
        }

        public Supp2()
        {
            list = new LinkedList<int>();
            Console.Write("Linked list: ");
            for (int i = 0; i < 30; i++)
            {
                list.AddLast(rnd.Next(0, 100));
                Console.Write($"{list.Last()} ");
            }
            Console.WriteLine();
        }
    }
}
