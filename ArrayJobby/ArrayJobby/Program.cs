using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayJobby
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple array of random numbers.
            int[] numArray = new int[] {85,12,3,72,111,26,18,55,90,8,-12,6};


            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // What's this? a shameless plug?
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 


            //DEBUG - This code is to test that the sumToArray function works.
            numArray = sumToArray(5, 12, numArray);
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(numArray[i]);
            }
            Console.ReadKey();
            //DEBUG - End
        }

        //Takes in two integers, sums them and appends them to the array.
        static int[] sumToArray(int num1, int num2, int[] numArray)
        {
            //Sums the two values.
            int total = num1 + num2;

            //Creates a new array one larger than the input array (to store the new total)
            int[] returnArray = new int[numArray.Length + 1];

            //Populates the new array with the existing array.
            for (int i = 0; i < numArray.Length; i++)
            {
                returnArray[i] = numArray[i];
            }

            //Adds the new total to the end of the new array
            returnArray[returnArray.Length-1] = total;

            return returnArray;
        }
    }
}
