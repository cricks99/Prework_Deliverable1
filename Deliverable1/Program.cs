using System;

namespace Deliverable1
{
    class Progam
    {
        static void Main(string[] args)
        {
            int numPeople, slicesOfBread, tablespoonsOfPeanutButter, teaspoonsOfJelly, neededBreadLoves, neededJarsOfPeanutButter, neededJarsOfJelly;
            string keepAsking;

            do
            {
                Console.Write("\nHow many people are we making PB&J sandwiches for? ");
                numPeople = int.Parse(Console.ReadLine());

                slicesOfBread = numPeople * 2;
                tablespoonsOfPeanutButter = numPeople * 2;
                teaspoonsOfJelly = numPeople * 4;

                neededBreadLoves = (int)Math.Ceiling(slicesOfBread / 28.0);
                neededJarsOfPeanutButter = (int)Math.Ceiling(tablespoonsOfPeanutButter / 32.0);
                neededJarsOfJelly = (int)Math.Ceiling(teaspoonsOfJelly / 48.0);

                Console.WriteLine("\nYou need:\n");
                Console.WriteLine(slicesOfBread + " slices of bread");
                Console.WriteLine(tablespoonsOfPeanutButter + " tablespoons of peanut butter");
                Console.WriteLine(teaspoonsOfJelly + " teaspoons of jelly");
                Console.WriteLine("\nwhich is...\n");
                Console.WriteLine(neededBreadLoves + " loves of bread");
                Console.WriteLine(neededJarsOfPeanutButter + " jars of peanut butter");
                Console.WriteLine(neededJarsOfJelly + " jars of jelly\n");

                Console.WriteLine("Would you like to restart?  Enter yes or y to coninue, or enter any other key to exit.");
                keepAsking = Console.ReadLine();
            }
            while (keepAsking == "y" || keepAsking == "yes");

            Console.WriteLine("\nGoodbye!");
        }
    }
}