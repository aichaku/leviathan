using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack3 s = new Stack3(30, 4);

            s.push(0, 1);
            s.push(2, 1);
            s.push(3, 1);
            s.push(1, 1);
            s.push(2, 2);
            s.push(2, 3);
            s.push(2, 4);
            s.push(2, 4);
            s.push(2, 4);
            s.push(2, 4);
            s.push(2, 4);
            s.push(2, 4);
            s.push(3, 2);
            s.push(3, 3);
            s.push(3, 4);
            s.push(3, 5);
            s.push(3, 6);
            s.push(3, 7);
            s.push(3, 8);
            s.push(3, 9);
            s.push(3, 10);
            s.push(3, 11);

            foreach (int i in s.getArray())
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(s.pop(3));
            }


        }
    }
}
