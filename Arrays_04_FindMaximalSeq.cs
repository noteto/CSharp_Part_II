using System;
using System.Collections.Generic;


// Find maximal sequence ex: { 2, 1, 1, 2, 3, 3, 2, 2, 2, 2, 1 }; -> {2,2,2,2}

class MaximumSeqEqual
{
    static void Main(string[] args)
    {
        int[] testArray = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 2, 1,1,1,1,1 };
        List<int> maximumSeqArray = new List<int>();
        
        int start = 0;
        int len = 1;
        int bestStart = 0;
        int bestLen = 1;

        for (int i = 0; i < testArray.Length - 1; i++)
        {
            if (testArray[i] == testArray[i + 1])
            {
                len++;

                if (len > bestLen)
                {
                    bestLen = len;
                    bestStart = start;    // I. =0; /II. =1 /III. =2
                }
            }
            else
            {
                len = 1;
                start = i + 1;
            }
        }

        Console.Write("Maximal sequence: { ");
        for (int i = bestStart; i < bestStart + bestLen; i++)
        {
            maximumSeqArray.Add(testArray[i]);
            Console.Write("{0}, ", testArray[i]);
        }
        Console.Write(" }\n");
    }
}
