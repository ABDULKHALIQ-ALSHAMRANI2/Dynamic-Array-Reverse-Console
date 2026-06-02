using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the heart of the matrix");
            Console.WriteLine("==========================================");

            Console.WriteLine("Please enter the size of the array (an integer):");
            Console.WriteLine("-----------");

            int nSizeArray;
            while (!int.TryParse(Console.ReadLine(), out nSizeArray)||nSizeArray<=0)
            {
                Console.WriteLine("Please enter a valid number (1 or more):");
            }
                
                
            
            int[] nReverseArray = new int[nSizeArray]; //{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for(int i=0;i<nReverseArray.Length;i++)
            {
                Console.WriteLine($"Please enter The number {i+1} from the array:");
                while(!int.TryParse(Console.ReadLine(), out nReverseArray[i])||nReverseArray[i]<0)
                {
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine("❌ Invalid input! Please enter a number greater than 0: ");
                    Console.ResetColor();
                    Console.WriteLine("Try again:");
                }
            }

            int[] nArrayReverse = new int[nReverseArray.Length];

            for (int i = 0; i < nReverseArray.Length; i++) 
            {
                nArrayReverse[i] = nReverseArray[nReverseArray.Length - i - 1];
            }

            Console.WriteLine("==========================================");

            Console.Write("The First Array : ");
            for (int i = 0; i < nReverseArray.Length; i++) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($" {nReverseArray[i]}");
                Console.ResetColor();
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");

            Console.Write("The Second Array : ");
            for (int i = 0; i < nArrayReverse.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($" {nArrayReverse[i]}");
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.WriteLine("==========================================");

        }
    }
}
