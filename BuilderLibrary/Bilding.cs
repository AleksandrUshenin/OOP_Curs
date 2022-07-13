using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderLibrary
{
    public class Bilding
    {
        public Bilding()
        {
            GenID();
        }
        public Bilding(int hight)
        {
            GenID();
            Heght = hight;
        }

        private static int Id;
        private int Heght;
        private int Flors;
        private int Apartments;
        private int Entrances;
        private string Streeet;

        public int Id_bilding { get { return Id; } private set { Id = value; } }
        public int Heght_bilding { get { return Heght; } set { Heght = value; } }
        public int Coutn_flors { get { return Flors; } set { Flors = value; } }
        public int Count_apartments { get { return Apartments; } set { Apartments = value; } }
        public int Count_entrances { get { return Entrances; } set { Entrances = value; } }
        public string Street_Name { get { return Streeet; } set { Streeet = value; } }

        public double GetHight_Flor()
        {
            return ((double)Heght / Flors);
        }
        public int Get_apartments_in_flor()
        {
            return Apartments / Flors;
        }
        public int Get_apartments_in_entrance()
        {
            return Apartments / Entrances;
        }
        /// <summary>
        /// генерация id
        /// </summary>
        private static void GenID()
        {
            Id++;
        }
        public override string ToString()
        {
            return $"Id:{Id} Heght:{Heght} Flors:{Flors} Apartments:{Apartments} Entrances:{Entrances}  Streeet:{Streeet}";
        }
    }
}
