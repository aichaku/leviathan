using System;
using System.Diagnostics;
using StopWatchSample;

namespace unique_string_identifier
{
    class perse
    {
        static int sizeOfAscii = 128;
        static bool[] alphabetBucket = new bool[sizeOfAscii];
        static public bool isDuplicated(string a)
        {
            if (a.Length > sizeOfAscii) return true;

            // bool[] alphabetBucket = new bool[sizeOfAscii];

            //foreach (var c in a)
            //{
            //    Stopwatch watch = Stopwatch.StartNew();
            //    if (alphabetBucket[c]) return true;

            //    alphabetBucket[c] = true;
            //    watch.Stop();
            //    Console.Write("{0} ", watch.ElapsedTicks);
            //}

            for (int c = 0; c < a.Length; c++)
            {
                Stopwatch watch = Stopwatch.StartNew();
                if (alphabetBucket[c]) return true;

                alphabetBucket[c] = true;
                watch.Stop();
                Console.Write("{0} ", watch.ElapsedTicks);
            }

            Console.WriteLine();
            return false;
        }
    }

    class BruteForce
    {
        static public bool isDuplicated(string a)
        {

            for (var x = 0; x < a.Length; x++)
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (var i = x + 1; i < a.Length; i++)
                    if (a[i] == a[x]) return true;

                watch.Stop();
                Console.Write("{0} ", watch.ElapsedTicks);
            }

            Console.WriteLine();
            return false;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            OperationsTimer.DisplayTimerProperties();

            string s1 = "abcdefghijklmnopqrstuvwxyz";
            string s2 = "abcdefghijklmnapqrstuvwxyz";

            Stopwatch timer = Stopwatch.StartNew();

            if (perse.isDuplicated(s1)) Console.WriteLine("it has duplicated characters.");
            else Console.WriteLine("They are all unique characters.");

            if (perse.isDuplicated(s2)) Console.WriteLine("it has duplicated characters.");
            else Console.WriteLine("They are all unique characters.");

            timer.Stop();

            Console.WriteLine(timer.ElapsedTicks);

            timer = Stopwatch.StartNew();

            if (BruteForce.isDuplicated(s1)) Console.WriteLine("it has duplicated characters.");
            else Console.WriteLine("They are all unique characters.");

            if (BruteForce.isDuplicated(s2)) Console.WriteLine("it has duplicated characters.");
            else Console.WriteLine("They are all unique characters.");

            timer.Stop();
            Console.WriteLine(timer.ElapsedTicks);
        }
    }

}
