using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    internal class Display
    {
        public static string VvodPass()
        {
            PrintMessage("Введите пароль: ");
            return Console.ReadLine();
        }
        public static void PrintSost(int sost, int id, decimal summ, decimal Balance)
        {
            switch (sost)
            {
                case 1:
                    PrintMessage("ID: " + id);
                    PrintMessage("Списано: " + summ + "$");
                    PrintMessage("Текущий бaланс: " + Balance + "$");
                    break;
                case 2:
                    PrintMessage("ID: " + id);
                    PrintMessage("Поступило: " + summ + "$");
                    PrintMessage("Текущий бaланс: " + Balance + "$");
                    break;
            }
            Console.WriteLine();
        }
        public static void PrintMessage(string mess)
        {
            Console.WriteLine(mess);
        }
        public static decimal VvodSumm()
        {
            decimal Summ;
            PrintMessage("Введите сумму: ");
            decimal.TryParse(Console.ReadLine(), out Summ);
            return Summ;
        }
        public static string SetName1()
        {
            PrintMessage("Введите имя: ");
            return Console.ReadLine();
        }
        public static string SetName2()
        {
            PrintMessage("Введите фамилию: ");
            return Console.ReadLine();
        }
    }
}
