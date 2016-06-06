/*Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
character	Valid card sign?
5	yes
1	no
Q	yes
q	no
P	no
10	yes
500	no
*/
using System;

class CheckForPlayCard
{
    static void Main()
    {
        string[] playCards = new string[] {"2", "3", "4", "5","6","7","8","9","10","J","Q","K","A", };
        string userInput;
        string result = "NO";
        Console.WriteLine("Please enter play card symbol:");
        userInput = Console.ReadLine();
       
        for (int i = 0; i < playCards.Length; i++)
        {
            if (userInput == playCards[i])
            {
                result = "YES";
            }
        }

        Console.WriteLine("{0}", result);
    }
}

