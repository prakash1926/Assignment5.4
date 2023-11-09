using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine("Enter Random integers :");

            for(int i=0; i<array.Length; i++) 
            {
                int myarray =int.Parse(Console.ReadLine());
                array[i] = myarray;
            }
            Console.WriteLine("Populated array :");
           
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");

            }
            int sum = 0;
            Console.WriteLine("\nsum of array elements :");
            foreach (int num in array) 
            {
               
                sum = sum + num;
            }
            double average=sum/array.Length;

            Console.WriteLine(sum + "\n ");
            Console.WriteLine("Average of the elements : "+average);
            Console.ReadKey();
        }
    }
}
