using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18._09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task A1.1\nВведите число n секунд");
            uint time = uint.Parse(Console.ReadLine());
            ushort hours = (ushort)(time / 3600);
            byte minutes = (byte)((time - hours * 3600) / 60);
            byte seconds = (byte)(time - hours * 3600 - minutes * 60);
            Console.WriteLine("C начала суток прошло {0} полных часов, {1} минут, {2} cекунд", hours, minutes, seconds);

            Console.WriteLine("\nTask A1.2\n{0} квадратa", (int)(543 / 130));

            Console.WriteLine("\nTask A1.3\nВведите число n - кол-во месяцев");
            ushort countMonth = ushort.Parse(Console.ReadLine());
            Console.WriteLine("x = {0}", countMonth % 12 + 1);

            Console.WriteLine("\nTask A1.4\nВведите двузначное число");
            ushort number = ushort.Parse(Console.ReadLine());
            if(number > 99)
            {
                number = 99;
            }
            Console.WriteLine("{0} десятков, {1} единиц, {2} - сумма его цифр, {3} - произведение его цифр", number / 10, number % 10, number / 10 + number % 10, (number /10)*(number % 10));

            Console.WriteLine("\nTask A1.5\nВведите трехзначное число");
            number = ushort.Parse(Console.ReadLine());
            if(number < 100)
            {
                number = 100;
            }
            else if(number > 999)
            {
                number = 999;
            }
            Console.WriteLine("Новое число {0}{1}", number % 100, number / 100);

            Console.WriteLine("\nTask A1.6");
            number = 237;
            Console.WriteLine("Число х равно {0}", (number % 100) *  10 + (number / 100));

            Console.WriteLine("\nTask A1.7\nНужно ввести цифры чисел а2а1 и b2b1\nВведите а2");
            byte a2 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите а1");
            byte a1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите b2");
            byte b2 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите b1");
            byte b1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Цифры числа равного сумме а2а1+b2b1: {0} и {1}", a2 + b2 + (a1 + b1) / 10, (a1 + b1) % 10);

            Console.WriteLine("\nTask A1.8\nВведите число k, кратное трём");
            byte k = byte.Parse(Console.ReadLine());
            Console.WriteLine("k-ая цифра последовательности - {0}\nВведите число k, которое 1, 4, 7, ...", (k / 3) % 10); 
            k = byte.Parse(Console.ReadLine());
            Console.WriteLine("k-ая цифра последовательности - {0}\nВведите число k, которое 2, 5, 8, ...", k % 3); 
            k = byte.Parse(Console.ReadLine());
            Console.WriteLine("k-ая цифра последовательности - {0}", k / 28);

            Console.WriteLine("\nTask A1.9");
            bool a = true;
            bool b = false;
            bool c = false;
            Console.WriteLine("a) {0}\nб) {1}\nв) {2}", a ^ b, a & b, b ^ c);

            Console.WriteLine("\nTask A1.10 (a)\nx y z F");
            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    for (int z = 0; z < 2; z++)
                    {
                        bool f = !(Convert.ToBoolean(x) ^ Convert.ToBoolean(y)) & (!Convert.ToBoolean(x) ^ !Convert.ToBoolean(z));
                        Console.WriteLine("{0} {1} {2} {3}", x, y, z, Convert.ToByte(f));
                    }
                }
            }
            Console.WriteLine("\nTask A1.10 (б)\nx y z F");
            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    for (int z = 0; z < 2; z++)
                    {
                        bool f = !(!Convert.ToBoolean(x) & Convert.ToBoolean(y)) ^ (Convert.ToBoolean(x) & !Convert.ToBoolean(z));
                        Console.WriteLine("{0} {1} {2} {3}", x, y, z, Convert.ToByte(f));
                    }
                }
            }
            Console.WriteLine("\nTask A1.10 (в)\nx y z F");
            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    for (int z = 0; z < 2; z++)
                    {
                        bool f = Convert.ToBoolean(x) ^ !Convert.ToBoolean(y) & !(Convert.ToBoolean(x) ^ !Convert.ToBoolean(z));
                        Console.WriteLine("{0} {1} {2} {3}", x, y, z, Convert.ToByte(f));
                    }
                }
            }
            Console.ReadKey(); 
        }
    }
}
