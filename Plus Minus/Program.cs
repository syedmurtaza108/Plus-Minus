/*
Given an array of integers, calculate the fractions of its elements that are positive, negative, and are zeros. Print the decimal value of each fraction on a new line.

Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to 10^-4 are acceptable.

Input Format

The first line contains an integer, n, denoting the size of the array. 
The second line contains n space-separated integers describing an array of numbers arr.

Output Format

You must print the following 3 lines:

A decimal representing of the fraction of positive numbers in the array compared to its size.
A decimal representing of the fraction of negative numbers in the array compared to its size.
A decimal representing of the fraction of zeros in the array compared to its size.
Sample Input

6
-4 3 -9 0 4 1         
Sample Output

0.500000
0.333333
0.166667
Explanation

There are 3 positive numbers,  2 negative numbers, and 1 zero in the array. 
The proportions of occurrence are positive: 0.50000, negative: 0.333333 and zeros: 0.16666.

*/

//FINISHED IT IN 6 MIN

using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_Minus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            plusMinus(arr);
        }

        static void plusMinus(int[] arr)
        {
            ArrayList listPos = new ArrayList();
            ArrayList listZero = new ArrayList();
            ArrayList listNeg = new ArrayList();

            double length = arr.Length;

            for(int i = 0; i<arr.Length;i++)
            {
                if (arr[i] < 0)
                    listNeg.Add(arr[i]);
                else if (arr[i] == 0)
                    listZero.Add(arr[i]);
                else
                    listPos.Add(arr[i]);
            }

            Console.WriteLine((listPos.Count / length).ToString("N6"));
            Console.WriteLine((listNeg.Count / length).ToString("N6"));
            Console.WriteLine((listZero.Count / length).ToString("N6"));
        }
    }
}
