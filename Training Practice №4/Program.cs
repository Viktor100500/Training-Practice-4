using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Practice__4
{
    class Program
    {
        static void Main(string[] args) // Точка входа в приложение 
        {
            Function();
        }

        static void Function() // Функция работы главного меню 
        {
            Console.Clear();
            Console.WriteLine("Учебная практика №4, Власов Виктор");
            Console.WriteLine("ЗАДАЧА №725(а) Задачи по программированию. Метод деления отрезка пополам");
            Console.WriteLine("x + ln(x + 0.5) - 0.5 = 0, [0,2]");
            while (1 > 0)
            {
                Console.WriteLine();
                double E;
                bool ok = false;
                do // Проверка ввода
                {
                    Console.Write("Введите число E(погрешность): ");
                    ok = Double.TryParse(Console.ReadLine(), out E);
                    if (!ok || E <= 0) { Console.WriteLine("Введите действительное положительное число!"); }
                }
                while (!ok);
                double x, y, Fx, Fy, Echeck = 3;
                x = 2;
                y = 0;
                Fx = x + Math.Log(x+0.5)-0.5;
                Fy = y + Math.Log(y+0.5)-0.5;
                // Работа метода деления пополам
                while (((Fx < 0 && Fy > 0) || (Fx > 0 && Fy < 0)) && (Echeck >= E))
                {
                    double z = (x + y) / 2;
                    double Fz = z + Math.Log(z + 0.5) - 0.5;
                    if ((Fz <= 0 && Fy > 0) || (Fz >= 0 && Fy < 0)) { x = z; }
                    if ((Fz <= 0 && Fx > 0) || (Fz >= 0 && Fx < 0)) { y = z; }
                    Fx = x + Math.Log(x + 0.5) - 0.5;
                    Fy = y + Math.Log(y + 0.5) - 0.5;
                    Echeck = Math.Abs(Math.Abs(Fx) - Math.Abs(Fy));
                }
                Console.WriteLine("Ответ: {0}", x);
            }
        }
    }
}
