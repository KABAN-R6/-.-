using System;
namespace Катречко_В.В
{
    public class ticket
    {
        public int number;
        public int price = 350;
        public int row;
        
        public void print1()
        {
            Console.WriteLine($"_____________ \n|номер места:{number}| \n|цена:{price}|\n_____________");
        }
        
    }
}
