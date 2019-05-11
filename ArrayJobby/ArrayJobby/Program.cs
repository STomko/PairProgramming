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
                twoLowestValues[i]=lowestInt;
			}

            List<int> tempNumArray = numArray.ToList();
            tempNumArray.Add(twoLowestValues.Sum());
            numArray = tempNumArray.ToArray();

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // What's this? a shameless plug?
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
