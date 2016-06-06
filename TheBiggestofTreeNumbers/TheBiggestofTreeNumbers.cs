/*Write a program that finds the biggest of three numbers.
Examples:

a	    b	    c	    biggest
5	    2	    2	    5
-2	    -2	    1	    1
-2	    4	    3	    4
0	    -2.5	5	    5
-0.1	-0.5	-1.1	-0.1
*/

using System;

class TheBiggestofTreeNumbers
{
    static void Main()
    {
        double a, b, c, result;
        Console.WriteLine("Please enter value for a:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for b:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for c:");
        c = double.Parse(Console.ReadLine());

        result = Math.Max(a, b);
        result = Math.Max(result, c);

        Console.WriteLine("Biggest is {0}.", result);
    }
}
