using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Runner.Libraries;

namespace Runner
{
    class Program
    {
        private const string ENTRY_SENTENCE = "Please select the problem you want to solve";
        private const string PROBLEM_FIRST = "Enter key '1' to find the sum of multiple of three or five numbers";
        private const string PROBLEM_SECOND = "Enter key '2' to find the uppercase chars in the string text";
        private const string QUIT_SENTENCE = "Enter key '-1' to close the program";
        private const string NN_ENTRY = "Please enter the limit";
        private const string NN_RESULT = "The sum of multiple of three or five numbers";
        private const string SA_ENTRY = "Please enter text";
        private const string SA_RESULT = "Uppercase chars";

        static void Main(string[] args)
        {
            Console.WriteLine($"{ENTRY_SENTENCE}: \n{PROBLEM_FIRST}\n{PROBLEM_SECOND}\n{QUIT_SENTENCE}: ");
            int entry = ConsoleIntegerEntry();

            while (entry != -1)
            {
                switch (entry)
                {
                    case 1:
                        RunSumOfMultiple();
                        break;
                    case 2:
                        RunSequenceAnalysis();
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"\n{ENTRY_SENTENCE}: \n{PROBLEM_FIRST}\n{PROBLEM_SECOND}\n{QUIT_SENTENCE}: ");
                entry = ConsoleIntegerEntry();
            }
        }

        private static int ConsoleIntegerEntry()
        {
            try
            {
                int entry = Convert.ToInt32(Console.ReadLine());
                return entry;
            }
            catch (FormatException)
            {
                Console.WriteLine("error occured");
                return -1;
            }
        }

        private static void RunSumOfMultiple()
        {
            Console.WriteLine($"{NN_ENTRY}: ");
            int entry = ConsoleIntegerEntry();

            SumOfMultiple sumOfMultiple = new SumOfMultiple();
            Console.WriteLine($"{NN_RESULT}: {sumOfMultiple.MultipleOfThreeAndFive(entry)}");
        }

        private static void RunSequenceAnalysis()
        {
            Console.WriteLine($"{SA_ENTRY}: ");
            string entry = Console.ReadLine();

            SequenceAnalysis sequenceAnalysis = new SequenceAnalysis();
            Console.WriteLine($"{SA_RESULT}: {sequenceAnalysis.UppercaseChars(entry)}");
        }
    }
}
