using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workFromManual
{
    public enum bankAccountType
    {
        currentAccount,
        saveAccount,
    }
    public struct bankInfo
    {
        public int id;
        public bankAccountType type;
        public double balance;
    }
    public enum ВУЗ
    {
        КГУ,
        КАИ,
        КХТИ
    }
    public struct работник
    {
        public string name;
        public ВУЗ univer;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3.1");
            bankAccountType accountType = bankAccountType.currentAccount;
            Console.WriteLine(accountType);

            Console.WriteLine("\nTask 3.2");
            bankInfo account;
            Console.WriteLine("Введите номер аккаунта");
            account.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите:\n1 - для открытия текущего счета\n2 - для открытия сберегательного счета");
            account.type = (bankAccountType)byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите баланс");
            account.balance = double.Parse(Console.ReadLine());
            Console.WriteLine("Номер счета {0}, его тип {1}, баланс = {2}", account.id, account.type, account.balance);

            Console.WriteLine("\nHomeTask 3.1\nВведите имя работника");
            работник worker;
            worker.name = Console.ReadLine();
            Console.WriteLine("Выберите ВУЗ:\n0 - КГУ\n1 - КАИ\n2 - КХТИ");
            worker.univer = (ВУЗ)byte.Parse(Console.ReadLine());
            Console.WriteLine("Работник {0}, ВУЗ {1}", worker.name, worker.univer);
            Console.ReadKey();
        }
    }
}
