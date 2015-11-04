using System;

namespace unique_string_identifier
{
    class perse
    {
        const int sizeOfAscii = 128;

        public bool isDuplicated(string a)
        {
            if (a.Length > sizeOfAscii)
            {
                return true;
            }

            bool[] alphabetBucket = new bool[sizeOfAscii];

            foreach (var c in a)
            {
                if (alphabetBucket[c])
                {
                    return true;
                } else
                {
                    alphabetBucket[c] = true;
                }
            }

            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abcdefghijklmnopqrstuvwxyz";
            string s2 = "abcdefghijklmnapqrstuvwxyz";

            perse p = new perse();

            if (p.isDuplicated(s1))
            {
                Console.WriteLine("it has duplicated characters.");
            } else
            {
                Console.WriteLine("They are all unique characters.");
            }

            if (p.isDuplicated(s2))
            {
                Console.WriteLine("it has duplicated characters.");
            }
            else
            {
                Console.WriteLine("They are all unique characters.");
            }
        }
    }
}
