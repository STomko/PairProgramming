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


            // Find two lowest numbers, remove from array, add together + append to end
            int[] twoLowestValues = new int[2];

            for (int i = 0; i < 2; i++)
            {
                int lowestInt = numArray.Min();
                numArray = numArray.Where(x => x != lowestInt).ToArray();
                twoLowestValues[i] = lowestInt;
            }

            List<int> tempNumArray = numArray.ToList();
            tempNumArray.Add(twoLowestValues.Sum());
            numArray = tempNumArray.ToArray();



            /*numArray = sumToArray(twoLowestValues[0], twoLowestValues[1], numArray);
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(numArray[i]);
            }*/
            Console.ReadKey();

        }

        //Takes in two integers, sums them and appends them to the array.
        /*static int[] sumToArray(int num1, int num2, int[] numArray)
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
        }*/
    }
}
