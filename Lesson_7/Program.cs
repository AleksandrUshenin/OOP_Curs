using System;

namespace Lesson_7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ACoder acoder = new ACoder();
            BCoder bcoder = new BCoder();

            string stroka = "Строка которую шифруем";

            string strokaAfterCoder = acoder.Encoder(stroka);
            Print(strokaAfterCoder);
            Print(acoder.Decoder(strokaAfterCoder));

            int key = 5;
            strokaAfterCoder = bcoder.Encoder(stroka, key);
            Print(strokaAfterCoder);
            Print(bcoder.Decoder(strokaAfterCoder, key));

            Console.ReadKey();
        }
        static void Print(string stroka)
        {
            Console.WriteLine(stroka);
        }
    }
}
