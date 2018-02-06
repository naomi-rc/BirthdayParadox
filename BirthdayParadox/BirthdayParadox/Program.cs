using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayParadox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 2a");

            Random rand = new Random(1234);
            Console.WriteLine("C# sample of the first 10 random numbers with a seed of 1234:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i={0} rand = {1}", i+1, rand.Next());
            }


            const int MAXPEOPLE = 50;
            const int TRIALSIZE = 10000;
            const int MAXDAYS = 365;
            int[] birthdayValue = new int[MAXPEOPLE];
            Random randomNumber = new Random(1234);


            // Console.WriteLine("Enter the number of people: ");
            //int size = 0; // Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nTRIALSIZE = {0}", TRIALSIZE);
            Console.WriteLine("People \tRandom Probability \tTheoretical Probability");

            for (int numberOfPeople = 2; numberOfPeople < MAXPEOPLE; numberOfPeople++)
            {
                double duplicateCount = 0;
                Console.Write(numberOfPeople + "\t");
                
                for (int trial = 0; trial < TRIALSIZE; trial++)
                {
                    
                    for (int index = 0; index < numberOfPeople; index++)
                    {
                        birthdayValue[index] = randomNumber.Next(MAXDAYS);
                        //Console.WriteLine(birthdayValue[index]);
                    }
                    if(isThereADuplicate(birthdayValue, numberOfPeople))
                    {
                        duplicateCount++;
                    }
                }
                Console.WriteLine(duplicateCount / TRIALSIZE + "\t\t");
                //Console.WriteLine((double)duplicateCount +"\t\t");
            }

            
            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i={0} rand = {1}", i+1, birthdayValue[i]);
            }*/

            


        }

        public static bool isThereADuplicate(int[] birthdayValue, int size)
        {
            for(int index1 = 0; index1 < size; index1++)
            {
                for(int index2 = 0; index2 < size; index2++)
                {
                    if(birthdayValue[index1] == birthdayValue[index2] && index1 != index2)
                    {
                       // Console.WriteLine(i + " and " + j + ": " + birthdayValue[i]);
                        return true;
                    }
                }

            }
            return false;
        }
    }
}
