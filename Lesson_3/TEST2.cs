using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    internal class TEST2 : Admin
    {
        private string Password = "qwerty";
        private Bank bankTest;
        private List<Account> listAcc;

        public TEST2()
        {
            bankTest = new Bank();
        }

        public void Enter()
        {
            Console.Write("Введите пароль: ");
            if (Console.ReadLine() == Password)
            {
                bankTest.AddNewAcc(TypeUser.Admin);
                bankTest.AddNewAcc();
                RUN();
            }
        }
        private void RUN()
        {
            bankTest.Enter(1, Password);
            listAcc = bankTest.Testadmin(NTestN);

            var tests = new bool[] { Test1(), Test2(), Test3(), Test4(), Test5() };
            for (int i = 0; i < tests.Length; i++)
            {
                var res = tests[i];
                PrintResult(res);
            }
        }
        private void PrintResult(bool resulr)
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
        private bool Test1()
        {
            return listAcc[0].ID == 1 && listAcc[0].Balance == 0;
        }
        private bool Test2()
        {
            listAcc[0].PutMoney(1000);
            if (listAcc[0].Balance == 1000)
            {
                listAcc[0].GetMoney(500);
                if (listAcc[0].Balance == 500)
                {
                    return true;
                }
            }
            return false;
        }
        private bool Test3()
        {
            List<Account> AT = new List<Account>();
            AT.Add(new Account("test", "test", "test"));
            AT.Add(new Account(12345, "test", "test", "test"));
            AT.Add(new Account(TypeUser.ProUser, "test", "test", "test"));
            AT.Add(new Account(12345, TypeUser.ProUser, "test", "test", "test"));
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        if (!(AT[0].FirstName == "test" && AT[0].SecondName == "test" && AT[0].provPass("test")))
                        {
                            return false;
                        }
                        break;
                    case 1:
                        if (!(AT[1].Balance == 12345 && AT[1].FirstName == "test" && AT[1].SecondName == "test" && AT[1].provPass("test")))
                        {
                            return false;
                        }
                        break;
                    case 2:
                        if (!(AT[2].Type == TypeUser.ProUser && AT[2].FirstName == "test" && AT[2].SecondName == "test" && AT[2].provPass("test")))
                        {
                            return false;
                        }
                        break;
                    case 3:
                        if (!(AT[3].Balance == 12345 && AT[3].Type == TypeUser.ProUser && AT[3].FirstName == "test" && AT[3].SecondName == "test" && AT[3].provPass("test")))
                        {
                            return false;
                        }
                        break;
                }
            }
            return true;
        }
        private bool Test4()
        {
            return listAcc[0].Type == TypeUser.Admin && listAcc[1].ID == 2 && listAcc[1].Type == TypeUser.User;
        }
        private bool Test5()
        {
            bankTest.PutMoney();
            bankTest.GetMoney();
            bankTest.Perevod(2);
            bankTest.Perevod(1);
            Console.Write("Все ОК?: ");
            return Console.ReadLine() == "y";
        }
    }
}
