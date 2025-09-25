using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace fir_and_sec
{
    internal class Program
    {
        public abstract class AdminUnit
        {
            public string name;
            public int population;
            public double area;
            public AdminUnit(string Name, int Population, double Area)
            {
                name = Name;
                population = Population;
                area = Area;
            }
            public virtual void DisplayInfo()
            {
                Console.WriteLine("Название: " + name);
                Console.WriteLine("Население: " + population);
                Console.WriteLine("Площадь: " + area);
                Console.WriteLine(" ");
            }
        }
        class Rayon : AdminUnit
        {
            public Rayon(string Name, int Population, double Area):
                base(Name, Population, Area)
            {
            }
            public override void DisplayInfo()
            {
                Console.WriteLine("Район:");
                base.DisplayInfo();
            }

        }
        class Poselok : AdminUnit
        {
            public string type;
            public Poselok(string Name, int Population, double Area, string Type) : base(Name, Population, Area)
            {
                type = Type;
            }
            
            public override void DisplayInfo()
            {
                Console.WriteLine("Посёлок:");
                Console.WriteLine("Тип посёлка: " + type);
                base.DisplayInfo();
            }
        }
        class City : AdminUnit
        {
            public string status;
            public City(string Name, int Population, double Area, string Status) : base(Name, Population, Area)
            {
                status = Status;
            }
            public override void DisplayInfo()
            {
                Console.WriteLine("Город:");
                Console.WriteLine("Статус: " + status);
                base.DisplayInfo();


            }
        }
        class Oblast : AdminUnit
        {
            public string adminCenter;
            public Oblast(string Name, int Population, double Area, string Admincenter) : base(Name, Population, Area)
            {
                adminCenter = Admincenter;
            }
            public override void DisplayInfo()
            {
                Console.WriteLine("Область:");
                Console.WriteLine("Административный центр области: " + adminCenter);
                base.DisplayInfo();
            }
        }
        static void Main(string[] args)
        {
            Poselok un1 = new Poselok("Egoryevsk", 1000, 1150.5, "Дачный");
            Rayon un2 = new Rayon("Egoryevskiy", 10000, 4000.12);
            City un3 = new City("Egortown", 3000000, 10000, "Административный центр");
            Oblast un4 = new Oblast("Egoryevskaya", 8000000, 5000000, "Egortown");
            un1.DisplayInfo();
            un2.DisplayInfo();
            un3.DisplayInfo();
            un4.DisplayInfo();

        }
    }
}
