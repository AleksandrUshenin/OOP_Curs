using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    /// <summary>
    /// типы аккаунтов юзера
    /// </summary>
    [Flags]
    internal enum TypeUser
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
        /// статическая переменная для генерации id
        /// </summary>
        private static int SID;
        private string Password { get; set; }
        public TypeUser Type { get; private set; }
        public int ID { get; private set; }
        public decimal Balance { get; private set; }
        public string FirstName { get; private set; }
        public string SecondName { get; private set; }
        public bool Messege { get; private set; }

        public Account(string name1, string name2, string pass)
        {
            ID = GenId();
            Password = pass;
            FirstName = name1;
            SecondName = name2;
            Messege = true;
            Type = TypeUser.User;
        }
        public Account(decimal bal, string name1, string name2, string pass)
        {
            ID = GenId();
            Balance = bal;
            Password = pass;
            FirstName = name1;
            SecondName = name2;
            Messege = true;
            Type = TypeUser.User;
        }
        public Account(TypeUser type, string name1, string name2, string pass)
        {
            ID = GenId();
            Type = type;
            Password = pass;
            FirstName = name1;
            SecondName = name2;
            Messege = true;
        }
        public Account(decimal bal, TypeUser type, string name1, string name2, string pass)
        {
            ID = GenId();
            Balance = bal;
            Type = type;
            Password = pass;
            FirstName = name1;
            SecondName = name2;
            Messege = true;
        }

        /// <summary>
        /// генерация id
        /// </summary>
        /// <returns></returns>
        private static int GenId()
        {
            return ++SID;
        }
        /// <summary>
        /// проверка пароля 
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
        public bool provPass(string pass)
        {
            return pass == Password;
        }
        /// <summary>
        /// положить деньги на счет
        /// </summary>
        /// <param name="put">сумма</param>
        public void PutMoney(decimal put)
        {
            Balance += put;
        }
        /// <summary>
        /// снять с счета
        /// </summary>
        /// <param name="getm">сумма</param>
        public bool GetMoney(decimal getm)
        {
            if (getm <= Balance)
            {
                Balance -= getm;
                return true;
            }
            return false;
        }
        /// <summary>
        /// пперевод со счета
        /// </summary>
        /// <param name="acc"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public bool PerevodFromAcc(Account acc, decimal money)
        {
            if (acc.GetMoney(money))
            {
                PutMoney(money);
                return true;
            }
            return false;
        }
        /// <summary>
        /// перевод на счет
        /// </summary>
        /// <param name="acc"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public bool PerevodToAcc(Account acc, decimal money)
        {
            if (GetMoney(money))
            {
                acc.PutMoney(money);
                return true;
            }
            return false;
        }
        /// <summary>
        /// переворот строки
        /// </summary>
        /// <param name="mess"></param>
        /// <returns></returns>
        public string ReversString(string mess)
        {
            return new string(mess.Reverse().ToArray());
        }
    }
}
