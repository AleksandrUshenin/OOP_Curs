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
        string Transport.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int Transport.Dors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int Transport.Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int Transport.Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int Transport.countPassenger { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Driver Transport.driver { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        protected void Move()
        {
            throw new NotImplementedException();
        }

        void Transport.Move()
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
    class Employees // ассоциация
    {
        List<Driver> cars = new List<Driver>();
        public void addEmloers(Driver car)
        { }
    }
    class CompanyTaxi // агрегация
    {
        Parcing park = new Parcing();
        Employees emploers = new Employees();
    }
}
