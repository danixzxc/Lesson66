using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson66
{
    class Menu
    {
        public void Start()
        {
            Create create = new Create();
            Functions function = new Functions();

            Console.WriteLine("Таблица функции MyFunc:");
            create.Table(function.MyFunc, 0, 0, 4);

            Console.WriteLine("Таблица функции Sin:");
            create.Table(function.Sin, 0, 0, 4);
        }
    }
}