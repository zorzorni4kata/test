using System;
using System.Collections.Generic;
using System.Linq;

class SortedSubsets
{
    static void Main()
    {
        // read and save input data
        int sum = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();

        // convert input to int
        int[] numbers = new int[input.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        List<List<int>> results = new List<List<int>>();

        // calculate possible combinations and iterate through
        int combinations = (int)Math.Pow(2, numbers.Length);

        for (int i = 1; i <= combinations; i++)
        {
            int currentSum = 0;
            List<int> currentSubset = new List<int>();

            /* check the binary representation of the current combination (1 to 2^n) 
             * sum the numbers at indexes where the bit value is 1
             * e.g. 5 = 101 in binary so our 5th combination is sum of numbers[0] + numbers[2]
             */
            for (int j = 0; j < 32; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    currentSum += numbers[j];
                    /* we need a list of all numbers in the subset for sorting purposes 
                     * we can also use a string to keep the current subset but this way
                     * sorting the output is much more difficult */
                    currentSubset.Add(numbers[j]);
                }
            }

            /* check if the current sum equals the sum we're looking for
             * if yes -> sort the elements of the list and add it to results
             * sort the subset list so numbers are in increasing order, this will help later on */
            if (currentSum == sum)
            {
                currentSubset.Sort();
                results.Add(currentSubset);
            }
        }

        // if no matching subsets are found -> exit the program
        if (results.Count == 0)
        {
            Console.WriteLine("No matching subsets.");
            return;
        }

        /* because we already sorted the subsets in increasing order the smallest numbers in the subsets are first 
         * and we can now sort the output by subset length and then by value of the first number
         */
        var output = results.OrderBy(subset => subset.Count).ThenBy(subset => subset.First());
        
        // now print we print the output and hope for the best
        foreach (var subset in output)
        {
            foreach (var number in subset)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
