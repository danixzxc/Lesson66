using System;

namespace Lesson66
{
    internal class Create
    {
        public void Table(Fun F, double a, double x, double b)
        {
            double i = x;
            Console.WriteLine("--- A ----- X ----- Y ---");
            while (a <= b)
            {
                x = i;
                while (x <= b)
                {
                    var f = Math.Round(F(a, x), 2);
                    Console.WriteLine($"| {a,5} | {x,5} | {f,5} |", a, x, f);
                    x++;
                }
                Console.WriteLine("-------------------------");
                a++;
            }
        }
    }
}