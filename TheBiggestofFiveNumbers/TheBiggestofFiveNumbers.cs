/*Write a program that finds the biggest of five numbers by using only five if statements.
Examples:

a	    b	    c	    d	    e	    biggest
5	    2	    2	    4	    1	    5
-2	    -22	    1	    0	    0	    1
-2	    4	    3	    2	    0	    4
0	    -2.5	0	    5	    5	    5
-3	    -0.5	-1.1	-2	    -0.1	-0.1
*/

using System;

class TheBiggestofFiveNumbers
{
    static void Main()
    {
        double a, b, c, d, e, semi1, semi2, result;
        Console.WriteLine("Please enter value for a:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for b:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for c:");
        c = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for d:");
        d = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for e:");
        e = double.Parse(Console.ReadLine());

        semi1 = Math.Max(a, b);
        semi2 = Math.Max(c, d);

        if (semi1 > semi2)
        {
            result = Math.Max(semi1, e);
        }
        else
        {
            result = Math.Max(semi2, e);
        }
        
     
        Console.WriteLine("Biggest is {0}.", result);
    }
}