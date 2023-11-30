namespace Lab5_CH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Supp1 test1 = new Supp1();
            test1.Combain();
            Supp2 test2 = new Supp2();
            test2.ClearSmth();
            Supp3 test3 = new Supp3();
            test3.ShowRandomData(rnd.Next(1,100));
            Supp4 test4 = new Supp4();
        }
    }
}
