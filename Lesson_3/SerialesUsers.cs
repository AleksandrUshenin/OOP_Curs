using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lesson_3
{
    internal class SerialesUsers
    {
        private List<Information> inform;
        private string dir;
        public List<Information> Datas { get { return inform; } }

        public SerialesUsers()
        {
            inform = new List<Information>();
            dir = Path.Combine(GetDirHome(), "Data_serealrs");
            HaveDir(dir);
            dir = Path.Combine(dir, "User_Data.txt");
        }

        public void AddInfo(Information info)
        {
            inform.Add(info);
        }
        public void Save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(dir, FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, inform);
            }
        }
        public void Load()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(dir, FileMode.OpenOrCreate))
            {
                inform = (List<Information>)bf.Deserialize(fs);
            }
        }
        public void SetDir(string dir)
        {
            this.dir = dir;
        }
        public List<Information> GetList()
        {
            if (inform != null)
            {
                return inform;
            }
            return null;
        }

        private string GetDirHome()
        {
            return Directory.GetCurrentDirectory();
        }
        private void HaveDir(string dir)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }
        private void HaveFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }
        }
    }
}
