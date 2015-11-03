using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notably
{

    class Car
    {
        double v;
        string name;

        public void run()
        {
            Console.WriteLine("A car named " + name + " is running.");
        }

        public Car(double v, string name)
        {
            this.v = v;
            this.name = name;
        }
    }

    class Tesla : Car
    {
        public Tesla(double v) : base(v, "Tesla")
        { }
    }

    class notably
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am having a kick of writing C# code!");
            Console.ReadKey();

            Car c = new Tesla(8.8);

            c.run();
        }
    }
}
