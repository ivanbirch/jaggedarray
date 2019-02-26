using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare jagged array
            int[][] jaggedArray = new int[3][];
            //assign arrays
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[1];
            jaggedArray[2] = new int[2];

            //array with initializers
            jaggedArray[0] = new int[] { 4, 2, 6, 1, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            //alternative way to create, declare and initialise
            int[][] jaggedArray2 = new int[][]
            {
                new int[] {4, 2, 6, 1, 11 },
                new int[] { 1, 2, 3 }
            };

            //return one value
            //Console.WriteLine("The value in middle of the first entry is {0}:", jaggedArray2[0][2]);

            //return all values - 2 ways
            Console.WriteLine("the values in the first entry are: {0},{1},{2},{3},{4}", jaggedArray[0][0], jaggedArray[0][1], jaggedArray[0][2], jaggedArray[0][3], jaggedArray[0][4]);
            Console.WriteLine("the values in the second entry are: {0},{1},{2}", jaggedArray[1][0], jaggedArray[1][1], jaggedArray[1][2]);

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element {0}", i);
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                
                    Console.WriteLine("{0}", jaggedArray2[i][j]);
                
            }

            Console.ReadKey();
        }
    }
}
