/*Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.
Examples:

a	    b	    c	    result
5	    2	    2	    +
-2	    -2	    1	    +
-2	    4	    3	    -
0	    -2.5	4	    0
-1	    -0.5	-5.1	-
*/
using System;

class MultiplicationSign
{
    static void Main()
    {
        double a, b, c;
        char result;

        Console.WriteLine("Please enter value for a:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for b:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for c:");
        c = double.Parse(Console.ReadLine());


        if (a < 0)
        {
            if (b < 0)
            {
                if (c < 0)
                {
                    result = '-';
                }
                else
                {
                    result = '+';
                }
            }
            else
            {
                if (c < 0)
                {
                    result = '+';
                }
                else
                {
                    result = '-';
                }
            }
        }
        else
        {
            if (b < 0)
            {
                if (c < 0)
                {
                    result = '+';
                }
                else
                {
                    result = '-';
                }
            }
            else
            {
                if (c < 0)
                {
                    result = '-';
                }
                else
                {
                    result = '+';
                }
            }
        }

        if (a == 0 || b == 0 || c == 0)
        {
            result = '0';
        }
        

        Console.WriteLine("product sign is {0}", result);
    }
}

