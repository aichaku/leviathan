using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    class Stack3
    {
        private int[] s;
        private int numOfStack;
        private int[] top;
        private int[] bottom;

        public Stack3(int size, int n)
        {
            s = new int[size];
            numOfStack = n;
            top = new int[n];
            bottom = new int[n];

            for (int i = 0; i < n; i++)
            {
                top[i] = -1;
                bottom[i] = i * size / n;
            }
        }

        public int[] getTop()
        {
            return top;
        }

        public int[] getArray()
        {
            return s;
        }

        private bool isOverFlow(int i)
        {
            int position = top[i];

            if (++position + bottom[i] == s.Length) return true;
            if (i < numOfStack - 1 && position + bottom[i] == bottom[i + 1]) return true;
            
            return false;
        }

        public void push(int id, int value)
        {
            if (isOverFlow(id))
            {
                Console.WriteLine("unable to add [" + value + "] due to stack overflow detected.");
                return;
            }

            top[id]++;
            s[top[id] + bottom[id]] = value;

        }

        public int pop(int id)
        {
            if (top[id] == -1)
            {
                Console.WriteLine("unable to pop due to empty stack");
                return ~0;
            }

            return s[top[id]-- + bottom[id]];
        }


    }
}
