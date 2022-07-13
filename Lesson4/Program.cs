using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HashTab;
using BuilderLibrary;

namespace Lesson4
{
    internal class Program
    {
        private static HashTable<Bilding> hash;
        private static void Main(string[] args)
        {
            hash = new HashTable<Bilding>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n\t1 >>> Создайте дом");
                Console.WriteLine("\t2 >>> Показать дома");
                Console.WriteLine("\t3 >>> Выход");
                Console.Write("\tВведите номер: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Сhoice1();
                        break;
                    case "2":
                        Console.Clear();
                        Сhoice2();
                        break;
                    default:
                        return;
                }
            }
        }
        private static void Сhoice1()
        {
            string[] data = new string[6];
            Console.Write("\tВвидите высоту: ");
            data[0] = Console.ReadLine();
            Console.Write("\tВвидите этажи: ");
            data[1] = Console.ReadLine();
            Console.Write("\tВвидите парадные дома: ");
            data[2] = Console.ReadLine();
            Console.Write("\tВвидите колисество квартитр: ");
            data[3] = Console.ReadLine();
            Console.Write("\tВвидите улицу: ");
            data[4] = Console.ReadLine();
            Console.Write("\tВвидите ключь: ");
            data[5] = Console.ReadLine();
            foreach (string str in data)
            {
                if (IsEmpty(str))
                {
                    Created();
                }
            }
            Created(data);
        }
        private static void Сhoice2()
        {
            foreach (var line in hash.Show("Bilding"))
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
        private static void Created()
        {
            hash.Add("A", Creator.CreateBuild());
        }
        private static void Created(string[] datas)
        {
            hash.Add(datas[5], Creator.CreateBuild(GetInt(datas[0]), GetInt(datas[1]), GetInt(datas[2]), GetInt(datas[3]), datas[4]));
        }
        private static int GetInt(string line)
        {
            int res;
            int.TryParse(line, out res);
            return res;
        }
        private static bool IsEmpty(string data)
        {
            return data == null;
        }
    }
}
