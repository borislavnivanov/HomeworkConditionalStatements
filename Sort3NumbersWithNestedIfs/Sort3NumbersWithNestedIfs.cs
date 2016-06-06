/*Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.

Examples:

a	    b	    c	    result
5	    1	    2	    5 2 1
-2	    -2	    1	    1 -2 -2
-2	    4	    3	    4 3 -2
0	    -2.5	5	    5 0 -2.5
-1.1	-0.5	-0.1	-0.1 -0.5 -1.1
10	    20	    30	    30 20 10
1	    1	    1	    1 1 1
*/

using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        double a, b, c;
        double firstNumber = 0;
        double secondNumber = 0;
        double lastNumber = 0;
        Console.WriteLine("Please enter value for a:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for b:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for c:");
        c = double.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            firstNumber = a;
        }
        else if (a <= b && a <= c)
        {
            lastNumber = a;
        }
        else if (a <= b && a >= c || a >= b && a <= c)
        {
            secondNumber = a;
        }

        if (b > a && b > c)
        {
            firstNumber = b;
        }
        else if (b < a && b < c)
        {
            lastNumber = b;
        }
        else if (b < a && b > c || b > a && b < c)
        {
            secondNumber = b;
        }
        else if (b == a)
        {
            secondNumber = b;
        }

        if (c >= b && c >= a)
        {
            firstNumber = c;
        }
        else if (c <= b && c <= a)
        {
            lastNumber = c;
        }
        else if (c <= b && c >= a || c >= b && c <= a)
        {
            secondNumber = c;
        }

        Console.WriteLine("{0} {1} {2}", firstNumber, secondNumber, lastNumber);
    }
}
