using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderLibrary
{
    public class Creator
    {
        private Creator()
        { }

        public static Bilding CreateBuild()
        {
            Bilding bild = new Bilding();
            bild.Heght_bilding = 50;
            bild.Coutn_flors = 10;
            bild.Count_entrances = 2;
            bild.Count_apartments = 50;
            bild.Street_Name = "Nevski Prospekt";
            return bild;
        }
        public static Bilding CreateBuild(int heght)
        {
            Bilding bild = new Bilding();
            bild.Heght_bilding = heght;
            bild.Coutn_flors = 10;
            bild.Count_entrances = 2;
            bild.Count_apartments = 50;
            bild.Street_Name = "Nevski Prospekt";
            return bild;
        }
        public static Bilding CreateBuild(int heght, int flors)
        {
            Bilding bild = new Bilding();
            bild.Heght_bilding = heght;
            bild.Coutn_flors = flors;
            bild.Count_entrances = 2;
            bild.Count_apartments = 50;
            bild.Street_Name = "Nevski Prospekt";
            return bild;
        }
        public static Bilding CreateBuild(int heght, int flors, int entrances)
        {
            Bilding bild = new Bilding();
            bild.Heght_bilding = heght;
            bild.Coutn_flors = flors;
            bild.Count_entrances = entrances;
            bild.Count_apartments = 50;
            bild.Street_Name = "Nevski Prospekt";
            return bild;
        }
        public static Bilding CreateBuild(int heght, int flors, int entrances, int apartments)
        {
            Bilding bild = new Bilding();
            bild.Heght_bilding = heght;
            bild.Coutn_flors = flors;
            bild.Count_entrances = entrances;
            bild.Count_apartments = apartments;
            bild.Street_Name = "Nevski Prospekt";
            return bild;
        }
        public static Bilding CreateBuild(int heght, int flors, int entrances, int apartments, string street)
        {
            Bilding bild = new Bilding();
            bild.Heght_bilding = heght;
            bild.Coutn_flors = flors;
            bild.Count_entrances = entrances;
            bild.Count_apartments = apartments;
            bild.Street_Name = street;
            return bild;
        }
    }
}
