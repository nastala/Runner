using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner.Libraries
{
    class SumOfMultiple
    {
        public int MultipleOfThreeAndFive(int limit)
        {
            int result = 0;

            for (int i = 1; i <= limit; i++)
            {
                if (IsMultipleOfThree(i) || IsMultipleOfFive(i))
                    result += i;
            }

            return result;
        }

        private bool IsMultipleOfThree(int number)
        {
            return number % 3 == 0;
        }

        private bool IsMultipleOfFive(int number)
        {
            return number % 5 == 0;
        }
    }
}
