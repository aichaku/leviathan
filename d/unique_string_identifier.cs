using System;

namespace unique_string_identifier
{
    class perse
    {
        static int sizeOfAscii = 128;

        static public bool isDuplicated(string a)
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

    class BruteForce
    {
        static public bool isDuplicated(string a)
        {

            for (var x = 0; x < a.Length; x++)
                for (var i = x + 1; i < a.Length; i++)
                    if (a[i] == a[x]) return true;
            return false;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            string s1 = "abcdefghijklmnopqrstuvwxyz";
            string s2 = "abcdefghijklmnapqrstuvwxyz";

            DateTime timer = DateTime.Now;

            if (perse.isDuplicated(s1))
            {
                Console.WriteLine("it has duplicated characters.");
            } else
            {
                Console.WriteLine("They are all unique characters.");
            }

            if (perse.isDuplicated(s2))
            {
                Console.WriteLine("it has duplicated characters.");
            }
            else
            {
                Console.WriteLine("They are all unique characters.");
            }

            TimeSpan timeGap = DateTime.Now - timer;
            Console.WriteLine("{0}:{1}", timeGap, timeGap.Milliseconds);

            timer = DateTime.Now;

            if (BruteForce.isDuplicated(s1))
            {
                Console.WriteLine("it has duplicated characters.");
            }
            else
            {
                Console.WriteLine("They are all unique characters.");
            }

            if (BruteForce.isDuplicated(s2))
            {
                Console.WriteLine("it has duplicated characters.");
            }
            else
            {
                Console.WriteLine("They are all unique characters.");
            }

            timeGap = DateTime.Now - timer;
            Console.WriteLine("{0}:{1}", timeGap, timeGap.Milliseconds);
        }
    }
}
