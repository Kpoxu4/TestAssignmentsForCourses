using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignmentsForCourses
{
    public class CommonDivisors
    {
        public string StringResult { get; set; }

        public CommonDivisors(int[] numbers) 
        {
            StringResult = FindCommonDivisors(numbers);
        }
        private string FindCommonDivisors(int[] numbers)
        {            
            int minNumber = int.MaxValue;
            StringBuilder res = new StringBuilder();  

            foreach (int num in numbers)
            {
                if (num < minNumber)
                    minNumber = num;
            }

            List<int> commonDivisors = new List<int>();

            for (int divisor = 1; divisor <= minNumber; divisor++)
            {
                bool isCommonDivisor = true;
                foreach (int num in numbers)
                {
                    if (num % divisor != 0)
                    {
                        isCommonDivisor = false;
                        break;
                    }
                }

                if (isCommonDivisor)
                    commonDivisors.Add(divisor);
            }

            foreach (int num in commonDivisors)
            {
                if (num == 1)
                {
                    continue;
                }
                res.Append(num).Append(" ");
            }

            return res.ToString().Trim();
        }
    }
}
