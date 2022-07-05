using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    internal class TEST1
    {
        List<Account> accounts;
        public TEST1()
        {
            accounts = new List<Account>();
            accounts.Add(new Account());
            accounts.Add(new Account(12345));
            accounts.Add(new Account(TypeUser.Admin));
            accounts.Add(new Account(800, TypeUser.ProUser));
        }
        public void RUN()
        {
            var tests = new object[] { Test1(), Test2(), Test3(), Test4(), Test5() };
            for (int i = 0; i < tests.Length; i++)
            {
                var res = tests[i];
                PrintResult((bool)res);
            }
        }
        void PrintResult(bool resulr)
        {
            if (resulr)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test Complit!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test Failed!");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        bool Test1()
        {
            if (accounts[0].ID == 1 && accounts[0].Balance == 0)
            {
                return true;
            }
            return false;
        }
        bool Test2()
        {
            accounts[0].PutMoney(1000);
            if (accounts[0].Balance == 1000)
            {
                accounts[0].TakeMoney(500);
                if (accounts[0].Balance == 500)
                {
                    return true;
                }
            }
            return false;
        }
        bool Test3()
        {
            if (accounts[1].ID == 2 && accounts[1].Balance == 12345)
            {
                return true;
            }
            return false;
        }
        bool Test4()
        {
            if (accounts[2].ID == 3 && accounts[2].Type == TypeUser.Admin)
            {
                return true;
            }
            return false;
        }
        bool Test5()
        {
            return accounts[3].Balance == 800 && accounts[3].Type == TypeUser.ProUser && accounts[3].ID == 4;
        }
    }
}
