using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    interface ICoder
    {
        string Decoder(string stroka);
        string Encoder(string stroka);
    }
    internal class Coder
    {
        protected string DoCoder(string stroka, int key)
        {
            char[] code = new char[stroka.Length];
            for (int i = 0; i < code.Length; i++)
            {
                char c = stroka[i];
                if (!Char.IsLetter(c))
                {
                    code[i] = c;
                }
                else if (Char.IsLower(c))
                {
                    code[i] = (char)(c + key);
                }
                else
                {
                    code[i] = (char)(c + key);
                }
            }
            return new string(code);
        }
    }
}
