using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignmentsForCourses
{
    public class PrimeNumbers
    {
        private int _min;
        private int _max;
        public string Result { get; set; }

        public PrimeNumbers(int min, int max)
        {
            _min = min;
            _max = max;
            Result = FindPrimesInRange(_min, _max);
        }

        private string FindPrimesInRange(int min, int max)
        {
            var res = new StringBuilder();

            for (int num = min; num <= max; num++)
            {
                if (IsPrime(num))
                    res.Append(num.ToString()).Append(" ");
            }
            return res.ToString().Trim();
        }
        private bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
