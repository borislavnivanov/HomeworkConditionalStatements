/*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
*/

using System;


class PlayWithIntDoubleAndString
{
    static void Main()
    {
        int userInt;
        double userDouble;
        string userString;
        

        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");

        byte userinput = byte.Parse(Console.ReadLine());

        switch (userinput)
        {
            case 1:
                Console.WriteLine("Please enter intiger");
                userInt = int.Parse(Console.ReadLine());
                var resultInt = userInt + 1;
                Console.WriteLine(resultInt);
                break;

            case 2:
                Console.WriteLine("Please enter double");
                userDouble = double.Parse(Console.ReadLine());
                var resultDouble = userDouble + 1;
                Console.WriteLine(resultDouble);
                break;

            case 3:
                Console.WriteLine("Please enter string");
                userString = Console.ReadLine();
                var resultString = userString + "*";
                Console.WriteLine(resultString);
                break;

            default:
                break;
        }
    }
}