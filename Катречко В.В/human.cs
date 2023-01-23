using System;
using System.Collections.Generic;
using System.Text;

namespace Катречко_В.В
{
    public class human
    {
        public string name_human = "незнакомец";
    }
    public class stagg : human
    {
        public string position;
        public virtual void  print ()
        {
            name_human = Console.ReadLine();
            Console.WriteLine($"номер:{name_human} должность {position}");
        }
    }
}
