using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_3
{
    internal class FIOandEMAI
    {
        public List<string> Loader(FileInfo file)
        {
            List<string> listS = new List<string>();
            using (StreamReader sr = new StreamReader(file.FullName, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    listS.Add(sr.ReadLine());
                }
            }
            return listS;
        }
        public List<Information> Desereales(List<string> listS)
        {
            List<Information> linfo = new List<Information>();
            foreach (string s in listS)
            {
                Information inform = new Information(s.Split('&').First(), s.Split('&').Last());
                linfo.Add(inform);
            }
            return linfo;
        }
        public void CreateFileEmail(List<string> list)
        {
            var arr = list.ToArray();
            for (int i = 0; i < list.Count(); i++)
            {
                SearchMail(ref arr[i]);
            }
            string dir = Directory.GetCurrentDirectory();
            dir = Path.Combine(dir, "Data");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(Path.Combine(dir, "Data"));
            }
            dir = Path.Combine(dir, "Mailes.txt");
            if (!File.Exists(dir))
                using (StreamWriter sw = new StreamWriter(dir))
                {
                    foreach (var line in arr)
                    {
                        sw.WriteLine(line);
                    }
                }
        }
        public void SearchMail(ref string s)
        {
            s = s.Split('&').Last();
        }
    }
}
