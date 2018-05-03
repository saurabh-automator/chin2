//Ruby Necklace 
//=============
//It is the wedding day of Sanchi, the beautiful princess of Byteland. 
//Her fiance Krishna is planning to gift her an awesome ruby necklace. 
//Krishna has currently b-blue rubies, g-green rubies, r-red rubies and y -yellow rubies. 
//He has to arrange the rubies next to each other in a straight line to make the necklace. 
//But, there are a couple of rules to be followed while making this necklace:

//         A blue ruby should be followed by either a blue ruby or a red ruby
//          A green ruby should be followed by either a green ruby or a yellow ruby
//          A red ruby should be followed by either a green ruby or a yellow ruby
//          A yellow ruby should be followed by either a blue ruby or a red ruby
//          If it is possible, we should always start a necklace with a blue or a red ruby

//Can you tell what is the maximum possible length of the necklace that Krishna can make. 
//The length of a necklace is the number of rubies in it.
//----------------------------------------------------------------------------
//Input Format
//The first line contains an integer representing b.
//The second line contains an integer representing r.
//The third line contains an integer representing y.
//The fourth line contains an integer representing g.

//Constraints
//0 <= b, r, y, g <= 2000
//At least one of b, r, y, g is greater than 0

//Output Format
//A single integer which is the answer to the problem.
//==============================================================================================================================

using System;
using System.Collections.Generic;
using System.Text;

namespace BenTheGamer
{
    public class Ruby
    {
        public static void Main1(string[] args)
        {
            int red, green, blue, yellow, length = 0;
            blue = Convert.ToInt32(Console.ReadLine());
            red = Convert.ToInt32(Console.ReadLine());
            yellow = Convert.ToInt32(Console.ReadLine());
            green = Convert.ToInt32(Console.ReadLine());
            if (red == 0 && yellow == 0)
            {
                length = blue > 0 ? blue : green;
            }
            else if (red == yellow)
            {
                length = red + green + blue + yellow;
            }
            else if (red == 0)
            {
                length = blue > 0 ? blue : yellow > 0 ? green + 1 : green;
            }
            else
            {
                length = red > yellow ? blue + green + 2 * Math.Min(red, yellow) + 1 : blue + green + 2 * Math.Min(red, yellow);
            }
            

            Console.WriteLine(length);
            Console.ReadKey();
        }
    }
}
