/*Write a program that converts a number in the range[0…999] to words, corresponding to the English pronunciation.
Examples:

numbers number as words
0	Zero
9	Nine
10	Ten
12	Twelve
19	Nineteen
25	Twenty five
98	Ninety eight
98	Ninety eight
273	Two hundred and seventy three
400	Four hundred
501	Five hundred and one
617	Six hundred and seventeen
711	Seven hundred and eleven
999	Nine hundred and ninety nine
*/

using System;

namespace NumbersAsWords
{

    class NumberAsWords
    {
        static byte number = 0;
        static string[] numsToText = { "zero", "one", "two", "tree", "four", "five", "six", "seven", "eight", "nine" };
        static string[] teensToText = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        static string[] tensToText = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        static string userInput;

        static void Main()
        {
            Console.WriteLine("Please enter number between 0 and 999:");
            userInput = Console.ReadLine();

            try
            {
                number = byte.Parse(userInput);
            }
            catch
            {
                //TODO: remove the line from showing 
                Console.WriteLine("Pleae enter a valid number between 0 and 999.");
            }

            if (userInput.Length == 1)
            {
                Console.WriteLine(numsToText[number]);
            }
            else if (userInput.Length == 2)
            {
                twoNumbers();
            }
            else if (userInput.Length == 3)
            {
                treeNumbers();
            }
        }
        static void twoNumbers()
        {
            char n = userInput[0];
            string p = char.ToString(n);
            byte firstNum = byte.Parse(p);

            char y = userInput[1];
            string x = char.ToString(y);
            byte secondNum = byte.Parse(x);

            if (firstNum == 1)
            {
                Console.WriteLine(teensToText[secondNum]);
            }
            else
            {
                if (secondNum == 0)
                {
                    Console.WriteLine(tensToText[firstNum - 2]);
                }
                else
                {
                    Console.WriteLine("{0} {1}", tensToText[firstNum - 2], numsToText[secondNum]);
                }
            }
        }

        static void treeNumbers()
        {
            char n = userInput[0];
            string p = char.ToString(n);
            byte firstNum = byte.Parse(p);

            char y = userInput[1];
            string x = char.ToString(y);
            byte secondNum = byte.Parse(x);

            char r = userInput[2];
            string g = char.ToString(r);
            byte thirdNum = byte.Parse(g);

            if (secondNum == 1)
            {
                Console.WriteLine(numsToText[firstNum] + " hundred and " + teensToText[thirdNum]);
            }
            else if (secondNum == 0)
            {
                if (thirdNum == 0)
                {
                    Console.WriteLine(numsToText[firstNum] + " hundred");
                }
                else
                {
                    Console.WriteLine("{0} {1}", numsToText[firstNum] + " hundred and", numsToText[thirdNum]);
                }
            }
            else
            {
                if (thirdNum == 0)
                {
                    Console.WriteLine(numsToText[firstNum] + " hundred and " + tensToText[secondNum - 2]);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", numsToText[firstNum] + " hundred and", tensToText[secondNum - 2], numsToText[thirdNum]);
                }
            }
        }
    }
}
