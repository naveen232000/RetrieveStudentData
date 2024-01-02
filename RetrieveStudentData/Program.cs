using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrieveStudentData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Mphasis\SimpleliLearn Doc .net\Practice Problems\C#basic\C#BasicProblemSolutions\Retrieve Student Data from a Text File\Student Data.txt";
            string[] lines = File.ReadAllLines(filePath);

            // Print headers
            string[] headers = lines[0].Split(',');
            Console.WriteLine("{0,-5} {1,-15} {2,-5} {3,-7} {4,-5}", headers[0], headers[1], headers[2], headers[3], headers[4]);

            // Print data
            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                Console.WriteLine("{0,-5} {1,-15} {2,-5} {3,-7} {4,-5}", data[0], data[1], data[2], data[3], data[4]);
            }
            Console.ReadLine(); 
        }
    }
}
