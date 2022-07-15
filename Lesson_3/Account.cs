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


        public Account(string FirstName, string SecondName, string pass)
        {
            ID = GenId();
            Password = pass;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            Messege = true;
            Type = TypeUser.User;
        }
        public Account(decimal balance, string FirstName, string SecondName, string pass) : this(FirstName, SecondName, pass)
        {
            Balance = balance;
        }
        public Account(TypeUser type, string FirstName, string SecondName, string pass) : this(FirstName, SecondName, pass)
        {
            Type = type;
            Password = pass;
        }
        public Account(decimal balance, TypeUser type, string FirstName, string SecondName, string pass) : this(balance, FirstName, SecondName, pass)
        {
            Type = type;
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
        public bool PutMoney(decimal put)
        {
            if (put > 0)
            {
                Balance += put;
                return true;
            }
            return false;
        }
        /// <summary>
        /// снять с счета
        /// </summary>
        /// <param name="getm">сумма</param>
        public bool GetMoney(decimal getm)
        {
            if (getm <= Balance && getm > 0)
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

        public override bool Equals(object obj)
        {
            Account accE;
            try
            {
                accE = (Account)obj;
            }
            catch
            {
                return false;
            }
            return this.ID == accE.ID;
        }
        public static bool operator ==(Account acc1, Account acc2)
        {
            return Equals(acc1, acc2);
        }
        public static bool operator !=(Account acc1, Account acc2)
        {
            return !Equals(acc1, acc2);
        }
        public override string ToString()
        {
            return ($"ID: {ID}  FirstName: {FirstName}  SecondName: {SecondName}");
        }
        public override int GetHashCode()
        {
            return ID + FirstName.Length + SecondName.Length;
        }
    }
}
