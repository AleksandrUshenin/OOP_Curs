using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    internal class Test
    {
        private Ratio R1;
        private Ratio R2;
        private bool[] Result;

        public Test()
        {
            Result = new bool[] { T1(), T2(), T3(), T4(), T5(), T6(), T7(), T8(), T9(), T10(), T11(), T12(), T13(), T14(), T15() };
        }
        public string GetRerult()
        {
            foreach (var data in Result)
            {
                if (!data)
                {
                    return "Test Failed!";
                }
            }
            return "Test Complit!";
        }


        private bool T1()
        {
            R1 = new Ratio(3, 7);
            R2 = new Ratio(4, 5);
            return (R1 + R2) == new Ratio(43, 35);
        }
        private bool T2()
        {
            R1 = new Ratio(4, 5);
            R2 = new Ratio(3, 7);
            return (R1 - R2) == new Ratio(13, 35);
        }
        private bool T3()
        {
            R1 = new Ratio(4, 5);
            R2 = new Ratio(3, 7);
            return (R1 * R2) == new Ratio(12, 35);
        }
        private bool T4()
        {
            R1 = new Ratio(4, 5);
            R2 = new Ratio(3, 7);
            return (R1 / R2) == new Ratio(28, 15);
        }
        private bool T5()
        {
            //%
            R1 = new Ratio(3, 4);
            R2 = new Ratio(1, 2);

            var R3 = new Ratio(4, 7);
            var R4 = new Ratio(2, 5);
            R1 = R1 % R2;
            R2 = R3 % R4;
            return R1 == new Ratio(2, 8) && R2 == new Ratio(6, 35);
        }
        private bool T6()
        {
            R1 = new Ratio(2, 5);
            return ++R1 == new Ratio(3, 6);
        }
        private bool T7()
        {
            R1 = new Ratio(2, 5);
            return --R1 == new Ratio(1, 4);
        }
        private bool T8()
        {
            R1 = new Ratio(2, 5);
            R2 = -R1;
            return R2 == new Ratio(-2, -5);
        }
        private bool T9()
        {
            R1 = new Ratio(2, 5);
            return R1 != new Ratio(9, 10);
        }
        private bool T10()
        {
            R1 = new Ratio(2, 5);
            return (R1 > new Ratio(1, 3)) && (R1 < new Ratio(10, 5));
        }
        private bool T11()
        {
            R1 = new Ratio(2, 5);
            return (R1 >= new Ratio(-2, -5)) && (R1 <= new Ratio(10, 5));
        }
        private bool T12()
        {
            R1 = new Ratio(2, 5);
            return (R1.ToString() == "2/5");
        }
        private bool T13()
        {
            R1 = new Ratio(2, 5);
            int res1 = R1;
            int res2 = new Ratio(4, 2);
            return (res1 == 0) && (res2 == 2);
        }
        private bool T14()
        {
            R1 = new Ratio(2, 5);
            float res = R1;
            return (R1 == 0.4f);
        }
        private bool T15()
        {
            R1 = new Ratio(3, 7);
            return R1.Equals(R1) && (R1.Equals(new Ratio(3, 7)) == true);
        }
    }
}
