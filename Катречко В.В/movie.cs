using System;
namespace Катречко_В.В
{
    public class movie
    {
        public string name;
        public int age_limit;
        public string time;
        public int show_time;


        public void print2()
        {
            Console.WriteLine($"название фильма- {name} \n возрастное ограничение - {age_limit}" +
                $" \n начало показа {time} \n врем показа {show_time}  ");
        }
    }
}
