using System;
namespace Deliverable_5
{
    class Program
    {
        static int[] random_array(int array_length)
        {
            Random random= new Random();
            int[] OneArray = new int[array_length]; //defining OneArray inside the random array method

            for (int i = 0; i < array_length; i++)
            {
                OneArray[i] = random.Next(10, 50);
            }
            return OneArray;

        }
        static int sum(int[] ThreeArray)
        {
            int sum = 0;
            foreach (int item in ThreeArray)
            {
                sum += item;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Boolean done = false;
        while(!done)
            { 
            Console.WriteLine("Please enter an integer between 5 and 15");
                try
                {
                    while (true)
                    {
                        int input = int.Parse(Console.ReadLine());
                        int[] TwoArray = random_array(input);//calling the random array method, using for the TwoArray array

                        if (input >= 5 && input <= 15)
                        {
                            Console.WriteLine("The Elements of a random array of " + input + " numbers is:");

                            foreach (int element in TwoArray)
                            {
                                Console.Write(element + "      ");
                            }
                            Console.WriteLine("");
                            Console.WriteLine("The sum of the elements in the array is " + sum(TwoArray));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please make sure your integer is between 5 and 15");
                        }
                    }
                    done = true;
                }

                catch
                {
                    Console.WriteLine("That is not an integer.");
                }         
            }
        }
    }
}