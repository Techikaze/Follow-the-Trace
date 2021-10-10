using System;
using System.Collections.Generic;


namespace Follow_the_Trace
{
    class Program
    {
        static void Main(string[] args) { }

        class FollowTrace
        {
            public int getMin(int[] a, int k)
            {
                //Initializing counter list with default value 0 for each element in a
                List<int> counters = new List<int>();

                foreach(int item in a)
                {
                    counters.Add(0);
                }
                //Start following the trace
                bool hasFoundSolution = false;
                while(hasFoundSolution == false)
                {
                    counters[k]++;

                    if (counters[k] == 2)
                    {
                        hasFoundSolution = true;
                    }
                    else
                    {
                        k = k + a[k];
                    }
                }
                return k;
            }
        }

    }
}
