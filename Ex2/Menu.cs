using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Menu
    {
        public void Start()
        {
            Console.WriteLine("функция 1 - f(x) = x * x - 50 * x + 10");
            Console.WriteLine("функция 2 - f(x) = x * x - 30 * x + 20");
            Console.WriteLine("функция 3 - f(x) = x * x - 15 * x + 94");
            delegates deleg = new delegates();
            Function function = new Function();
            while (true)
            {
                Console.WriteLine("Для первой функции нажмите S");
                Console.WriteLine("Для второй функции нажмите R");
                Console.WriteLine("Для третьей функции нажмите P");
                Console.WriteLine("Для выхода нажмите esc\n\n");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.S:
                        function.SaveFunc("data.bin", -100, 100, 0.5, deleg.F1);
                        break;
                    case ConsoleKey.R:
                        function.SaveFunc("data.bin", -100, 100, 0.5, deleg.F2);
                        break;
                    case ConsoleKey.P:
                        function.SaveFunc("data.bin", -100, 100, 0.5, deleg.F3);
                        break;
                    case ConsoleKey.Escape: return;
                }
                Console.WriteLine(function.Load("data.bin"));
            }
        }
    }
}
