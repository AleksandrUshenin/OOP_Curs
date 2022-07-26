using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    internal class BCoder : Coder, ICoder
    {
        //private readonly int Max_key = 65276;
        private readonly int Max_key = 33000;

        public string Decoder(string stroka, int i)
        {
            int key = Max_key - i;
            return DoCoder(stroka, -key);
        }
        public string Decoder(string stroka)
        {
            return null;
        }

        public string Encoder(string stroka, int i)
        {
            int key = Max_key - i;
            return DoCoder(stroka, key);
        }
        public string Encoder(string stroka)
        {
            return null;
        }
    }
}
