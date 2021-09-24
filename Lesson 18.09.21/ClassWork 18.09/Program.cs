using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_18._09
{
    class Program
    {
        public static int speed_convert(double speed_km)
        {
            int speed_sm = (int)(speed_km*250/9);
            return speed_sm;
        }

        public static byte age_counter(byte father_age, byte son_age)
        {
            byte result = (byte)Math.Abs(father_age - 2 * son_age);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1\nsbyte - {0} - {1}\nbyte - {2} - {3}\nshort - {4} - {5}\nushort - {6} - {7}\nint - {8} - {9}\nuint - {10} - {11}\nlong - {12} - {13}\nulong - {14} - {15}", sbyte.MaxValue, sbyte.MinValue, byte.MaxValue, byte.MinValue, short.MaxValue, short.MinValue, ushort.MaxValue, ushort.MinValue, int.MaxValue, int.MinValue, uint.MaxValue, uint.MinValue, long.MaxValue, long.MinValue, ulong.MaxValue, ulong.MinValue);

            Console.WriteLine("\nTask 2\nВведите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите город");
            string city = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            byte age = byte.Parse(Console.ReadLine()); 
            Console.WriteLine("Введите пин-код");
            ushort pin = ushort.Parse(Console.ReadLine()); 
            Console.WriteLine("Имя пользователя: {0}\nВозраст: {1}\nГород: {2}\nПин-код: {3}", name, age, city, pin);

            Console.WriteLine("\nTask 3\nВведите текст");
            string input = Console.ReadLine();
            string[] output = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]) == true)
                {
                    output[i] = input[i].ToString().ToUpper();
                }
                else
                {
                    output[i] = input[i].ToString().ToLower();
                }
            }
            Console.WriteLine(string.Join("", output));

            Console.WriteLine("\nTask 4\nВведите строку");
            string line = Console.ReadLine(); 
            Console.WriteLine("Введите подстроку");
            string subline = Console.ReadLine(); 
            uint count = 0;
            for (int i = 0; i < line.Length-subline.Length+1; i++)
            {
                if(line.Substring(i, subline.Length) == subline)
                {
                    count++;
                }
            }
            Console.WriteLine("{0} раз подстрока встречается в строке", count);

            Console.WriteLine("\nTask 5\nВведите скорость в км/ч");
            double speed = double.Parse(Console.ReadLine());
            Console.WriteLine("Скорость в см/c равна {0}", speed_convert(speed));

            Console.WriteLine("\nTask 6\nВведите возраст отца");
            byte father_age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите возраст сына");
            byte son_age = byte.Parse(Console.ReadLine());
            if (father_age > 2 * son_age)
            {
                Console.WriteLine("Через {0} год(а)/лет отец будет старше сына в два раза", age_counter(father_age, son_age));
            }
            else
            {
                Console.WriteLine("{0} год(a)/лет назад отец был старше сына в два раза", age_counter(father_age, son_age));
            }

            Console.WriteLine("\nTask 7\nВведите стандартную цену бутылки виски");
            uint normPrice = uint.Parse(Console.ReadLine());
            Console.WriteLine("Введите скидку в дьюти фри");
            byte salePrice = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость отпуска");
            uint holidayPrice = uint.Parse(Console.ReadLine());
            double oneBottleProfit = (normPrice * ((double)salePrice / 100));
            if(oneBottleProfit == 0)
            {
                oneBottleProfit++;
            }
            uint bottleCount = (uint)(holidayPrice / oneBottleProfit);
            Console.WriteLine("{0} бутылок вам нужно будет купить", bottleCount);

            Console.ReadKey();
        }
    }
}
