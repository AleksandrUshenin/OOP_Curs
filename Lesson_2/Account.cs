using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    /// <summary>
    /// типы аккаунтов юзера
    /// </summary>
    [Flags]
    enum TypeUser
    {
        User = 0b_0001,
        ProUser = 0b_0010,
        Admin = 0b_1111
    }
    /// <summary>
    /// класс аккаунт
    /// </summary>
    internal class Account
    {
        /// <summary>
        /// вкл/выкл уведомление 
        /// </summary>
        public bool Messege { get; set; }
        /// <summary>
        /// статическая переменная для генерации id
        /// </summary>
        private static int SID;
        public int ID { get; private set; }
        public decimal Balance { get; private set; }
        public TypeUser Type { get; private set; }

        /// <summary>
        /// конструктор без параметра 
        /// </summary>
        public Account()
        {
            ID = GenId();
            Type = TypeUser.User;
            Messege = true;
        }
        /// <summary>
        /// конструктор с балансом аккаунта
        /// </summary>
        /// <param name="bal"></param>
        public Account(decimal bal)
        {
            ID = GenId();
            Balance = bal;
            Messege = true;
        }
        /// <summary>
        /// конструктор с типом аккаунта
        /// </summary>
        /// <param name="type">тип аккаунта</param>
        public Account(TypeUser type)
        {
            ID = GenId();
            Type = type;
            Messege = true;
        }
        /// <summary>
        /// полный конструктор
        /// </summary>
        /// <param name="bal">баланс</param>
        /// <param name="type">тип аккаунта</param>
        public Account(decimal bal, TypeUser type)
        {
            ID = GenId();
            Balance = bal;
            Type = type;
            Messege = true;
        }
        /// <summary>
        /// генерация id
        /// </summary>
        /// <returns></returns>
        int GenId()
        {
            return ++SID;
        }
        /// <summary>
        /// положить деньги на счет
        /// </summary>
        /// <param name="put">сумма</param>
        public void PutMoney(decimal put)
        {
            Balance += put;
            PrintMessage("Поступило: " + put + "$");
            PrintMessage("Текущий бaланс: " + Balance + "$");
        }
        /// <summary>
        /// снять с счета
        /// </summary>
        /// <param name="getm">сумма</param>
        public void TakeMoney(decimal getm)
        {
            if (getm <= Balance)
            {
                Balance -= getm;
                PrintMessage("Снято: " + getm + "$");
                PrintMessage("Текущий бaланс: " + Balance + "$");
            }
        }
        void PrintMessage(string mess)
        {
            if (Messege)
            {
                Console.WriteLine(mess);
            }
        }
    }
}
