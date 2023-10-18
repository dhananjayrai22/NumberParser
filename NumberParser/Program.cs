using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberParser
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: NumberParser <comma-delimited-list> <format>");
                WaitForKeyToExit(); // Add this line to wait for user input
                return;
            }

            string input = args[0];
            string format = args[1];

            int[] numbers = input.Split(',')
                .Select(str => int.Parse(str))
                .OrderByDescending(num => num)
                .ToArray();

            IOutputFormatter formatter = OutputFormatterFactory.GetFormatter(format);
            formatter.FormatAndSave(numbers, $"sorted_numbers.{format}");
            Console.WriteLine($"Sorted numbers have been saved in {format} format.");

            WaitForKeyToExit(); // Add this line to wait for user input
        }

        static void WaitForKeyToExit()
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
