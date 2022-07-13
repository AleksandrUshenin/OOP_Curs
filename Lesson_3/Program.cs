using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunTest();
            Run3();

            Console.ReadKey();
        }
        static void RunTest()
        {
            TEST2 test = new TEST2();
            test.Enter();
        }
        static void Run3()
        {
            FIOandEMAI fio = new FIOandEMAI();
            FileInfo fi2 = new FileInfo(@"C:\Users\sasha\source\repos\OOP_Curs\Lesson_3\Name_Email.txt");

            fio.CreateFileEmail(fio.Loader(fi2));

            SerialesUsers su = new SerialesUsers();
            var data = fio.Desereales(fio.Loader(fi2));
            foreach (var d in data)
            {
                su.AddInfo(d);
            }
            su.Save();
            su.Load();
            foreach (var g in su.Datas)
            {
                Console.WriteLine(g.Name + " +-+ " + g.Email);
            }
        }
    }
}
