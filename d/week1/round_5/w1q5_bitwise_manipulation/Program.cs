using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1q5_bitwise_manipulation
{

    class Bit32
    {
        private Int32 i;

        public Bit32(int v)
        {
            i = v;
            // Console.WriteLine(Convert.ToString(i, 2));
        }

        public Int32 v
        {
            get { return i; }
        }

        public void insert(Int32 other, int begin, int end)
        {
            i |= (other <<= end);
        }

        override
        public String ToString()
        {
            return Convert.ToString(i, 2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Bit32 i = new Bit32(Convert.ToInt32("01101101", 2));
            i.insert(Convert.ToInt32("1011", 2), 2, 4);
            Console.WriteLine(i.ToString());
        }
    }
}
