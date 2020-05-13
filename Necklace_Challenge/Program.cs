//Imagine a necklace with lettered beads that can slide along the string.
//Here's an example image. In this example, you could take the N off NICOLE and slide it around to the other end to make ICOLEN.
//Do it again to get COLENI, and so on. For the purpose of today's challenge, we'll say that the strings "nicole", "icolen", and
//"coleni" describe the same necklace.

//Generally, two strings describe the same necklace if you can remove some number of letters
//from the beginning of one, attach them to the end in their original ordering, and get the other string.
//Reordering the letters in some other way does not, in general, produce a string that describes the same necklace.

//Write a function that returns whether two strings describe the same necklace.


using System;

namespace Necklace_Challenge
{
    class NecklaceMatcher
    {
        public static string Matcher(string necklace1, string necklace2)
        {
            string result = "";
            string necklace2Reordered = "";
            Console.WriteLine($"{necklace1[0]} is the first letter of necklace 1");
            for (int i = 0; i < necklace2.Length; i++)
            {
                //reorder the necklace 2 into the same order as necklace 1. then we can compare
                if (necklace2[i] == necklace1[0])
                {
                    //here we split necklace2 into two parts. first part starts with the first letter of necklace 1 and goes to the end of necklace2
                    //second part is whatever was before that letter. putting these two new strings together should make it the string same as necklace1
                    Console.WriteLine("found a matching letter");
                    string secondPart = necklace2.Substring(0, i);
                    string firstPart = necklace2.Substring(i);
                    necklace2Reordered = firstPart + secondPart;
                    Console.WriteLine($"first part is: {firstPart}, second part is: {secondPart}. Together that makes {necklace2Reordered}");

                }
            }
            //now another for loop to compare necklace1 and necklace2Reordered
            for(int i = 0; i < necklace1.Length; i++)
            {
                if(necklace1[i] != necklace2Reordered[i])
                {
                    result = "these are not the same necklace";
                }
                else
                {
                    result = $"these necklaces are the same! when rearranged. {necklace2} can be reordered to be {necklace2Reordered}";
                }
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string necklace1 = "";
            string necklace2 = "";
            string result = "";

            //ask for firsdt necklace
            Console.Write("Type the string for necklace one and press enter");
            necklace1 = Console.ReadLine();

            //second necklace
            Console.Write("Type the string for necklace two and press enter");
            necklace2 = Console.ReadLine();

            try
            {
                //we use the NecklaceMatcher class here
                result = NecklaceMatcher.Matcher(necklace1, necklace2);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while trying to match the necklaces" + e.Message);
            }
            return;
        }
    }
}
