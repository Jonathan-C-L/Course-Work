/* CMPE 1666 - Intermediate Programming
 * 
 * Author: Jonathan Le
 * 
 * Date: Jan 16, 2025
 * 
 * Purpose: program will use methods to take a minimum and maximum value from the user,
 * creates an array of random values, then uses a linear search to count the 
 * number of occurrances of the specified integer parameter value.
 * 
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA_1_Jonathan_Le
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorLeft = Console.WindowWidth / 2 - 10;
            Console.WriteLine("ICA 1 - Jonathan Le");
            Console.WriteLine();

            //getting size of array to be filled with random integers
            int valuesGenerated = GetValue("Input the size of the array to generate (10-100): ", 10, 100);

            //declaring size of array from 'valuesGenerated' 
            int[] array = new int[valuesGenerated];

            //getting lower and upper limit of inputs with input validation
            GetRange(out int lowerLimit, out int upperLimit);

            //filling array with randomly generated integers
            array = GenerateArray(valuesGenerated, lowerLimit, upperLimit);

            //displaying the array for user to see in console
            DisplayArray(array);

            //initializing loop conditions for re-running value searching
            bool loop, trap;

            //loop for value search + count
            do
            {
                loop = false;
                //input for value to be searched
                int searchValue = GetValue($"Enter value to be searched ({lowerLimit}, {upperLimit}): ", lowerLimit, upperLimit);

                //count of times 'searchValue' was encountered in array
                int searchCount = CountOccurrences(array, searchValue);
                if (searchCount > 0)
                {
                    Console.WriteLine($"Number of occurrences of {searchValue} is {searchCount}");
                }
                else
                {
                    Console.WriteLine($"{searchValue} not found in array");
                }

                trap = false;

                //prompt and validation for user to re-run search
                do
                {
                    Console.Write("Do you want to search for another value: ");
                    string answer = Console.ReadLine();
                    answer.ToLower();
                    if (answer == "y")
                    {
                        loop = true;
                        trap = false;
                    }
                    else if (answer == "n")
                    {
                        loop = false;
                        trap = false;
                    }
                    else
                    {
                        Console.WriteLine("You must respond with a 'y' or 'n'. Please try again...");
                        trap = true;
                    }
                } while (trap);
                
            } while (loop);

            Console.Write("Press any key to exit... ");
            Console.ReadLine();


        }
        /// <summary>
        /// GetValue() prompts a user for an integer value and accepts values within the
        /// accepted range.
        /// </summary>
        /// <param name="prompt">string prompting for input</param>
        /// <param name="minimum">minimum value for input</param>
        /// <param name="maximum">maximum value for input</param>
        /// <returns></returns>
        static int GetValue(string prompt, int minimum, int maximum)
        {
            int value;
            bool loop;
            //validation loop
            do
            {
                loop = false;
                //input from user
                Console.Write(prompt);
                int.TryParse(Console.ReadLine(), out value);
                //prompt for user to correct error + trap for correction
                if (value < minimum || value > maximum)
                {
                    Console.WriteLine("Input is out of range. Please Try Again.");
                    loop = true;
                }
                Console.WriteLine();
            } while (loop);
          
            return value;
        }
        /// <summary>
        /// GetRange() uses GetValue() twice to get values for the lower and upper limits
        /// </summary>
        /// <param name="lowerLimit">lower limit</param>
        /// <param name="upperLimit">upper limit</param>
        static void GetRange(out int lowerLimit, out int upperLimit)
        {
            //validation loop
            bool loop;
            do
            {
                loop = false;
                lowerLimit = GetValue("Enter the lower limit of the range of values to generate (0-100): ", 0, 100);
                upperLimit = GetValue("Enter the upper limit of the range of values to generate (0-100): ", 0, 100);
                if (lowerLimit > upperLimit)
                {
                    Console.WriteLine("The lower limit cannot be greater than the upper limit. Please try again.");
                    loop = true;
                }
                Console.WriteLine();
            } while (loop);
        }
        /// <summary>
        /// GenerateArray() creates an array of the size of the randomly generated amount specified.
        /// The values generated must be within the specified lower and upper limits
        /// </summary>
        /// <param name="valuesGenerated">number of values generated for the array</param>
        /// <param name="lowerLimit">lower limit</param>
        /// <param name="upperLimit">upper limit</param>
        /// <returns></returns>
        static int[] GenerateArray(int valuesGenerated, int lowerLimit, int upperLimit)
        {
            Random rand = new Random();
            int[] array = new int[valuesGenerated];

            //for loop iterates through array and fills with random integers
            for (int count = 0; count < array.Length; count++)
            {
                array[count] = rand.Next(lowerLimit, upperLimit+1);
            }

            return array;
        }
        /// <summary>
        /// DisplayArray() displays all of the values stored within the array.
        /// </summary>
        /// <param name="array">array of int</param>
        static void DisplayArray(int[] array)
        {
            Console.Write("The generated values are: |");
            for (int count = 0; count<array.Length; count++)
            {
                Console.Write($"{array[count]}|");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// CountOccurences() tracks the number of times a specified number was encountered within the give array.
        /// </summary>
        /// <param name="array">array of int</param>
        /// <param name="variable">specified int to be tracked</param>
        /// <returns></returns>
        static int CountOccurrences(int[] array, int variable)
        {
            int total = 0;
            //checking each element to see if it matches 'variable' parameter and counts them
            foreach (int count in array)
            {
                if (count == variable)
                {
                    total++;
                }
            }
            return total;
        }
    }
}
