using System;

namespace TimeAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите точное время.");
            // время точное, т.е. минутная стрелка всегда на 12
            var s = Console.ReadLine();
            int H = int.Parse(s);
            int oneHangle = 360 / 12;
            int res = Math.Abs((H / 6 * 12 - H) * oneHangle);
            Console.WriteLine(res);
        }
    }
}
