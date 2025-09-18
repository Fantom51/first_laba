using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fir_and_sec
{
    internal class Program
    {
        class Rayon
        {
            public int Population { get; set; }
            public Rayon(int population)
            {
                Population = population;
            }
            public virtual  void Display()
            {
                Console.WriteLine("Население района: " + Population);
                Console.WriteLine(" ");
                
            }

        }
        class Poselok : Rayon
        {
            public string Name { get; set; }
            public Poselok(int population, string name) :base(population)
            {
                Name = name;
            }
            public override void Display()
            {
                Console.WriteLine("Население посёлка: " + Population);
                Console.WriteLine("Название посёлка: " + Name);
                Console.WriteLine(" ");
            }
        }
        class City : Poselok
        {
            public double Area { get; set; }
            public City(int population, string name, double area) : base(population, name)
            {
                Area = area;
            }
            public override void Display()
            {
                Console.WriteLine("Население города: " + Population);
                Console.WriteLine("Название города: " + Name);
                Console.WriteLine("Площадь города: " + Area);
                Console.WriteLine(" ");
            }
        }
        class Oblast : City
        {
            public string AdminCenter { set; get; }
            public Oblast(int population, string name, double area, string admincenter) : base(population, name, area)
            {
                AdminCenter = admincenter;
            }
            public override void Display()
            {
                Console.WriteLine("Население области: " + Population);
                Console.WriteLine("Название области: " + Name);
                Console.WriteLine("Площадь области: " + Area);
                Console.WriteLine("Административный центр области: " + AdminCenter);
                Console.WriteLine(" ");
            }
        }
        static void Main(string[] args)
        {
            Rayon ob1 = new Rayon(10000);
            ob1.Display();
            Rayon ob2 = new Poselok(100000,"Egoryevsk");
            ob2.Display();
            Rayon ob3 = new City(500000, "Egorsk", 5000.50);
            ob3.Display();
            Rayon ob4 = new Oblast(1000000, "Egoryevskaya oblast", 100000, "Egorsk");
            ob4.Display();

        }
    }
}
