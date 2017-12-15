using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventOfCode2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("inputData.txt");
            string inputData = sr.ReadToEnd();
            Console.WriteLine(inputData);

            Console.ReadLine();
            Console.WriteLine("{0}", inputData.GetType());
            Console.ReadLine();


            string[] inputDataRows = inputData.Split('\n');
            Console.WriteLine("Number of rows: {0}", inputDataRows.Length);
            Console.WriteLine("First row: {0}", inputDataRows[0]);
            Console.WriteLine("Last row: {0}", inputDataRows[15]);
            //  foreach string row in inputDataRows



            string[][] inputDataRowsSplit = new string[16][];
            for (int i = 0; i < 16; i++)
            {
                inputDataRowsSplit[i] = inputDataRows[i].Split('\t');
            }
            
            Console.WriteLine();
            Console.WriteLine();

            //print array
            for (int i = 0; i < inputDataRows.Length; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    Console.Write(inputDataRowsSplit[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            int[,] inputDataValues = new int[16, 16];
            
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    inputDataValues[i, j] = Int32.Parse(inputDataRowsSplit[i][j]);
                }
            }

            //print int array
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    Console.Write(inputDataValues[i,j]);


                }
                Console.WriteLine();
                
            }

            int checksum = 0;
            int tempMax = 0;
            int tempMin = 0;
            int[] currentRow = new int[16];


            Console.WriteLine("***** Zabawaaa *****");
            for (int i = 0; i < 16; i++)
            {
                tempMin = 0;
                tempMax = 0;

                for (int j = 0; j < 16; j++)
                {
                    currentRow[j] = inputDataValues[i, j];

                }
                Console.WriteLine("Current row {0} populated", i);
                tempMin = currentRow.Min();
                Console.WriteLine("Row's minimal value = {0}", tempMin);
                tempMax = currentRow.Max();
                Console.WriteLine("Row's maximal value = {0}", tempMax);
                checksum = checksum + (tempMax - tempMin);
                Console.WriteLine("Current checksum = {0}", checksum);



            }
           
            Console.ReadLine();

        }
    }
}
