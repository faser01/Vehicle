
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Vehicle
{
    class Program
    {
        //класс транспорт
        internal class Vehicle
        {

            private double price, speed, year_of_construction;

            public double Price //цена
            {
                get { return price; }
                set { price = value; }
            }

            public double Speed //скорость
            {
                get { return speed; }
                set { speed = value; }
            }

            public double Year //дата производства
            {
                get { return year_of_construction; }
                set { year_of_construction = value; }
            }
            //конструктор
            public Vehicle(double Speed)
            {

                this.Speed = Speed;
            }
        }
        class Plane : Vehicle //самолет
        {
            public double Height { get; set; } //высота
            public double Passengers { get; set; } //каличество пассажиров
                                                   //наследование конструктора из Vehicle 
            public Plane(double Speed)
                : base(Speed)
            {
                Height = 300;
                Passengers = 100;
            }
        }

        class Ship : Vehicle //корабль
        {
            public double Passengers { get; set; } //количество пассажиров
            public string Port { get; set; } //порт приписки

               //наследование конструктора из Vehicle                               
            public Ship(double Speed)
                : base(Speed)
            {
                Passengers = 500;
                Port = "порт 1";
            }
        }

        class Car : Vehicle //машина
        {
            //наследование конструктора из Vehicle 
            public Car(double Speed)
                : base(Speed)
            {

            }
        }


        static void Main()
        {
            Console.WriteLine("Самолёт");
            Console.WriteLine("Характеристики самолёта");
            var plane = new Plane(200) { Year = 2001/*год производства*/, Price = 1000000, /*цена*/ Height = 10000, /*высота*/ Passengers = 250,/*количество пассажиров*/ Speed = 850 /*скорость*/};
            Console.WriteLine("Год выпуска: {0}", plane.Year.ToString());
            Console.WriteLine("Стоимость самолёта {0}:", plane.Price.ToString());
            Console.WriteLine("Высота полёта {0}:", plane.Height.ToString());
            Console.WriteLine("Число пассажиров {0}:", plane.Passengers.ToString());
            Console.WriteLine("Скорость {0}:", plane.Speed.ToString());
            Console.WriteLine();
            Console.WriteLine("Машина");
            Console.WriteLine("Характеристики Машина");
            var car = new Car(60) { Price = 50000,/*цена*/ Year = 1996, /*год производства*/ Speed = 250 /*скорость*/};
            Console.WriteLine("Стоимость машины {0}:", car.Price.ToString());
            Console.WriteLine("Год выпуска: {0}", car.Year.ToString());
            Console.WriteLine("Стоимость машины {0}:", car.Price.ToString());
            Console.WriteLine("Скорость {0}:", car.Speed.ToString());
            var ship = new Ship(20) { Price = 5000000/*цена*/, Year = 1986,/*год производства*/ Speed = 95,/*скорость*/ Port = "Порт Артур"/*порт приписки*/ };
            Console.WriteLine();
            Console.WriteLine("Корабль");
            Console.WriteLine("Характеристики корабля");
            Console.WriteLine("Стоимость корабля {0}:", ship.Price.ToString());
            Console.WriteLine("Год выпуска: {0}", ship.Year.ToString());
            Console.WriteLine("Стоимость машины {0}:", ship.Price.ToString());
            Console.WriteLine("Скорость {0}:", ship.Speed.ToString());
            Console.WriteLine("Порт приписки {0}:", ship.Port.ToString());
            Console.Read();
        }
    }
    
}
