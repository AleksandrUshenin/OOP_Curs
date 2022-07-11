using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
#if DEBUG
    internal class Admin
    {
        protected internal static readonly string NTestN = "qaz102938Piuy";
    }
#endif
    internal class Bank
    {
        /// <summary>
        /// список аакаунтов
        /// </summary>
        private List<Account> listAcc;
        /// <summary>
        /// текущиц аккаунт в который выполнен вход
        /// </summary>
        private Account AccNow;

        public Bank()
        {
            listAcc = new List<Account>();
        }
        /// <summary>
        /// вход в аккаунт
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Password"></param>
        public void Enter(int id, string Password)
        {
            foreach (Account acc in listAcc)
            {
                if (id == acc.ID && acc.provPass(Password))
                {
                    AccNow = acc;
                }
            }
        }
        /// <summary>
        /// выход из аккаунта
        /// </summary>
        public void Exit()
        {
            AccNow = null;
        }

        public void Perevod(int com)
        {
            if (AccNow != null)
            {
                string PoiskName = Display.SetName1() + Display.SetName2();
                decimal put = Display.VvodSumm();

                if (com == 1)// списать c акк 
                {
                    if (AccNow.PerevodFromAcc(GetAcc(PoiskName), put))
                    {
                        if (AccNow.Messege)
                        {
                            Display.PrintSost(2, AccNow.ID, put, AccNow.Balance);
                        }
                    }
                    else
                    {
                        Display.PrintMessage("Error!");
                    }
                }
                else if (com == 2)// положить на акк 
                {
                    if (AccNow.PerevodToAcc(GetAcc(PoiskName), put))
                    {
                        if (AccNow.Messege)
                        {
                            Display.PrintSost(1, AccNow.ID, put, AccNow.Balance);
                        }
                    }
                    else
                    {
                        Display.PrintMessage("Error!");
                    }
                }
            }
        }
        /// <summary>
        /// положить деньги на счет
        /// </summary>
        public void PutMoney()
        {
            decimal put = Display.VvodSumm();
            AccNow.PutMoney(put);
            if (AccNow.Messege)
            {
                Display.PrintSost(2, AccNow.ID, put, AccNow.Balance);
            }
        }
        /// <summary>
        /// снять деньги со счета 
        /// </summary>
        public void GetMoney()
        {
            decimal getM = Display.VvodSumm();
            AccNow.GetMoney(getM);
            if (AccNow.Messege)
            {
                Display.PrintSost(1, AccNow.ID, getM, AccNow.Balance);
            }
        }
        /// <summary>
        /// добавить новый аккаунт
        /// </summary>
        public void AddNewAcc()
        {
            listAcc.Add(new Account(Display.SetName1(), Display.SetName2(), Display.VvodPass()));
        }
        /// <summary>
        /// добавить новый аккаунт
        /// </summary>
        /// <param name="type">тип аккаунта</param>
        public void AddNewAcc(TypeUser type)
        {
            listAcc.Add(new Account(type, Display.SetName1(), Display.SetName2(), Display.VvodPass()));
        }
#if DEBUG
        public List<Account> Testadmin(string admin)
        {
            if (AccNow.Type == TypeUser.Admin && admin == Admin.NTestN)
            {
                return listAcc;
            }
            return null;
        }
#endif

        private Account GetAcc(int id)
        {
            foreach (Account acc in listAcc)
            {
                if (id == acc.ID)
                {
                    return acc;
                }
            }
            return null;
        }
        private Account GetAcc(string AllName)
        {
            foreach (Account acc in listAcc)
            {
                if (AllName == acc.FirstName + acc.SecondName)
                {
                    return acc;
                }
            }
            return null;
        }
    }
}
