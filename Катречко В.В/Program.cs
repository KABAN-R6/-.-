using System;

namespace Катречко_В.В
{
    class Program
    {
        static void Main(string[] args)
        {
            movie m1 = new movie();
            m1.name = "afa";
            m1.age_limit = 18;
            m1.time = "16:19";
            m1.show_time = 120;
            m1.print2();
            stagg h1 = new stagg();
            Console.WriteLine($"в ведите имя ");
            h1.print();
            ticket t1 = new ticket();
            Console.WriteLine($"в ведите место ");
            t1.number = Convert.ToInt32(Console.ReadLine());
            t1.print1();



        }
    }
}
