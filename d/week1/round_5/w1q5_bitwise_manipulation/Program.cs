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

        public Int32 v
        {
            get { return i; }
            set { i = value; }
        }

        public String toString()
        {

            /*
            string s = i.ToString();
            string s = Convert.ToString(i);
            string s = string.Format("{0}", i);
            string s = "" + i;
            string s = string.Empty + i;
            string s = new StringBuilder().Append(i).ToString();
            */

            StringBuilder builder = new StringBuilder();

            for (int m = 0; m < 32; m++)
            {
                if (true) //(i & (1 << m))
                {
                    builder.Append(1);
                } else
                {
                    builder.Append(0);
                }
            }


            return i.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
