using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    interface Transport
    {
        string Name { get; set; }
        int Dors { get; set; }
        int Wheels { get; set; }
        int Speed { get; set; }
        int countPassenger { get; set; }
        Driver driver { get; set; }
        void Move();
    }
    class Car : Transport // реализация 
    {
        protected string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        protected int Dors
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        protected int Wheels
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        protected int Speed
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        protected int countPassenger
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        protected Driver driver
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        protected void Move()
        {
            throw new NotImplementedException();
        }
    }
    class Parcing // ассоциация 
    {
        List<Car> cars = new List<Car>();
        public void addCar(Car car)
        { }
    }
    interface Person
    {
        string Name { get; set; }
        int Age { get; set; }
    }
    class Driver : Person// реализация
    {
        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Age
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
    class Emploers // ассоциация
    {
        List<Driver> cars = new List<Driver>();
        public void addEmloers(Driver car)
        { }
    }
    class CompanyTaxi // агрегация
    {
        Parcing park = new Parcing();
        Emploers emploers = new Emploers();
    }
}
