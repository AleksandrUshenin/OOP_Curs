using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    internal class ACoder : Coder, ICoder
    {
        public string Decoder(string stroka)
        {
            return DoCoder(stroka, 1);
        }

        public string Encoder(string stroka)
        {
            return DoCoder(stroka, -1);
        }
    }
}
